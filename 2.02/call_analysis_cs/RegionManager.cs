using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.SceneManagement;

public class RegionManager
{
	public static readonly int NumRegions;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Serialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AchievementManager), Member = "Awake")]
	public static string GetSceneFilename(GameRegion region)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[CalledBy(Type = typeof(RegionManager), Member = "GetCurrentRegion")]
	[CalledBy(Type = typeof(RegionManager), Member = "GetCurrentRegion")]
	[CalledBy(Type = typeof(RegionManager), Member = "GetCurrentRegion")]
	[CalledBy(Type = typeof(RegionManager), Member = "GetCurrentRegion")]
	[CalledBy(Type = typeof(RegionManager), Member = "SceneIsRegion")]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindStartRegionFromFileData")]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindStartRegion")]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindStartRegionFromFileData")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(LoadingZone), Member = "LoadLevelWhenFadeOutComplete")]
	[CalledBy(Type = typeof(LoadScene), Member = "LoadLevelWhenFadeOutComplete")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindStartRegion")]
	[CallerCount(Count = 13)]
	public static bool GetRegionFromString(string regionString, out GameRegion region)
	{
		System.Runtime.CompilerServices.Unsafe.As<GameRegion, @null>(ref region) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[CallsUnknownMethods(Count = 9)]
	public static List<GameRegion> GetActualRegionList()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	public static bool SceneIsRegion(string sceneName)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "InitializeForScene")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	public static GameRegion GetCurrentRegion(bool considerForceNextSceneLoadTrigger = false)
	{
		return default(GameRegion);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public RegionManager()
	{
	}
}
