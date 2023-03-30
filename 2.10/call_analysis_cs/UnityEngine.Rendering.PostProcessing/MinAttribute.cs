using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class MinAttribute : Attribute
{
	public readonly float min;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MinAttribute(float min)
	{
	}
}
