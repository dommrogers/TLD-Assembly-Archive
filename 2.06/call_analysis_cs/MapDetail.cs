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
	[Calls(Type = typeof(MapDetail), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetail), Member = "UpdateMapVisibility")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateCustomName(string newName)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(MapDetail), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MapDetail), Member = "SetupMapVisibility")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(MapDetail), Member = "AddNoteMapMarker")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Unlock(bool ignoreLogged = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[CallsUnknownMethods(Count = 1)]
	public void AddNoteMapMarker()
	{
	}

	[CalledBy(Type = typeof(MapDetail), Member = "Register")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Harvestable), Member = "add_Harvested")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void SetupMapVisibility()
	{
	}

	[CalledBy(Type = typeof(MapDetail), Member = "OnEnable")]
	[CalledBy(Type = typeof(MapDetail), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateMapVisibility()
	{
	}

	[CalledBy(Type = typeof(MapDetail), Member = "Lock")]
	[CalledBy(Type = typeof(MapDetail), Member = "UpdateMapVisibility")]
	[CalledBy(Type = typeof(RockCache), Member = "Destroy")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CallsUnknownMethods(Count = 2)]
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
