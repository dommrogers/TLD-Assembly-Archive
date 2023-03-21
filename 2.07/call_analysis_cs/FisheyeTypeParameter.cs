using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class FisheyeTypeParameter : ParameterOverride<FisheyeTypeEnum>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public FisheyeTypeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
