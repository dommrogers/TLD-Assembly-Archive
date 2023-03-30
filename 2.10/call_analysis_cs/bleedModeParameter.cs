using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class bleedModeParameter : ParameterOverride<BleedMode>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bleedModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
