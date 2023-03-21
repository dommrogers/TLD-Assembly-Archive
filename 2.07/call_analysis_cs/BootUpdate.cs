using System;
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

	[Calls(Type = typeof(GameManager), Member = "InstantiateInputSystem")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetPressAnyKeyString")]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "CheckForActiveController")]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	private bool HasPressedKey()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	private void ShowOptionalContentErrorState()
	{
	}

	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "InitializeAsync")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	private void SignInUser()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool IsUserSignedIn()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BootUpdate()
	{
	}
}
