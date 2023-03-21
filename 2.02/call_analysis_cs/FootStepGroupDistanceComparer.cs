using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FootStepGroupDistanceComparer : IComparer<FootstepGroup>
{
	public Vector3 m_Point;

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public int Compare(FootstepGroup x, FootstepGroup y)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public FootStepGroupDistanceComparer()
	{
	}
}
