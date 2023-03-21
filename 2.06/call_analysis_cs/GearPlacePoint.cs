using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class GearPlacePoint : MonoBehaviour
{
	public enum CookingSurfaceType
	{
		Stove,
		Forge,
		Stone
	}

	public delegate void OnItemPlaced(GearItem gearItem);

	public GearItem m_DeprecatedGearPrefab;

	public List<GearItem> m_AuthorizedGearPrefabs;

	public bool m_AllowAllCookingItems;

	public Fire m_FireToAttach;

	public CookingSurfaceType m_CookingSlotType;

	public Vector3 m_ColliderSize;

	public bool m_AddToHierarchy;

	private PanelReference<Panel_BodyHarvest> m_BodyHarvest;

	[NonSerialized]
	public OnItemPlaced m_OnItemPlaced;

	private float MIN_DIST_GEAR_PLACEMENT;

	private GearItem m_PlacedGear;

	private GameObject m_ColliderObject;

	private int m_UpdateRefreshCounter;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearPlacePoint), Member = "AddDefaultCapsuleCollider")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[Calls(Type = typeof(GearPlacePoint), Member = "CheckGearStillPlaced")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public GearItem GetPlacedGear()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RefreshPlacedGear()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Start")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ItemPlaced(GearItem previousPlacedItem, GearItem newPlacedItem)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	public void DropAndPlaceItem(GearItem newPlacedItem)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 5)]
	public void PlaceGear(GearItem gi, bool reposition)
	{
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 6)]
	public bool IsAuthorizedPrefab(GameObject testedObject)
	{
		return false;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static GearPlacePoint FindFirstEmptyPlacePoint(GameObject parent)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public static GearPlacePoint FindTargetPlacePoint(GameObject parent, string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckGearStillPlaced")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ResetPlacedGear()
	{
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "IsCurrent")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ResetPlacedGear")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void CheckGearStillPlaced()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Start")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckForPlacedGearAfterLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearPlacePoint), Member = "IsAuthorizedPrefab")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 7)]
	private GearItem FindGearAtPlacePoint()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[Calls(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeInstantiateDummyCookingPot()
	{
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "PlaceGear")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ResetPlacedGear")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckForPlacedGearAfterLoad")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(CookingPotItem), Member = "DetachFromFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachToFire")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateAttachedFire(GearItem placedGearOld, GearItem placedGearNew)
	{
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 18)]
	private void AddDefaultCapsuleCollider()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[CallsUnknownMethods(Count = 1)]
	private void CheckForPlacedGearAfterLoad()
	{
	}

	[CallerCount(Count = 0)]
	public GearPlacePoint()
	{
	}
}
