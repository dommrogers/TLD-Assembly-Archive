using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD;
using UnityEngine;

public class MapDetail : MonoBehaviour
{
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

	public bool m_IsUnlocked;

	public string m_CustomName;

	public bool m_IsDiscovered;

	public bool m_IsSurveyed;

	private bool m_DidRegister;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetail), Member = "Register")]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateCustomName(string newName)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(MapDetail), Member = "Awake")]
	[CallerCount(Count = 2)]
	public void Register()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Harvestable), Member = "add_Harvested")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void SetupMapVisibility()
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Surveyed()
	{
	}

	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Unlock(bool ignoreLogged = false)
	{
	}

	[CalledBy(Type = typeof(MapDetail), Member = "OnEnable")]
	[CalledBy(Type = typeof(MapDetail), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateMapVisibility()
	{
	}

	[CalledBy(Type = typeof(MapDetail), Member = "Lock")]
	[CalledBy(Type = typeof(MapDetail), Member = "Unlock")]
	[CalledBy(Type = typeof(MapDetail), Member = "UpdateMapVisibility")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CalledBy(Type = typeof(RockCache), Member = "Destroy")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "LockAll")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "RemoveMapDetailFromMap")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "EnableWorldMapDetail")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void ShowOnMap(bool isShownOnMap)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public MapDetail()
	{
	}
}
