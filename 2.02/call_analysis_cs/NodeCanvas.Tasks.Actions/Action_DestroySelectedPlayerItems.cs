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
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public bool IsClothingLayerToDestroy(ClothingLayer cl)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private ClothingRegionInfo GetClothingRegionDestroyInfo(ClothingRegion region)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(Action_DestroySelectedPlayerItems), Member = "GetClothingRegionDestroyInfo")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(ClothingRegionInfo), Member = "IsClothingLayerToDestroy")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Utils), Member = "GetGearItemsStoredInSceneByPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Container), Member = "DestroyGear")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 35)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_DestroySelectedPlayerItems()
	{
	}
}
