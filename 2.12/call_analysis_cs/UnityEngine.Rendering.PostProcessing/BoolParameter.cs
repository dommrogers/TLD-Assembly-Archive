using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class BoolParameter : ParameterOverride<bool>
{
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BoolParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
