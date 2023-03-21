using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MisfireTable : ScriptableObject
{
	[Serializable]
	public struct Range
	{
		public float m_Minimum;

		public float m_Maximum;

		public float m_FailurePercentage;
	}

	public float m_AlwaysSucceedThreshold;

	public float m_AlwaysFailThreshold;

	public List<Range> m_Ranges;

	[CalledBy(Type = typeof(GunItem), Member = "RollForMisfire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public bool DoesMisfire(float condition)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public MisfireTable()
	{
	}
}
