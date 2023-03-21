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
	[Calls(Type = typeof(GearPlacePoint), Member = "AddDefaultCapsuleCollider")]
	private void Start()
	{
	}

	[Calls(Type = typeof(GearPlacePoint), Member = "CheckGearStillPlaced")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearPlacePoint), Member = "CheckForPlacedGearAfterLoad")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public GearItem GetPlacedGear()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void RefreshPlacedGear()
	{
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	public void ItemPlaced(GearItem previousPlacedItem, GearItem newPlacedItem)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CallsUnknownMethods(Count = 9)]
	public void DropAndPlaceItem(GearItem newPlacedItem)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void PlaceGear(GearItem gi, bool reposition)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public bool IsAuthorizedPrefab(GameObject testedObject)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[CallsUnknownMethods(Count = 2)]
	public static GearPlacePoint FindFirstEmptyPlacePoint(GameObject parent)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ResetPlacedGear")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "IsCurrent")]
	private void CheckGearStillPlaced()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckForPlacedGearAfterLoad")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Start")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearPlacePoint), Member = "IsAuthorizedPrefab")]
	private GearItem FindGearAtPlacePoint()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	private void MaybeInstantiateDummyCookingPot()
	{
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "ResetPlacedGear")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckForPlacedGearAfterLoad")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "PlaceGear")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachToFire")]
	[Calls(Type = typeof(CookingPotItem), Member = "DetachFromFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	private void UpdateAttachedFire(GearItem placedGearOld, GearItem placedGearNew)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	private void AddDefaultCapsuleCollider()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void CheckForPlacedGearAfterLoad()
	{
	}

	[CallerCount(Count = 0)]
	public GearPlacePoint()
	{
	}
}
