using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class TrackballAttribute : Attribute
{
	public enum Mode
	{
		None,
		Lift,
		Gamma,
		Gain
	}

	public readonly Mode mode;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TrackballAttribute(Mode mode)
	{
	}
}
