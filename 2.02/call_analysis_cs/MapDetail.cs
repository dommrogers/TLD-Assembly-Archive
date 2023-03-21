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

	[Calls(Type = typeof(MapDetail), Member = "Register")]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetail), Member = "UpdateMapVisibility")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(MapDetail), Member = "UpdateMapVisibility")]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateCustomName(string newName)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(MapDetail), Member = "Awake")]
	public void Register()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Harvestable), Member = "add_Harvested")]
	[CallsUnknownMethods(Count = 10)]
	private void SetupMapVisibility()
	{
	}

	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CallerCount(Count = 0)]
	public void Lock()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void DiscoverOnInteract()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Surveyed()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CallsUnknownMethods(Count = 4)]
	public void Unlock(bool ignoreLogged = false)
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(MapDetail), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MapDetail), Member = "OnEnable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	private void UpdateMapVisibility()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(MapDetailManager), Member = "LockAll")]
	[CalledBy(Type = typeof(RockCache), Member = "Destroy")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CalledBy(Type = typeof(MapDetail), Member = "UpdateMapVisibility")]
	[CalledBy(Type = typeof(MapDetail), Member = "Unlock")]
	[CalledBy(Type = typeof(MapDetail), Member = "Lock")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "RemoveMapDetailFromMap")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_WorldMap), Member = "EnableWorldMapDetail")]
	private void ShowOnMap(bool isShownOnMap)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MapDetail()
	{
	}
}
