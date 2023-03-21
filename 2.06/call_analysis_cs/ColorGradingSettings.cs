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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UnityEngine.Rendering.PostProcessing.ColorGrading), Member = "ApplyTempLut")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	public void ApplySettings(UnityEngine.Rendering.PostProcessing.ColorGrading cg)
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "GetCurveTexture")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[Calls(Type = typeof(ColorUtilities), Member = "ComputeColorBalance")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	public void ApplySettings(MaterialPropertyBlock properties)
	{
	}

	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CalledBy(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	private Texture2D GetCurveTexture(bool hdr)
	{
		return null;
	}

	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 174)]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	public ColorGradingSettings()
	{
	}
}
