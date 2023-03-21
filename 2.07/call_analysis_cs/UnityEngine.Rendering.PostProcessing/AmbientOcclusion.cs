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

	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(Shader), Member = "get_isSupported")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Shader), Member = "get_isSupported")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isAndroidOpenGL")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	public AmbientOcclusion()
	{
	}
}
