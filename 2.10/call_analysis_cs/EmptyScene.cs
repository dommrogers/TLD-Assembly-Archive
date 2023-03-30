using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gameplay;
using TLD.OptionalContent;
using TLD.PDID;
using TLD.Platform;
using TLD.SaveState;
using TLD.Scenes;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformManager), Member = "Update")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "InitializeAsync")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(EmptyScene), Member = "MaybeInstantiateGameManager")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateLoadingSave()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetExperienceModeDefinition")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateNewGame()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(EmptyScene), Member = "MaybeInstantiateGameManager")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "MaybeRemoveDeadGameObjects")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(InterfaceManager), Member = "CreateInterfaceManager")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[Calls(Type = typeof(GameManager), Member = "ForceGC")]
	[Calls(Type = typeof(TextureCache), Member = "HasTextureCache")]
	[Calls(Type = typeof(TextureCache), Member = "ClearTextureCache")]
	[Calls(Type = typeof(GameManager), Member = "SetPhysicsAutoSimulationEnabled")]
	[Calls(Type = typeof(GameManager), Member = "MatchesMainMenuSceneName")]
	[Calls(Type = typeof(GameManager), Member = "GetTargetMainMenuSceneName")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	private void LoadScene(string scene)
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InitializeCulture")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadManifest")]
	[Calls(Type = typeof(CaseInsensitiveResourceLocator), Member = ".ctor")]
	[Calls(TypeFullName = "UnityEngine.AddressableAssets.AddressablesImpl", Member = "AddResourceLocator")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateOnlineSystems")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateInputSystem")]
	[Calls(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void InitializeSystems()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLanguageStringFromSystemLang")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Localization), Member = "set_Language")]
	[CallsUnknownMethods(Count = 3)]
	private void ForceSystemLanguage()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateUserInitialization")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadSaveFromCommandLine")]
	[CalledBy(Type = typeof(EmptyScene), Member = "StartNewGameFromCommandLine")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeInstantiateGameManager(GameModeConfig gameModeConfig)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(InterfaceManager), Member = "CreateInterfaceManager")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	private void MaybeInstantiateLoadingScreen()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateMissionServicesManager")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsUnknownMethods(Count = 1)]
	private static void OnLoadComplete()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
	private bool IsSaveSystemInitialized()
	{
		return false;
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlatformManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeAndSignInUser()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsUserSignedIn()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EmptyScene()
	{
	}
}
