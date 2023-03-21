using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ColorGradingSettings : PostProcessEffectSettings
{
	public FloatParameter temperature;

	public FloatParameter tint;

	public ColorParameter colorFilter;

	public FloatParameter hueShift;

	public FloatParameter saturation;

	public FloatParameter postExposure;

	public FloatParameter contrast;

	public FloatParameter mixerRedOutRedIn;

	public FloatParameter mixerRedOutGreenIn;

	public FloatParameter mixerRedOutBlueIn;

	public FloatParameter mixerGreenOutRedIn;

	public FloatParameter mixerGreenOutGreenIn;

	public FloatParameter mixerGreenOutBlueIn;

	public FloatParameter mixerBlueOutRedIn;

	public FloatParameter mixerBlueOutGreenIn;

	public FloatParameter mixerBlueOutBlueIn;

	public Vector4Parameter lift;

	public Vector4Parameter gamma;

	public Vector4Parameter gain;

	public SplineParameter hueVsHueCurve;

	public SplineParameter hueVsSatCurve;

	public SplineParameter satVsSatCurve;

	public SplineParameter lumVsSatCurve;

	private Texture2D m_GradingCurves;

	private readonly Color[] m_Pixels;

	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CalledBy(Type = typeof(UnityEngine.Rendering.PostProcessing.ColorGrading), Member = "ApplyTempLut")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsUnknownMethods(Count = 53)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 37)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	public void ApplySettings(UnityEngine.Rendering.PostProcessing.ColorGrading cg)
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "GetCurveTexture")]
	[Calls(Type = typeof(ColorUtilities), Member = "ColorToInverseGamma")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Exp2")]
	[Calls(Type = typeof(ColorUtilities), Member = "ComputeColorBalance")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	public void ApplySettings(MaterialPropertyBlock properties)
	{
	}

	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CalledBy(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	private Texture2D GetCurveTexture(bool hdr)
	{
		return null;
	}

	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.Spline), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.Spline), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.Spline), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.Spline), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 253)]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	public ColorGradingSettings()
	{
	}
}
