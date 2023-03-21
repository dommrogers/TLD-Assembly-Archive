using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class ConditionTable : ScriptableObject
{
	[Serializable]
	public class TableEntry
	{
		[Serializable]
		public class GearNameSuffixForConditionRange
		{
			public string m_Suffix;

			public float m_MinConditionForName;

			[DeduplicatedMethod]
			[CallerCount(Count = 6)]
			public GearNameSuffixForConditionRange()
			{
			}
		}

		public List<GearNameSuffixForConditionRange> m_NameForConditionRangeList;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public TableEntry()
		{
		}
	}

	private TableEntry[] m_Entries;

	private Dictionary<string, string[]> m_LocIdCache;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public TableEntry GetTableEntry(ConditionTableType type)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "get_DisplayNameWithCondition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GearItemData), Member = "GetDisplayNameWithCondition")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	public string GetDisplayNameWithCondition(string locID, ConditionTableType type, float normalizedCondition)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetIconSuffixWithCondition(ConditionTableType type, float normalizedCondition)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public ConditionTable()
	{
	}
}
