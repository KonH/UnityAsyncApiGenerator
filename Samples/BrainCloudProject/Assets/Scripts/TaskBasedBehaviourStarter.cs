using System;
using System.Threading.Tasks;
using BrainCloud.LitJson;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts {
	public sealed class TaskBasedBehaviourStarter : MonoBehaviour {
		[SerializeField]
		GameObject _loginPanel;

		[SerializeField]
		GameObject _infoPanel;

		[SerializeField]
		TMP_InputField _loginInput;

		[SerializeField]
		TMP_InputField _passwordInput;

		[SerializeField]
		Button _loginButton;

		[SerializeField]
		TMP_Text _globalText;

		[SerializeField]
		TMP_Text _localText;

		[SerializeField]
		Button _globalButton;

		[SerializeField]
		Button _localButton;

		BrainCloudWrapper _wrapper;

		string _globalFormat;
		string _localFormat;

		EntityHolder _globalEntity;
		EntityHolder _localEntity;

		void Awake() {
			_loginPanel.SetActive(true);
			_infoPanel.SetActive(false);
			_loginButton.onClick.AddListener(OnLoginClick);
			_globalButton.onClick.AddListener(OnGlobalClick);
			_localButton.onClick.AddListener(OnLocalClick);
			_wrapper      = gameObject.AddComponent<BrainCloudWrapper>();
			_globalFormat = _globalText.text;
			_localFormat  = _localText.text;
		}

		async void OnLoginClick() {
			_wrapper.Init();
			_wrapper.ResetStoredProfileId();
			try {
				var loginResponse = await _wrapper.AuthenticateUniversalAsync(_loginInput.text, _passwordInput.text, true);
				Debug.Log(loginResponse);
				_loginPanel.SetActive(false);
				_infoPanel.SetActive(true);
				await LoadGlobalEntity();
				await LoadLocalEntity();
			} catch ( Exception e ) {
				Debug.LogException(e);
			}
		}

		async Task LoadGlobalEntity() {
			var response = await _wrapper.GlobalEntityService.GetListByIndexedIdAsync("global_key", 1);
			Debug.Log(response);
			var entityList = JsonMapper.ToObject<EntityList>(response);
			Debug.Log($"Global entities found: {entityList.data.entityListCount}");
			if ( entityList.data.entityListCount == 0 ) {
				await CreateGlobalEntity();
			} else {
				_globalEntity    = entityList.data.entityList[0];
				_globalText.text = string.Format(_globalFormat, _globalEntity.data.value);
			}
		}

		async Task LoadLocalEntity() {
			var response = await _wrapper.EntityService.GetSingletonAsync("local_key");
			Debug.Log(response);
			if ( string.IsNullOrEmpty(response) ) {
				_localEntity = new EntityHolder {
					data = new SimpleEntity()
				};
				await UpdateLocalEntity();
				return;
			}
			var responseData = JsonMapper.ToObject<EntityResponse>(response);
			_localEntity = new EntityHolder {
				data     = responseData.data.data,
				entityId = responseData.data.entityId,
				version  = responseData.data.version
			};
			_localText.text = string.Format(_localFormat, _localEntity.data.value.ToString());
		}

		async Task CreateGlobalEntity() {
			var data = JsonMapper.ToJson(new SimpleEntity());
			var response = await _wrapper.GlobalEntityService.CreateEntityWithIndexedIdAsync("global_entity", "global_key", 0, null, data);
			Debug.Log(response);
			var responseData = JsonMapper.ToObject<EntityResponse>(response);
			_globalEntity = new EntityHolder {
				data     = new SimpleEntity(),
				entityId = responseData.data.entityId,
				version  = responseData.data.version
			};
			_globalText.text = string.Format(_globalFormat, _globalEntity.data.value.ToString());
		}

		async void OnGlobalClick() {
			_globalEntity.data.value++;
			var data = JsonMapper.ToJson(_globalEntity.data);
			var response = await _wrapper.GlobalEntityService.UpdateEntityAsync(_globalEntity.entityId, _globalEntity.version, data);
			Debug.Log(response);
			var responseData = JsonMapper.ToObject<EntityResponse>(response);
			_globalEntity = new EntityHolder {
				data    = _globalEntity.data,
				version = responseData.data.version
			};
			_globalText.text = string.Format(_globalFormat, _globalEntity.data.value.ToString());
		}

		async void OnLocalClick() {
			_localEntity.data.value++;
			await UpdateLocalEntity();
		}

		async Task UpdateLocalEntity() {
			var data = JsonMapper.ToJson(_localEntity.data);
			var response = await _wrapper.EntityService.UpdateSingletonAsync("local_key", data, null, 1);
			Debug.Log(response);
			var responseData = JsonMapper.ToObject<EntityResponse>(response);
			_localEntity = new EntityHolder {
				data    = _localEntity.data,
				version = responseData.data.version
			};
			_localText.text = string.Format(_localFormat, _localEntity.data.value.ToString());
		}
	}
}