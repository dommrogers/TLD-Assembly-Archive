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
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	public bool DoesMisfire(float condition)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public MisfireTable()
	{
	}
}
