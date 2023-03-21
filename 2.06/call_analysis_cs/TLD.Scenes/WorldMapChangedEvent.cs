using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Events;
using TLD.Gameplay;
using TLD.OptionalContent;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Scenes;

public class WorldMapChangedEvent : GameEvent
{
	private AssetLabelReference m_WorldMapLabel;

	private WorldMapSpecification m_CoreRegionWorldMap;

	private WorldMapSpecification _003CCurrentMap_003Ek__BackingField;

	private readonly List<WorldMapSpecification> m_AllMaps;

	private readonly List<WorldMapSpecification> m_AvailableMaps;

	private bool m_InitializedAllMaps;

	public WorldMapSpecification CurrentMap
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 56)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 21)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsCoreRegionMapSelected
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public IList<WorldMapSpecification> GetAllWorldMaps()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public IList<WorldMapSpecification> GetAvailableWorldMaps()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "GetNextAvailableWorldMap")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnWorldMapClicked")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[Calls(Type = typeof(GameEvent), Member = "Post")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSwitchMapsSelected")]
	public void SetCurrentMap(WorldMapSpecification worldMap)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSwitchMapsSelected")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public WorldMapSpecification GetNextAvailableWorldMap()
	{
		return null;
	}

	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ShouldBePartOfFlow")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "HasValidStartingRegionsForGameMode")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "DoesMapHaveUnlockedRegions")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(OptionalContentManager), Member = "add_OnOptionalContentLoaded")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAllMaps")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "HandleProfileLoaded")]
	[CallsUnknownMethods(Count = 17)]
	public void UpdateAvailableWorldMaps()
	{
	}

	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "<UpdateAvailableWorldMaps>b__16_0")]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	private void UpdateAllMaps()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RegionSpecification), Member = "IsUnlocked")]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CallsUnknownMethods(Count = 11)]
	private static bool DoesMapHaveUnlockedRegions(WorldMapSpecification map, IEnumerable<RegionSpecification> regions)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(SandboxBaseConfig), Member = "IsValidStartingRegion")]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private static bool HasValidStartingRegionsForGameMode(WorldMapSpecification map, IEnumerable<RegionSpecification> regions)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameEvent), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	public WorldMapChangedEvent()
	{
	}
}
