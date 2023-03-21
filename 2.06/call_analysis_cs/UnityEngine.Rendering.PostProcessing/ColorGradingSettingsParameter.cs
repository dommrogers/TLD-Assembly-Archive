using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class ColorGradingSettingsParameter : ParameterOverride<ColorGradingSettings>
{
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ColorGradingSettingsParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
