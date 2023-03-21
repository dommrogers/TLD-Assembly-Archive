using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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

	[NonSerialized]
	public OnItemPlaced m_OnItemPlaced;

	private float MIN_DIST_GEAR_PLACEMENT;

	private GearItem m_PlacedGear;

	private GameObject m_ColliderObject;

	private int m_UpdateRefreshCounter;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearPlacePoint), Member = "AddDefaultCapsuleCollider")]
	private void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GearPlacePoint), Member = "CheckGearStillPlaced")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 20)]
	public GearItem GetPlacedGear()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RefreshPlacedGear()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Start")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	public void ItemPlaced(GearItem previousPlacedItem, GearItem newPlacedItem)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	public void DropAndPlaceItem(GearItem newPlacedItem)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void PlaceGear(GearItem gi, bool reposition)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public bool IsAuthorizedPrefab(GameObject testedObject)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[CallsUnknownMethods(Count = 5)]
	public static GearPlacePoint FindFirstEmptyPlacePoint(GameObject parent)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static GearPlacePoint FindTargetPlacePoint(GameObject parent, string name)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckGearStillPlaced")]
	[CallsUnknownMethods(Count = 1)]
	private void ResetPlacedGear()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ResetPlacedGear")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "IsCurrent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void CheckGearStillPlaced()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckForPlacedGearAfterLoad")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Start")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GearPlacePoint), Member = "IsAuthorizedPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private GearItem FindGearAtPlacePoint()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void MaybeInstantiateDummyCookingPot()
	{
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "PlaceGear")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckForPlacedGearAfterLoad")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachToFire")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ResetPlacedGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "DetachFromFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void UpdateAttachedFire(GearItem placedGearOld, GearItem placedGearNew)
	{
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "Start")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 26)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallerCount(Count = 1)]
	private void AddDefaultCapsuleCollider()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[CallsUnknownMethods(Count = 2)]
	private void CheckForPlacedGearAfterLoad()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public GearPlacePoint()
	{
	}
}
