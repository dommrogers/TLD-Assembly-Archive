using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes;
using UnityEngine;

namespace TLD.Gameplay;

public abstract class SandboxBaseConfig : GameModeConfig
{
	private const int NUM_GAMES_BEFORE_INDOOR_START = 1;

	private const string DEFAULT_POST_LOAD_COMMMAND = "mission_jump null false";

	public float m_IndoorStartChance;

	public RegionSpecification[] m_AvailableStartRegions;

	public string m_PostLoadCommand;

	public SceneSet m_ForceSceneLoad;

	public string m_ForceSpawnPoint;

	public bool m_SaveAfterLoad;

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "HasValidStartingRegionsForGameMode")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	public bool IsValidStartingRegion(RegionSpecification region)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsUnknownMethods(Count = 2)]
	public RegionSpecification ValidateStartingRegion(RegionSpecification requestedRegion)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SandboxBaseConfig), Member = "GetRandomRegionFromAllAvailable")]
	public RegionSpecification GetRandomStartingRegion()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool CanSpawnIndoors()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsUnknownMethods(Count = 4)]
	public SceneSet GetSpawnSceneSet(RegionSpecification region)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool ShouldSpawnIndoors(RegionSpecification region)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SandboxBaseConfig), Member = "GetRandomStartingRegion")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 19)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RegionSpecification), Member = "IsUnlocked")]
	private static RegionSpecification GetRandomRegionFromAllAvailable()
	{
		return null;
	}

	[CalledBy(Type = typeof(SandboxConfig), Member = ".ctor")]
	[CalledBy(Type = typeof(ChallengeConfig), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected SandboxBaseConfig()
	{
	}
}
