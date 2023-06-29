using Cpp2ILInjected.CallAnalysis;
using TLD.OptionalContent;
using TLD.Platform;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

public class BootUpdate : MonoBehaviour
{
	private enum BootState
	{
		WaitingForDisclaimerFlow,
		Idle,
		WaitingForUserSignin,
		WaitingForOptionalContent,
		OptionalContentError,
		LoadingMainMenu
	}

	public UILabel m_LabelContinue;

	public GameObject m_Disclaimers;

	public GameObject m_FullScreenCover;

	public GameObject m_MainDisclaimerRoot;

	public GameObject[] m_DisclaimerScreenList;

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

	private int m_DisclaimerScreenIndex;

	private AsyncOperationHandle<SceneInstance> m_AsyncOp;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetPressAnyKeyString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateInputSystem")]
	[Calls(Type = typeof(BootUpdate), Member = "OnNextDisclaimerScreen")]
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
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
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
	[Calls(Type = typeof(PlatformManager), Member = "IsUserLoggedIn")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PlatformManager), Member = "Initialize")]
	[Calls(Type = typeof(PlatformManager), Member = "LoginUserAsync")]
	[CallsUnknownMethods(Count = 1)]
	private void SignInUser()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformManager), Member = "IsUserLoggedIn")]
	private bool IsUserSignedIn()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private bool IsDisclaimerScreenFlowDone()
	{
		return false;
	}

	[CalledBy(Type = typeof(BootUpdate), Member = "OnNextDisclaimerScreen")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MoveFromDisclaimerFlowToIdle()
	{
	}

	[CalledBy(Type = typeof(BootUpdate), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BootUpdate), Member = "MoveFromDisclaimerFlowToIdle")]
	[CallsUnknownMethods(Count = 2)]
	public void OnNextDisclaimerScreen()
	{
	}

	[CallerCount(Count = 0)]
	public BootUpdate()
	{
	}
}
