using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Events;
using TLD.Gameplay;
using TLD.OptionalContent;
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
		[CallerCount(Count = 53)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 21)]
		private set
		{
		}
	}

	public bool IsCoreRegionMapSelected
	{
		[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateButtonLegend")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 16)]
	public IList<WorldMapSpecification> GetAllWorldMaps()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public IList<WorldMapSpecification> GetAvailableWorldMaps()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameEvent), Member = "Post")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSwitchMapsSelected")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnWorldMapClicked")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "GetNextAvailableWorldMap")]
	[CallsUnknownMethods(Count = 1)]
	public void SetCurrentMap(WorldMapSpecification worldMap)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSwitchMapsSelected")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	public WorldMapSpecification GetNextAvailableWorldMap()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "HandleProfileLoaded")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ShouldBePartOfFlow")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "HasValidStartingRegionsForGameMode")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "DoesMapHaveUnlockedRegions")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(OptionalContentManager), Member = "add_OnOptionalContentLoaded")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAllMaps")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	public void UpdateAvailableWorldMaps()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "<UpdateAvailableWorldMaps>b__16_0")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	private void UpdateAllMaps()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegionSpecification), Member = "IsUnlocked")]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CallsUnknownMethods(Count = 12)]
	private static bool DoesMapHaveUnlockedRegions(WorldMapSpecification map, IEnumerable<RegionSpecification> regions)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SandboxBaseConfig), Member = "IsValidStartingRegion")]
	[CallsUnknownMethods(Count = 12)]
	private static bool HasValidStartingRegionsForGameMode(WorldMapSpecification map, IEnumerable<RegionSpecification> regions)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameEvent), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public WorldMapChangedEvent()
	{
	}
}
