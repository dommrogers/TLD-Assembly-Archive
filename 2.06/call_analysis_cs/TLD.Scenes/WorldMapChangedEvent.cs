using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Events;
using TLD.Gameplay;
using TLD.OptionalContent;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 60)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		private set
		{
		}
	}

	public bool IsCoreRegionMapSelected
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return false;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 20)]
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

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSwitchMapsSelected")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnWorldMapClicked")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "GetNextAvailableWorldMap")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameEvent), Member = "Post")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetCurrentMap(WorldMapSpecification worldMap)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSwitchMapsSelected")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public WorldMapSpecification GetNextAvailableWorldMap()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ShouldBePartOfFlow")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "HandleProfileLoaded")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAllMaps")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "add_OnOptionalContentLoaded")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetsAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "DoesMapHaveUnlockedRegions")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "HasValidStartingRegionsForGameMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public void UpdateAvailableWorldMaps()
	{
	}

	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "<UpdateAvailableWorldMaps>b__16_0")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAllMaps()
	{
	}

	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RegionSpecification), Member = "IsUnlocked")]
	[CallsUnknownMethods(Count = 11)]
	private static bool DoesMapHaveUnlockedRegions(WorldMapSpecification map, IEnumerable<RegionSpecification> regions)
	{
		return false;
	}

	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SandboxBaseConfig), Member = "IsValidStartingRegion")]
	[CallsUnknownMethods(Count = 12)]
	private static bool HasValidStartingRegionsForGameMode(WorldMapSpecification map, IEnumerable<RegionSpecification> regions)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameEvent), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public WorldMapChangedEvent()
	{
	}
}
