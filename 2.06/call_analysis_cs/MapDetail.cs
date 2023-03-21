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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MapDetail), Member = "Register")]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetail), Member = "UpdateMapVisibility")]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetail), Member = "UpdateMapVisibility")]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	public void UpdateCustomName(string newName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MapDetail), Member = "SetupMapVisibility")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(MapDetail), Member = "Awake")]
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

	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(MapDetail), Member = "AddNoteMapMarker")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	public void Unlock(bool ignoreLogged = false)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	public void AddNoteMapMarker()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Harvestable), Member = "add_Harvested")]
	[CalledBy(Type = typeof(MapDetail), Member = "Register")]
	[CallsUnknownMethods(Count = 7)]
	private void SetupMapVisibility()
	{
	}

	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CalledBy(Type = typeof(MapDetail), Member = "OnDisable")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(MapDetail), Member = "OnEnable")]
	[CallerCount(Count = 2)]
	private void UpdateMapVisibility()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CalledBy(Type = typeof(MapDetail), Member = "Lock")]
	[CalledBy(Type = typeof(MapDetail), Member = "UpdateMapVisibility")]
	[CalledBy(Type = typeof(RockCache), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	private void ShowOnMap(bool isShownOnMap)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void SetWorldPosition()
	{
	}

	[CallerCount(Count = 0)]
	public MapDetail()
	{
	}
}
