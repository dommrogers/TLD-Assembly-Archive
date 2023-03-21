using System;
using System.Collections.Generic;
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override Texture2D GetInventoryIcon(GearItem item)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetConditionTable")]
	[Calls(Type = typeof(GearItemInventoryIconConditionData), Member = "GetSuffix")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CallsUnknownMethods(Count = 2)]
	public override Texture2D GetInventoryIcon(float conditionPercent)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItemInventoryIconConditionData), Member = "GetInventoryIcon")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
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
