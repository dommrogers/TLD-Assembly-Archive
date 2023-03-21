using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FootStepGroupDistanceComparer : IComparer<FootstepGroup>
{
	public Vector3 m_Point;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public int Compare(FootstepGroup x, FootstepGroup y)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public FootStepGroupDistanceComparer()
	{
	}
}
