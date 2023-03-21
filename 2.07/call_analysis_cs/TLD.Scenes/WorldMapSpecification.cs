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
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
	}

	public LocalizedString MapDescription
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	public bool IsAvailable()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "GetActiveMap")]
	[CalledBy(Type = typeof(WorldMapSpecification), Member = "GetWorldMapBaseMap")]
	[CalledBy(Type = typeof(WorldMapSpecification), Member = "GetSelectRegionBaseMap")]
	[CalledBy(Type = typeof(WorldMapSpecification), Member = "GetSelectWorldBaseMap")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "GetWorldMap")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "SwapBackgroundWithoutFades")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnZoneSpecificationsLoaded")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnFadeOutFinished")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "GetWorldMap")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnFadeOutFinished")]
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
