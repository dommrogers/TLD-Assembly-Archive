using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gameplay.Condition;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class SceneManager : ScriptableObject
{
	public struct SceneManagerSaveData
	{
		public List<string> m_AdditiveLayers;
	}

	public static List<string> s_AdditiveLayers;

	private static SceneManager s_Instance;

	private int m_LoadingCount;

	[CalledBy(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ProcessRegistrationQueue")]
	[CalledBy(Type = typeof(SceneManager), Member = "IsLoading")]
	[CalledBy(Type = typeof(SceneManager), Member = "RegisterLoadingScenes")]
	[CalledBy(Type = typeof(SceneManager), Member = "RegisterLoadingScenes")]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[CalledBy(Type = typeof(FPSLogger), Member = "OnFPSChanged")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "HasFinishedLoading")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "MaybeAssignAmbientProbeAnchor")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	private static SceneManager GetInstance()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadScene")]
	[CallerCount(Count = 0)]
	public static void LoadEmptyScene()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[CalledBy(Type = typeof(LoadLevelOnClick), Member = "OnClick")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "LoadScene")]
	[CalledBy(Type = typeof(NodeCanvas.Tasks.Actions.LoadScene), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	public static void LoadScene(string sceneName, LoadSceneMode mode = LoadSceneMode.Single)
	{
	}

	[CalledBy(Type = typeof(SceneManager), Member = "LoadScene")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[CalledBy(Type = typeof(BootUpdate), Member = "LoadMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "AsyncDirectLoadMainMenu")]
	[Calls(Type = typeof(Addressables), Member = "LoadSceneAsync")]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(string sceneName, LoadSceneMode mode = LoadSceneMode.Single)
	{
		return default(AsyncOperationHandle<SceneInstance>);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 19)]
	public static void RegisterLoadingScenes(ICollection<AsyncOperationHandle<SceneInstance>> scenes)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(Action_WaitForSceneLoad), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(InteractiveClothManager), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	public static bool IsLoading()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene_addlayer")]
	[CalledBy(Type = typeof(Action_AddMissionLayer), Member = "OnExecute")]
	public static void AddLayer(string name)
	{
	}

	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool ContainsLayer(string name)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene_removelayer")]
	[CalledBy(Type = typeof(Action_RemoveMissionLayer), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveLayer(string name)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 1)]
	public static void Deserialize(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetLayers()
	{
	}

	[Calls(Type = typeof(InaccessibleGearContainer), Member = "Initialize")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GearManager), Member = "UpdateAll")]
	[Calls(Type = typeof(NPC), Member = "FindAll")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "CompareSceneNames")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "MatchesMainMenuSceneName")]
	private void OnSceneLoaded(AsyncOperationHandle<SceneInstance> handle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[CallsUnknownMethods(Count = 1)]
	private static string SanitizeLayerName(string name)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public SceneManager()
	{
	}
}
