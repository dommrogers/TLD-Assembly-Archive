using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class MaxAttribute : Attribute
{
	public readonly float max;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MaxAttribute(float max)
	{
	}
}
