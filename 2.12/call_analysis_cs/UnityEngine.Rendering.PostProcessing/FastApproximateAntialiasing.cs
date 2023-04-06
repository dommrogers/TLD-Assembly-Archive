using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class FastApproximateAntialiasing
{
	public bool fastMode;

	public bool keepAlpha;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public FastApproximateAntialiasing()
	{
	}
}
