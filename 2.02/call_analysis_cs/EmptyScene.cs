using System.Collections.Generic;
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
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadScene")]
	[Calls(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void UpdateUserInitialization()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateLoadingSave()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	[Calls(Type = typeof(Utils), Member = "XPModeIsChallenge")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudio")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 25)]
	private void UpdateNewGame()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EmptyScene), Member = "MaybeInstantiateGameManager")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void LoadSaveFromCommandLine()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EmptyScene), Member = "MaybeInstantiateGameManager")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void StartNewGameFromCommandLine(ExperienceModeType xpmode)
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EmptyScene), Member = "MaybeInstantiateLoadingScreen")]
	[Calls(Type = typeof(GameManager), Member = "ForceGC")]
	[Calls(Type = typeof(Utils), Member = "HasUITextureCache")]
	[Calls(Type = typeof(Utils), Member = "ClearUITextureCache")]
	[Calls(Type = typeof(GameManager), Member = "SetPhysicsAutoSimulationEnabled")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void LoadScene(string scene)
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InitializeCulture")]
	[Calls(Type = typeof(AssetBundleManager), Member = "Init")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateInputSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateOnlineSystems")]
	[Calls(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void InitializeSystems()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLanguageStringFromSystemLang")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Localization), Member = "GetLanguages")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(Localization), Member = "set_Language")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ForceSystemLanguage()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "LoadSaveFromCommandLine")]
	[CalledBy(Type = typeof(EmptyScene), Member = "StartNewGameFromCommandLine")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeInstantiateGameManager(ExperienceModeType xpmode)
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InterfaceManager), Member = "CreateInterfaceManager")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybeInstantiateLoadingScreen()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private static void OnLoadComplete()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsSaveSystemInitialized()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void InitializeAndSignInUser()
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EmptyScene()
	{
	}
}
