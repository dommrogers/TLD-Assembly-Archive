using System;
using Cpp2ILInjected.CallAnalysis;
using LimitlessDev.RetroLookPro;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class preLParameter : ParameterOverride<effectPresets>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public preLParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
