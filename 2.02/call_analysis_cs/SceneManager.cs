using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneManager
{
	public struct SceneManagerSaveData
	{
		public List<string> m_AdditiveLayers;
	}

	public static List<string> s_AdditiveLayers;

	private static bool s_IsInitialized;

	private static int s_LoadingCount;

	[CalledBy(Type = typeof(LoadLevelOnClick), Member = "OnClick")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "LoadScene")]
	[CalledBy(Type = typeof(NodeCanvas.Tasks.Actions.LoadScene), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SceneManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void LoadScene(string sceneName, LoadSceneMode mode = LoadSceneMode.Single)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void LoadScene(int sceneBuildIndex, LoadSceneMode mode = LoadSceneMode.Single)
	{
	}

	[CalledBy(Type = typeof(BootUpdate), Member = "Update")]
	[CalledBy(Type = typeof(BootUpdate), Member = "LoadMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "MaybeLateLoadMissionLayers")]
	[CalledBy(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SceneManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadSceneAsync")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode = LoadSceneMode.Single)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadSceneAsyncNameIndexInternal")]
	[CallsDeduplicatedMethods(Count = 3)]
	public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneMode mode = LoadSceneMode.Single)
	{
		return null;
	}

	[CalledBy(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "MaybeAssignAmbientProbeAnchor")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "HasFinishedLoading")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(InteractiveClothManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ProcessRegistrationQueue")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(FPSLogger), Member = "OnFPSChanged")]
	[CalledBy(Type = typeof(Action_WaitForSceneLoad), Member = "OnExecute")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsLoading()
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene_addlayer")]
	[CalledBy(Type = typeof(Action_AddMissionLayer), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void AddLayer(string name)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "MaybeLateLoadMissionLayers")]
	[CalledBy(Type = typeof(GameManager), Member = "ShouldLoadConditionalScene")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool ContainsLayer(string name)
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene_removelayer")]
	[CalledBy(Type = typeof(Action_RemoveMissionLayer), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void RemoveLayer(string name)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void Deserialize(string serialized)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetLayers()
	{
	}

	[CalledBy(Type = typeof(SceneManager), Member = "LoadScene")]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadScene")]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[CallsUnknownMethods(Count = 1)]
	private static string SanitizeLayerName(string name)
	{
		return null;
	}
}
