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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool Equals(int a, int b)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(RLProVHSEffect), Member = ".ctor")]
	public IntParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
