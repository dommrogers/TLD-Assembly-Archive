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
		[CallerCount(Count = 53)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 21)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public bool IsCoreRegionMapSelected
	{
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateButtonLegend")]
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

	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnWorldMapClicked")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSwitchMapsSelected")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "GetNextAvailableWorldMap")]
	[Calls(Type = typeof(GameEvent), Member = "Post")]
	[CallsUnknownMethods(Count = 1)]
	public void SetCurrentMap(WorldMapSpecification worldMap)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSwitchMapsSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	public WorldMapSpecification GetNextAvailableWorldMap()
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "HandleProfileLoaded")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ShouldBePartOfFlow")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "HasValidStartingRegionsForGameMode")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "DoesMapHaveUnlockedRegions")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(OptionalContentManager), Member = "add_OnOptionalContentLoaded")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAllMaps")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	public void UpdateAvailableWorldMaps()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "<UpdateAvailableWorldMaps>b__16_0")]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SandboxBaseConfig), Member = "IsValidStartingRegion")]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CallsUnknownMethods(Count = 12)]
	private static bool HasValidStartingRegionsForGameMode(WorldMapSpecification map, IEnumerable<RegionSpecification> regions)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameEvent), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public WorldMapChangedEvent()
	{
	}
}
