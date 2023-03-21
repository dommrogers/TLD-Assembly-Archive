using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_DestroySelectedPlayerItems : ActionTask
{
	public enum GearTypeBitFlags
	{
		Food = 1,
		Clothing = 2,
		Material = 4,
		Tool = 8,
		Other = 0x10,
		FirstAid = 0x20,
		Firestarting = 0x40
	}

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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		public bool IsClothingLayerToDestroy(ClothingLayer cl)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

	private GearTypeBitFlags m_GearTypeBitFlags;

	private string[] m_GearTypeOptions;

	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private ClothingRegionInfo GetClothingRegionDestroyInfo(ClothingRegion region)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Container), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingRegionInfo), Member = "IsClothingLayerToDestroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(Action_DestroySelectedPlayerItems), Member = "GetClothingRegionDestroyInfo")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetGearItemsStoredInSceneByPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_DestroySelectedPlayerItems()
	{
	}
}
