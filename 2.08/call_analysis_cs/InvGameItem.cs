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
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	public InvBaseItem baseItem
	{
		[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
		[CalledBy(Type = typeof(InvGameItem), Member = "CalculateStats")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "Update")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Equip")]
		[CalledBy(Type = typeof(InvEquipment), Member = "HasEquipped")]
		[CalledBy(Type = typeof(InvGameItem), Member = "get_name")]
		[CalledBy(Type = typeof(InvGameItem), Member = "get_name")]
		[CalledBy(Type = typeof(InvGameItem), Member = "CalculateStats")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Unequip")]
		[Calls(Type = typeof(InvDatabase), Member = "FindByID")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
		[CallerCount(Count = 13)]
		get
		{
			return null;
		}
	}

	public string name
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "Update")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
		[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
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

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
	public InvGameItem(int id, InvBaseItem bi)
	{
	}

	[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	public List<InvStat> CalculateStats()
	{
		return null;
	}
}
