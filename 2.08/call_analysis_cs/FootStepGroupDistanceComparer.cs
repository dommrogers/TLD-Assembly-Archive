using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FootStepGroupDistanceComparer : IComparer<FootstepGroup>
{
	public Vector3 m_Point;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public int Compare(FootstepGroup x, FootstepGroup y)
	{
		return default(int);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public FootStepGroupDistanceComparer()
	{
	}
}
