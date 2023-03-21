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

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
		[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
		[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private ClothingRegionInfo GetClothingRegionDestroyInfo(ClothingRegion region)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Container), Member = "DestroyGear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "IsAnyGearType")]
	[Calls(Type = typeof(Utils), Member = "GetGearItemsStoredInSceneByPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingRegionInfo), Member = "IsClothingLayerToDestroy")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(Action_DestroySelectedPlayerItems), Member = "GetClothingRegionDestroyInfo")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GearItem), Member = "IsAnyGearType")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_DestroySelectedPlayerItems()
	{
	}
}
