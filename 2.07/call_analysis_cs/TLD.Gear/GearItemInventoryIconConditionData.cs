using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class GearItemInventoryIconConditionData : GearItemInventoryIconData
{
	[Serializable]
	public struct Entry
	{
		public string m_Suffix;

		public Texture2D m_Icon;
	}

	private ConditionTableType m_ConditionType;

	private Texture2D m_Default;

	private Entry[] m_Entries;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override Texture2D GetInventoryIcon(GearItem item)
	{
		return null;
	}

	[Calls(Type = typeof(GearItemInventoryIconConditionData), Member = "GetSuffix")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetConditionTable")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	public override Texture2D GetInventoryIcon(float conditionPercent)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(GearItemInventoryIconConditionData), Member = "GetInventoryIcon")]
	[CallsUnknownMethods(Count = 4)]
	private static string GetSuffix(ConditionTable.TableEntry conditionTable, float conditionPercent)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public GearItemInventoryIconConditionData()
	{
	}
}
