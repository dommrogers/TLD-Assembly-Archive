using System;
using Cpp2ILInjected.CallAnalysis;
using LimitlessDev.RetroLookPro;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class preLParameter : ParameterOverride<effectPresets>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public preLParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
