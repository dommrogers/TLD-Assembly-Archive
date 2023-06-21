using Cpp2ILInjected.CallAnalysis;
using TLD.OptionalContent;
using UnityEngine;

namespace TLD.Scenes;

public class WorldMapSpecification : ScriptableObject
{
	private LocalizedString m_MapName;

	private LocalizedString m_MapDescription;

	private UIWorldMap m_SelectWorldBaseMap;

	private UIWorldMap m_SelectRegionBaseMap;

	private UIWorldMap m_WorldMapBaseMap;

	private OptionalContentConfig m_RequiredOptionalContent;

	private UIWorldMap m_SelectWorldBaseMapInstance;

	private UIWorldMap m_SelectRegionBaseMapInstance;

	private UIWorldMap m_WorldMapBaseMapInstance;

	public LocalizedString MapName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	public LocalizedString MapDescription
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	public UIWorldMap GetSelectWorldBaseMap(Transform parent)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	public UIWorldMap GetSelectRegionBaseMap(Transform parent)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	public UIWorldMap GetWorldMapBaseMap(Transform parent)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAvailable()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "OnZoneSpecificationsLoaded")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "GetWorldMap")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnFadeOutFinished")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "GetActiveMap")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "SwapBackgroundWithoutFades")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "GetWorldMap")]
	[CalledBy(Type = typeof(WorldMapSpecification), Member = "GetSelectWorldBaseMap")]
	[CalledBy(Type = typeof(WorldMapSpecification), Member = "GetSelectRegionBaseMap")]
	[CalledBy(Type = typeof(WorldMapSpecification), Member = "GetWorldMapBaseMap")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	private UIWorldMap GetOrInstantiateBaseMap(UIWorldMap prefab, Transform parent, ref UIWorldMap instance)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public WorldMapSpecification()
	{
	}
}
