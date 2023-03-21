using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class TonemapperParameter : ParameterOverride<Tonemapper>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public TonemapperParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
