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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	public bool IsValidStartingRegion(RegionSpecification region)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	public RegionSpecification ValidateStartingRegion(RegionSpecification requestedRegion)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SandboxBaseConfig), Member = "GetRandomRegionFromAllAvailable")]
	[CallsUnknownMethods(Count = 3)]
	public RegionSpecification GetRandomStartingRegion()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool CanSpawnIndoors()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	public SceneSet GetSpawnSceneSet(RegionSpecification region)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private bool ShouldSpawnIndoors(RegionSpecification region)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(RegionSpecification), Member = "IsUnlocked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(SandboxBaseConfig), Member = "GetRandomStartingRegion")]
	[CallsUnknownMethods(Count = 25)]
	private static RegionSpecification GetRandomRegionFromAllAvailable()
	{
		return null;
	}

	[CalledBy(Type = typeof(ChallengeConfig), Member = ".ctor")]
	[CalledBy(Type = typeof(SandboxConfig), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected SandboxBaseConfig()
	{
	}
}
