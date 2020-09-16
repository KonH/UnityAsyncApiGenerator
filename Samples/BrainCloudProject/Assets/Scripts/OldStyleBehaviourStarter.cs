using System;
using BrainCloud.LitJson;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts {
	public sealed class OldStyleBehaviourStarter : MonoBehaviour {
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

		void OnLoginClick() {
			_wrapper.Init();
			_wrapper.ResetStoredProfileId();
			_wrapper.AuthenticateUniversal(_loginInput.text, _passwordInput.text, true, OnLoginSuccess, OnLoginFailure);
		}

		void OnLoginSuccess(string response, object cb) {
			Debug.Log(response);
			_loginPanel.SetActive(false);
			_infoPanel.SetActive(true);
			_wrapper.GlobalEntityService.GetListByIndexedId("global_key", 1, OnGetGlobalEntitySuccess, OnGetGlobalEntityFailure);
			_wrapper.EntityService.GetSingleton("local_key", OnGetLocalEntitySuccess, OnGetLocalEntityFailure);
		}

		void OnLoginFailure(int status, int reasonCode, string error, object cb) {
			Debug.LogError(error);
		}

		void OnGetGlobalEntitySuccess(string response, object cb) {
			Debug.Log(response);
			try {
				var entityList = JsonMapper.ToObject<EntityList>(response);
				Debug.Log($"Global entities found: {entityList.data.entityListCount}");
				if ( entityList.data.entityListCount == 0 ) {
					var data = JsonMapper.ToJson(new SimpleEntity());
					_wrapper.GlobalEntityService.CreateEntityWithIndexedId("global_entity", "global_key", 0, null, data, OnCreateGlobalEntitySuccess, OnCreateGlobalEntityFailure);
				} else {
					_globalEntity    = entityList.data.entityList[0];
					_globalText.text = string.Format(_globalFormat, _globalEntity.data.value);
				}
			} catch ( Exception e ) {
				Debug.LogException(e);
			}
		}

		void OnGetGlobalEntityFailure(int status, int reasonCode, string error, object cb) {
			Debug.LogError(error);
		}

		void OnCreateGlobalEntitySuccess(string response, object cb) {
			Debug.Log(response);
			try {
				var responseData = JsonMapper.ToObject<EntityResponse>(response);
				_globalEntity = new EntityHolder {
					data     = new SimpleEntity(),
					entityId = responseData.data.entityId,
					version  = responseData.data.version
				};
				_globalText.text = string.Format(_globalFormat, _globalEntity.data.value.ToString());
			} catch ( Exception e ) {
				Debug.LogException(e);
			}
		}

		void OnCreateGlobalEntityFailure(int status, int reasonCode, string error, object cb) {
			Debug.LogError(error);
		}

		void OnGetLocalEntitySuccess(string response, object cb) {
			Debug.Log(response);
			if ( string.IsNullOrEmpty(response) ) {
				var data = JsonMapper.ToJson(new SimpleEntity());
				_wrapper.EntityService.UpdateSingleton("local_key", data, null, 1, OnUpdateLocalEntitySuccess, OnUpdateLocalEntityFailure);
				return;
			}
			try {
				var responseData = JsonMapper.ToObject<EntityResponse>(response);
				_localEntity = new EntityHolder {
					data     = responseData.data.data,
					entityId = responseData.data.entityId,
					version  = responseData.data.version
				};
				_localText.text = string.Format(_localFormat, _localEntity.data.value.ToString());
			} catch ( Exception e ) {
				Debug.LogException(e);
			}
		}

		void OnGetLocalEntityFailure(int status, int reasonCode, string error, object cb) {
			Debug.LogError(error);
		}

		void OnGlobalClick() {
			_globalEntity.data.value++;
			var data = JsonMapper.ToJson(_globalEntity.data);
			_wrapper.GlobalEntityService.UpdateEntity(_globalEntity.entityId, _globalEntity.version, data, OnUpdateGlobalEntitySuccess, OnUpdateGlobalEntityFailure);
		}

		void OnUpdateGlobalEntitySuccess(string response, object cb) {
			Debug.Log(response);
			try {
				var responseData = JsonMapper.ToObject<EntityResponse>(response);
				_globalEntity = new EntityHolder {
					data    = _globalEntity.data,
					version = responseData.data.version
				};
				_globalText.text = string.Format(_globalFormat, _globalEntity.data.value.ToString());
			} catch ( Exception e ) {
				Debug.LogException(e);
			}
		}

		void OnUpdateGlobalEntityFailure(int status, int reasonCode, string error, object cb) {
			Debug.LogError(error);
		}

		void OnLocalClick() {
			_localEntity.data.value++;
			var data = JsonMapper.ToJson(_localEntity.data);
			_wrapper.EntityService.UpdateSingleton("local_key", data, null, _localEntity.version, OnUpdateLocalEntitySuccess, OnUpdateLocalEntityFailure);
		}

		void OnUpdateLocalEntitySuccess(string response, object cb) {
			Debug.Log(response);
			try {
				var responseData = JsonMapper.ToObject<EntityResponse>(response);
				_localEntity = new EntityHolder {
					data    = _localEntity?.data ?? new SimpleEntity(),
					version = responseData.data.version
				};
				_localText.text = string.Format(_localFormat, _localEntity.data.value.ToString());
			} catch ( Exception e ) {
				Debug.LogException(e);
			}
		}

		void OnUpdateLocalEntityFailure(int status, int reasonCode, string error, object cb) {
			Debug.LogError(error);
		}
	}
}