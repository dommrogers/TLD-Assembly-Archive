using Cpp2ILInjected.CallAnalysis;
using TLD.OptionalContent;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

public class BootUpdate : MonoBehaviour
{
	private enum BootState
	{
		WaitingForStudioStatement,
		Idle,
		WaitingForUserSignin,
		WaitingForOptionalContent,
		OptionalContentError,
		LoadingMainMenu
	}

	public UILabel m_LabelContinue;

	public UIPanel m_LabelStudioStatement;

	public GameObject m_Disclaimers;

	public GameObject m_WiseAudioPrefab;

	public string m_SupportUrl;

	public GameObject m_ErrorState;

	public UILabel m_ErrorLabel;

	public LocalizedString m_ErrorText;

	public GameObject m_QuitAndContactSupportParent;

	public GameObject m_OnlyContactSupportParent;

	public GameObject[] m_XboxButtonPrompts;

	public GameObject[] m_SteamButtonPrompts;

	public GameObject[] m_PS4ButtonPrompts;

	private AsyncOperation m_AsyncOperation;

	private BootState m_BootState;

	private AsyncOperationHandle<SceneInstance> m_AsyncOp;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetPressAnyKeyString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateInputSystem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "CheckForActiveController")]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	private bool HasPressedKey()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	private void ShowOptionalContentErrorState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateOptionalContentErrorState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	public void OnContactSupport()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnQuitGame()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetTargetMainMenuSceneName")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	private void LoadMainMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "InitializeAsync")]
	[CallsUnknownMethods(Count = 1)]
	private void SignInUser()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool IsUserSignedIn()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BootUpdate()
	{
	}
}
