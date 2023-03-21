using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class KernelSizeParameter : ParameterOverride<KernelSize>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public KernelSizeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
