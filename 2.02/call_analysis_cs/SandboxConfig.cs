using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SandboxConfig : ScriptableObject
{
	public int m_NumFeatsPilgrim;

	public int m_NumFeatsVoyageur;

	public int m_NumFeatsStalker;

	public int m_NumFeatsInterloper;

	public int m_NumGamesBeforeAllowIndoorStart;

	public float m_IndoorStartChancePilgrim;

	public float m_IndoorStartChanceVoyageur;

	public float m_IndoorStartChanceStalker;

	public float m_IndoorStartChanceInterloper;

	public string[] m_IndoorStartScenesLakeRegion;

	public string[] m_IndoorStartScenesCoastalRegion;

	public string[] m_IndoorStartScenesRuralRegion;

	public string[] m_IndoorStartScenesWhalingStationRegion;

	public string[] m_IndoorStartScenesCrashMountainRegion;

	public string[] m_IndoorStartScenesMarshRegion;

	public string[] m_IndoorStartScenesTracksRegion;

	public string[] m_IndoorStartScenesMountainTownRegion;

	public string[] m_IndoorStartScenesRiverValleyRegion;

	public string[] m_IndoorStartScenesCanneryRegion;

	public string[] m_IndoorStartScenesBlackrockRegion;

	public GameRegion[] m_AllowedRandomRegions;

	public GameRegion[] m_InterloperRegions;

	public GameRegion[] m_FourDaysOfNightRegions;

	public List<GameRegion> m_ExcludedRegionsForDarkWalker;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 3)]
	public bool CanSpawnIndoors(ExperienceModeType xpMode)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	public string GetIndoorSpawn(ExperienceModeType xpMode, GameRegion region)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private string[] GetIndoorScenes(GameRegion region)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public GameRegion ValidateStartingRegion(GameRegion region, ExperienceModeType xpMode)
	{
		return default(GameRegion);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsUnknownMethods(Count = 14)]
	public GameRegion GetRandomStartingRegion()
	{
		return default(GameRegion);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public SandboxConfig()
	{
	}
}
