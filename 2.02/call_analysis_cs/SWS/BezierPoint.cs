using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace SWS;

[Serializable]
public class BezierPoint
{
	public Transform wp;

	public Transform[] cp;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BezierPoint()
	{
	}
}
