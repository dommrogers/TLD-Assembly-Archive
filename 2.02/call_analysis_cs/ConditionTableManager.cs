using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ConditionTableManager : MonoBehaviour
{
	public enum ConditionTableType
	{
		Unknown = -1,
		Meat,
		DryFood,
		CannedFood,
		Clothing,
		Ammunition
	}

	[Serializable]
	public class ConditionTable
	{
		[Serializable]
		public class GearNameSuffixForConditionRange
		{
			public string m_Suffix;

			public float m_MinConditionForName;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public GearNameSuffixForConditionRange()
			{
			}
		}

		public List<GearNameSuffixForConditionRange> m_NameForConditionRangeList;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ConditionTable()
		{
		}
	}

	public ConditionTable m_MeatConditionTable;

	public ConditionTable m_DryFoodConditionTable;

	public ConditionTable m_CannedFoodConditionTable;

	public ConditionTable m_ClothingConditionTable;

	public ConditionTable m_AmmunitionConditionTable;

	public ConditionTable[] m_ConditionTables;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public string GetDisplayNameWithCondition(GearItem gearItem)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ConditionTableManager()
	{
	}
}
