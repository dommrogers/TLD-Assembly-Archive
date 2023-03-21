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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GunItem), Member = "RollForMisfire")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 1)]
	public bool DoesMisfire(float condition)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public MisfireTable()
	{
	}
}
