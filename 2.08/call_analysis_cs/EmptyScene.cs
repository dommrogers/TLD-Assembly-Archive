using System;
using System.Globalization;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gameplay;
using TLD.OptionalContent;
using TLD.PDID;
using TLD.Platform;
using TLD.Scenes;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;

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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static PlatformManager.OnLoginUserCompleteHandler _003C_003E9__26_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		internal void _003CInitializeAndSignInUser_003Eb__26_0(IPlatformProvider provider, bool succeeded)
		{
		}
	}

	private AssetReference m_BootScene;

	private bool m_AutoLoadDefaults;

	private AssetReferenceRegionSpecification m_DefaultRegion;

	private AssetReferenceGameModeConfig m_DefaultGameMode;

	private VoicePersona m_DefaultVoice;

	private AssetReferenceGameObject m_WiseAudioPrefab;

	private AssetReferenceGameObject m_GameManagerPrefab;

	private PanelReference<Panel_Loading> m_Loading;

	private static SaveSlotInfo s_SaveSlotInfo;

	public static string s_SceneLoadFromEmpty;

	public static State s_State;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EmptyScene), Member = "LoadScene")]
	[Calls(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[Calls(Type = typeof(Addressables), Member = "LoadSceneAsync")]
	[Calls(Type = typeof(EmptyScene), Member = "InitializeAndSignInUser")]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[Calls(Type = typeof(EmptyScene), Member = "MaybeInstantiateGameManager")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "InitializeAsync")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(PlatformManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UpdateUserInitialization()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	private void UpdateLoadingSave()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
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
	private void StartNewGameFromCommandLine(GameModeConfig gameModeConfig)
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "Start")]
	[Calls(Type = typeof(TextureCache), Member = "ClearTextureCache")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[Calls(Type = typeof(GameManager), Member = "GetTargetMainMenuSceneName")]
	[Calls(Type = typeof(GameManager), Member = "MatchesMainMenuSceneName")]
	[Calls(Type = typeof(GameManager), Member = "SetPhysicsAutoSimulationEnabled")]
	[Calls(Type = typeof(TextureCache), Member = "HasTextureCache")]
	[Calls(Type = typeof(InterfaceManager), Member = "CreateInterfaceManager")]
	[Calls(Type = typeof(PdidTable), Member = "MaybeRemoveDeadGameObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "ForceGC")]
	private void LoadScene(string scene)
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateInputSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateOnlineSystems")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadManifest")]
	[Calls(Type = typeof(CaseInsensitiveResourceLocator), Member = ".ctor")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(GameManager), Member = "InitializeCulture")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.AddressableAssets.AddressablesImpl), Member = "AddResourceLocator")]
	private void InitializeSystems()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[Calls(Type = typeof(Localization), Member = "set_Language")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLanguageStringFromSystemLang")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[CallerCount(Count = 1)]
	private void ForceSystemLanguage()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(EmptyScene), Member = "StartNewGameFromCommandLine")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateUserInitialization")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadSaveFromCommandLine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	private void MaybeInstantiateGameManager(GameModeConfig gameModeConfig)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "CreateInterfaceManager")]
	private void MaybeInstantiateLoadingScreen()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	private static void OnLoadComplete()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	private bool IsSaveSystemInitialized()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlatformManager), Member = "Initialize")]
	[CalledBy(Type = typeof(EmptyScene), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeAndSignInUser()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsUserSignedIn()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public EmptyScene()
	{
	}
}
