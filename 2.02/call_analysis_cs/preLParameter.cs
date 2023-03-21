using System;
using Cpp2ILInjected.CallAnalysis;
using LimitlessDev.RetroLookPro;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class preLParameter : ParameterOverride<effectPresets>
{
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public preLParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
