using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
using TLD.Scenes;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

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

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "HasValidStartingRegionsForGameMode")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsValidStartingRegion(RegionSpecification region)
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RegionSpecification ValidateStartingRegion(RegionSpecification requestedRegion)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SandboxBaseConfig), Member = "GetRandomRegionFromAllAvailable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public RegionSpecification GetRandomStartingRegion()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool CanSpawnIndoors()
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public SceneSet GetSpawnSceneSet(RegionSpecification region)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldSpawnIndoors(RegionSpecification region)
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(SandboxBaseConfig), Member = "GetRandomStartingRegion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(RegionSpecification), Member = "IsUnlocked")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
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
