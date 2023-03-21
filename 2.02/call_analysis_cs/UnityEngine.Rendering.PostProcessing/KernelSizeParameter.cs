using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class KernelSizeParameter : ParameterOverride<KernelSize>
{
	[CalledBy(Type = typeof(MaskedBlurEffect), Member = ".ctor")]
	[CalledBy(Type = typeof(DepthOfField), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public KernelSizeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
