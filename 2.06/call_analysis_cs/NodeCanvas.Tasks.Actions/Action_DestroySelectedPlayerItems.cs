using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Gear;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_DestroySelectedPlayerItems : ActionTask
{
	public enum VisibleClothingRegion
	{
		Face,
		Neck,
		Head,
		Hands,
		Chest,
		Legs,
		Feet,
		Accessory
	}

	public enum VisibleClothingLayer
	{
		Base,
		Mid,
		Top,
		Top2
	}

	[Serializable]
	public class ClothingRegionInfo
	{
		public VisibleClothingRegion region;

		public List<VisibleClothingLayer> destroyLayerList;

		[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
		public bool IsClothingLayerToDestroy(ClothingLayer cl)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ClothingRegionInfo()
		{
		}
	}

	public bool destroyInventoryItems;

	public bool destroyNarrativeCollectibleItems;

	public bool destroyDroppedItemsInRange;

	public bool includeDroppedInContainer;

	public float dropRangeFromPlayer;

	public List<ClothingRegionInfo> wornClothingRegionDestroyList;

	private GearType m_GearType;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	private ClothingRegionInfo GetClothingRegionDestroyInfo(ClothingRegion region)
	{
		return null;
	}

	[Calls(Type = typeof(GearItem), Member = "IsAnyGearType")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Container), Member = "DestroyGear")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "IsAnyGearType")]
	[Calls(Type = typeof(Utils), Member = "GetGearItemsStoredInSceneByPlayer")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ClothingRegionInfo), Member = "IsClothingLayerToDestroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Action_DestroySelectedPlayerItems), Member = "GetClothingRegionDestroyInfo")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_DestroySelectedPlayerItems()
	{
	}
}
