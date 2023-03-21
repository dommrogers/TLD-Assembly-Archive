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
		[CallerCount(Count = 14)]
		get
		{
			return default(int);
		}
	}

	public InvBaseItem baseItem
	{
		[CalledBy(Type = typeof(InvGameItem), Member = "get_name")]
		[CalledBy(Type = typeof(InvGameItem), Member = "get_name")]
		[CalledBy(Type = typeof(InvEquipment), Member = "HasEquipped")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Unequip")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Equip")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "Update")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
		[Calls(Type = typeof(InvDatabase), Member = "FindByID")]
		[CalledBy(Type = typeof(InvGameItem), Member = "CalculateStats")]
		[CallerCount(Count = 13)]
		[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
		[CalledBy(Type = typeof(InvGameItem), Member = "CalculateStats")]
		get
		{
			return null;
		}
	}

	public string name
	{
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "Update")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
		get
		{
			return null;
		}
	}

	public float statMultiplier
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public Color color
	{
		[CallAnalysisFailed]
		[CalledBy(Type = typeof(UIItemSlot), Member = "Update")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
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

	[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CallerCount(Count = 2)]
	public InvGameItem(int id, InvBaseItem bi)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	public List<InvStat> CalculateStats()
	{
		return null;
	}
}
