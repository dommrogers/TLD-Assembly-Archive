using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.SceneManagement;

public class RegionManager
{
	public static readonly int NumRegions;

	[CalledBy(Type = typeof(AchievementManager), Member = "Awake")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Serialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetSceneFilename(GameRegion region)
	{
		return null;
	}

	[CalledBy(Type = typeof(LoadScene), Member = "LoadLevelWhenFadeOutComplete")]
	[CalledBy(Type = typeof(LoadingZone), Member = "LoadLevelWhenFadeOutComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindStartRegion")]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindStartRegionFromFileData")]
	[CalledBy(Type = typeof(RegionManager), Member = "SceneIsRegion")]
	[CalledBy(Type = typeof(RegionManager), Member = "GetCurrentRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool GetRegionFromString(string regionString, out GameRegion region)
	{
		region = default(GameRegion);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static List<GameRegion> GetActualRegionList()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool SceneIsRegion(string sceneName)
	{
		return false;
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "InitializeForScene")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public static GameRegion GetCurrentRegion(bool considerForceNextSceneLoadTrigger = false)
	{
		return default(GameRegion);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public RegionManager()
	{
	}
}
