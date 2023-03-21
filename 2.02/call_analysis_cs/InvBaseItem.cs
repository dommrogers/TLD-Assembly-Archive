using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class InvBaseItem
{
	public enum Slot
	{
		None,
		Weapon,
		Shield,
		Body,
		Shoulders,
		Bracers,
		Boots,
		Trinket,
		_LastDoNotUse
	}

	public int id16;

	public string name;

	public string description;

	public Slot slot;

	public int minItemLevel;

	public int maxItemLevel;

	public List<InvStat> stats;

	public GameObject attachment;

	public Color color;

	public UIAtlas iconAtlas;

	public string iconName;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public InvBaseItem()
	{
	}
}
