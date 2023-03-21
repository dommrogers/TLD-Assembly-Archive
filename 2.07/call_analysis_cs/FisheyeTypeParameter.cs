using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class FisheyeTypeParameter : ParameterOverride<FisheyeTypeEnum>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FisheyeTypeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
