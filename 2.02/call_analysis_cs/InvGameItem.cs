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
			return default(int);
		}
	}

	public InvBaseItem baseItem
	{
		[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
		[CalledBy(Type = typeof(InvGameItem), Member = "CalculateStats")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "Update")]
		[CalledBy(Type = typeof(InvGameItem), Member = "CalculateStats")]
		[CalledBy(Type = typeof(InvGameItem), Member = "get_name")]
		[CalledBy(Type = typeof(InvGameItem), Member = "get_name")]
		[CalledBy(Type = typeof(InvEquipment), Member = "HasEquipped")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Unequip")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Equip")]
		[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(InvDatabase), Member = "FindByID")]
		[CallerCount(Count = 13)]
		[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
		get
		{
			return null;
		}
	}

	public string name
	{
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "Update")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
		get
		{
			return null;
		}
	}

	public float statMultiplier
	{
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public Color color
	{
		[CallAnalysisFailed]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "Update")]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
	public List<InvStat> CalculateStats()
	{
		return null;
	}
}
