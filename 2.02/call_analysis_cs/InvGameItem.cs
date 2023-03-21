using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class InvGameItem
{
	public enum Quality
	{
		Broken,
		Cursed,
		Damaged,
		Worn,
		Sturdy,
		Polished,
		Improved,
		Crafted,
		Superior,
		Enchanted,
		Epic,
		Legendary,
		_LastDoNotUse
	}

	private int mBaseItemID;

	public Quality quality;

	public int itemLevel;

	private InvBaseItem mBaseItem;

	public int baseItemID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return 0;
		}
	}

	public InvBaseItem baseItem
	{
		[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "Update")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Equip")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Unequip")]
		[CalledBy(Type = typeof(InvEquipment), Member = "HasEquipped")]
		[CalledBy(Type = typeof(InvGameItem), Member = "get_name")]
		[CalledBy(Type = typeof(InvGameItem), Member = "CalculateStats")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(InvDatabase), Member = "FindByID")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string name
	{
		[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "Update")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public float statMultiplier
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public Color color
	{
		[CallAnalysisFailed]
		[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "Update")]
		[CallerCount(Count = 2)]
		get
		{
			return default(Color);
		}
	}

	[CallerCount(Count = 0)]
	public InvGameItem(int id)
	{
	}

	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
	[CallerCount(Count = 2)]
	public InvGameItem(int id, InvBaseItem bi)
	{
	}

	[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 28)]
	public List<InvStat> CalculateStats()
	{
		return null;
	}
}
