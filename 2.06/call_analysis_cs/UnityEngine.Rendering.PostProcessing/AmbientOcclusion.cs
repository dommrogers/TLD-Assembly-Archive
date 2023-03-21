using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class AmbientOcclusion : PostProcessEffectSettings
{
	public AmbientOcclusionModeParameter mode;

	public FloatParameter intensity;

	public ColorParameter color;

	public BoolParameter ambientOnly;

	public FloatParameter noiseFilterTolerance;

	public FloatParameter blurTolerance;

	public FloatParameter upsampleTolerance;

	public FloatParameter thicknessModifier;

	public FloatParameter directLightingStrength;

	public FloatParameter radius;

	public AmbientOcclusionQualityParameter quality;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "get_isSupported")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isAndroidOpenGL")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Shader), Member = "get_isSupported")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 56)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	public AmbientOcclusion()
	{
	}
}
