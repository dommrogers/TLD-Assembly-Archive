using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmptyScene : MonoBehaviour
{
	public enum State
	{
		Error = -1,
		Starting,
		InitializingUser,
		LoadingSave,
		LoadingScene,
		NewGame,
		Jump
	}

	private const int BOOT_SCENE_ID = 1;

	private GameObject m_WiseAudioPrefab;

	private GameObject m_GameManagerPrefab;

	private static SaveSlotInfo s_SaveSlotInfo;

	public static string s_SceneLoadFromEmpty;

	public static State s_State;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadScene")]
	[Calls(Type = typeof(EmptyScene), Member = "LoadScene")]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void UpdateUserInitialization()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	private void UpdateLoadingSave()
	{
	}

	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudio")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(Utils), Member = "XPModeIsChallenge")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	private void UpdateNewGame()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EmptyScene), Member = "MaybeInstantiateGameManager")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	private void LoadSaveFromCommandLine()
	{
	}

	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[Calls(Type = typeof(EmptyScene), Member = "MaybeInstantiateGameManager")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void StartNewGameFromCommandLine(ExperienceModeType xpmode)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "SetPhysicsAutoSimulationEnabled")]
	[CalledBy(Type = typeof(EmptyScene), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[Calls(Type = typeof(Utils), Member = "ClearUITextureCache")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "ForceGC")]
	[Calls(Type = typeof(EmptyScene), Member = "MaybeInstantiateLoadingScreen")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "HasUITextureCache")]
	private void LoadScene(string scene)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(EmptyScene), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateOnlineSystems")]
	[Calls(Type = typeof(AssetBundleManager), Member = "Init")]
	[Calls(Type = typeof(GameManager), Member = "InitializeCulture")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateInputSystem")]
	private void InitializeSystems()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Localization), Member = "set_Language")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(Localization), Member = "GetLanguages")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLanguageStringFromSystemLang")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void ForceSystemLanguage()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(EmptyScene), Member = "StartNewGameFromCommandLine")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadSaveFromCommandLine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void MaybeInstantiateGameManager(ExperienceModeType xpmode)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InterfaceManager), Member = "CreateInterfaceManager")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	private void MaybeInstantiateLoadingScreen()
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CallerCount(Count = 0)]
	private static void OnLoadComplete()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
	[CallerCount(Count = 2)]
	private bool IsSaveSystemInitialized()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void InitializeAndSignInUser()
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EmptyScene()
	{
	}
}
