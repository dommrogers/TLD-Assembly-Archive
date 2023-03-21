using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class IntParameter : ParameterOverride<int>
{
	[CallerCount(Count = 0)]
	public override void Interp(int from, int to, float t)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool Equals(int a, int b)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public IntParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
