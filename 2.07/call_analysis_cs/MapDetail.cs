using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD;
using TLD.UI.Generics;
using UnityEngine;

public class MapDetail : MonoBehaviour
{
	private PanelReference<Panel_Map> m_Map;

	public MapIcon.MapIconType m_IconType;

	public string m_LocID;

	public string m_SpriteName;

	public bool m_RequiresInteraction;

	public List<Harvestable> m_HarvestablesSharingIcon;

	public bool m_RegisterOnAwake;

	public Harvestable[] m_HarvestablesForMapVisibility;

	public Vector3 m_RaycastTargetOffset;

	public bool m_ShowDirectionIcon;

	public float m_DirectionIconAngleDegrees;

	public bool m_IsRemovedWithDelay;

	public bool m_RevealTargetPosition;

	public Vector3 m_TargetPosition;

	public float m_SurveyRadius;

	public bool m_IsUnlocked;

	public string m_CustomName;

	public bool m_IsDiscovered;

	public bool m_IsSurveyed;

	public Vector3 m_WorldPosition;

	private bool m_DidRegister;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MapDetail), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetail), Member = "UpdateMapVisibility")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(MapDetail), Member = "UpdateMapVisibility")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateCustomName(string newName)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MapDetail), Member = "Awake")]
	[Calls(Type = typeof(Harvestable), Member = "add_Harvested")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void Register()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	public void Lock()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void DiscoverOnInteract()
	{
	}

	[CallerCount(Count = 0)]
	public void Surveyed()
	{
	}

	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(MapDetail), Member = "AddNoteMapMarker")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "PerformHold")]
	[CallsUnknownMethods(Count = 3)]
	public void Unlock(bool ignoreLogged = false)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	public void AddNoteMapMarker()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Harvestable), Member = "add_Harvested")]
	[CallsUnknownMethods(Count = 2)]
	private void SetupMapVisibility()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MapDetail), Member = "OnDisable")]
	[CalledBy(Type = typeof(MapDetail), Member = "OnEnable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	private void UpdateMapVisibility()
	{
	}

	[CalledBy(Type = typeof(RockCache), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MapDetail), Member = "Lock")]
	[CalledBy(Type = typeof(MapDetail), Member = "UpdateMapVisibility")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	private void ShowOnMap(bool isShownOnMap)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetWorldPosition()
	{
	}

	[CallerCount(Count = 0)]
	public MapDetail()
	{
	}
}
