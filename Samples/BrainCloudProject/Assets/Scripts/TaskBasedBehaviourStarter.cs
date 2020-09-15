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
	}
}