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

	[CalledBy(Type = typeof(NodeCanvas.Tasks.Actions.LoadScene), Member = "OnExecute")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "LoadScene")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CalledBy(Type = typeof(LoadLevelOnClick), Member = "OnClick")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SceneManager), Member = "Initialize")]
	public static void LoadScene(string sceneName, LoadSceneMode mode = LoadSceneMode.Single)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SceneManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadScene")]
	public static void LoadScene(int sceneBuildIndex, LoadSceneMode mode = LoadSceneMode.Single)
	{
	}

	[CalledBy(Type = typeof(BootUpdate), Member = "LoadMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[CalledBy(Type = typeof(GameManager), Member = "MaybeLateLoadMissionLayers")]
	[CalledBy(Type = typeof(BootUpdate), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[Calls(Type = typeof(SceneManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadSceneAsync")]
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode = LoadSceneMode.Single)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SceneManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadSceneAsyncNameIndexInternal")]
	public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneMode mode = LoadSceneMode.Single)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ProcessRegistrationQueue")]
	[CalledBy(Type = typeof(Action_WaitForSceneLoad), Member = "OnExecute")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(FPSLogger), Member = "OnFPSChanged")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CalledBy(Type = typeof(InteractiveClothManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "HasFinishedLoading")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "MaybeAssignAmbientProbeAnchor")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	public static bool IsLoading()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_AddMissionLayer), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene_addlayer")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	public static void AddLayer(string name)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[CalledBy(Type = typeof(GameManager), Member = "MaybeLateLoadMissionLayers")]
	[CalledBy(Type = typeof(GameManager), Member = "ShouldLoadConditionalScene")]
	[CallsUnknownMethods(Count = 1)]
	public static bool ContainsLayer(string name)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_RemoveMissionLayer), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene_removelayer")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	public static void RemoveLayer(string name)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void Deserialize(string serialized)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 8)]
	public static string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void ResetLayers()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadScene")]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadScene")]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[CalledBy(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[CallsUnknownMethods(Count = 7)]
	private static void Initialize()
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
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
