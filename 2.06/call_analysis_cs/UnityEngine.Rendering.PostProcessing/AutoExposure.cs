using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class AutoExposure : PostProcessEffectSettings
{
	public Vector2Parameter filtering;

	public FloatParameter minLuminance;

	public FloatParameter maxLuminance;

	public FloatParameter keyValue;

	public EyeAdaptationParameter eyeAdaptation;

	public FloatParameter speedUp;

	public FloatParameter speedDown;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isAndroidOpenGL")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 36)]
	public AutoExposure()
	{
	}
}
