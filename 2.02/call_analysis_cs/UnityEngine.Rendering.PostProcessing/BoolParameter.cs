using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class BoolParameter : ParameterOverride<bool>
{
	[CallerCount(Count = 32)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public BoolParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
