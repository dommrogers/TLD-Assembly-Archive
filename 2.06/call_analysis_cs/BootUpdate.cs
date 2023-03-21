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
		Idle,
		WaitingForUserSignin,
		WaitingForOptionalContent,
		LoadingMainMenu
	}

	public UILabel m_Label_Continue;

	public UILabel m_Label_StudioStatement;

	public GameObject m_WiseAudioPrefab;

	private AsyncOperation m_AsyncOperation;

	private BootState m_BootState;

	private bool m_WaitingForSignedInUser;

	private static bool m_HasInitializedSystems;

	private AsyncOperationHandle<SceneInstance> m_AsyncOp;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetPressAnyKeyString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformManager), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(GameManager), Member = "GetTargetMainMenuSceneName")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "CheckForActiveController")]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(Input), Member = "ResetInputAxes")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(OptionalContentManager), Member = "InitializeAsync")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetTargetMainMenuSceneName")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	private void LoadMainMenu()
	{
	}

	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 12)]
	public BootUpdate()
	{
	}
}
