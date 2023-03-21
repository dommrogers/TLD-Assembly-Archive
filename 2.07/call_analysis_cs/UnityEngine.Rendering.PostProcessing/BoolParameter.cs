using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class BoolParameter : ParameterOverride<bool>
{
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	public BoolParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
