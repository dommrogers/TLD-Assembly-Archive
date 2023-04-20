using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class MinMaxAttribute : Attribute
{
	public readonly float min;

	public readonly float max;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MinMaxAttribute(float min, float max)
	{
	}
}
