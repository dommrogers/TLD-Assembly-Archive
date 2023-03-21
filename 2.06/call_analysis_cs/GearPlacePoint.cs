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

	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearPlacePoint), Member = "AddDefaultCapsuleCollider")]
	private void Start()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GearPlacePoint), Member = "CheckGearStillPlaced")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	public GearItem GetPlacedGear()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RefreshPlacedGear()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Start")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[Calls(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CallsUnknownMethods(Count = 1)]
	public void ItemPlaced(GearItem previousPlacedItem, GearItem newPlacedItem)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[CallerCount(Count = 2)]
	public void DropAndPlaceItem(GearItem newPlacedItem)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 5)]
	public void PlaceGear(GearItem gi, bool reposition)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public bool IsAuthorizedPrefab(GameObject testedObject)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "FindFireEmptyPlacePoint")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	public static GearPlacePoint FindFirstEmptyPlacePoint(GameObject parent)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
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

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ResetPlacedGear")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "IsCurrent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void CheckGearStillPlaced()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckForPlacedGearAfterLoad")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Start")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearPlacePoint), Member = "IsAuthorizedPrefab")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private GearItem FindGearAtPlacePoint()
	{
		return null;
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[Calls(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void MaybeInstantiateDummyCookingPot()
	{
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "PlaceGear")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckForPlacedGearAfterLoad")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachToFire")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ResetPlacedGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CookingPotItem), Member = "DetachFromFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	private void UpdateAttachedFire(GearItem placedGearOld, GearItem placedGearNew)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Start")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
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
