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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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
	[CalledBy(Type = typeof(GearItemData), Member = "GetDisplayNameWithCondition")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public string GetDisplayNameWithCondition(string locID, ConditionTableType type, float normalizedCondition)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public string GetIconSuffixWithCondition(ConditionTableType type, float normalizedCondition)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ConditionTable()
	{
	}
}
