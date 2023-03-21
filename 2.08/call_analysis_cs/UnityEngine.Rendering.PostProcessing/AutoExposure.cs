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

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isAndroidOpenGL")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public AutoExposure()
	{
	}
}
