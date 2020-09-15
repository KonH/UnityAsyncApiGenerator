using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts {
	public sealed class EntryPointStarter : MonoBehaviour {
		[SerializeField]
		Button _oldStyleVariantButton;

		[SerializeField]
		Button _taskBasedVariantButton;

		void Start() {
			_oldStyleVariantButton.onClick.AddListener(() => SceneManager.LoadScene(1));
			_taskBasedVariantButton.onClick.AddListener(() => SceneManager.LoadScene(2));
		}
	}
}