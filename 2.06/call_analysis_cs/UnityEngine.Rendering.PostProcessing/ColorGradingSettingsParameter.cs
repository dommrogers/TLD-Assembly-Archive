using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class ColorGradingSettingsParameter : ParameterOverride<ColorGradingSettings>
{
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	public ColorGradingSettingsParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
