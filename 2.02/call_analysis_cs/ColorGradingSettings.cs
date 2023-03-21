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

	[CalledBy(Type = typeof(UnityEngine.Rendering.PostProcessing.ColorGrading), Member = "ApplyTempLut")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(ParameterOverride<>), Member = "Override")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallsUnknownMethods(Count = 53)]
	public void ApplySettings(UnityEngine.Rendering.PostProcessing.ColorGrading cg)
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ColorUtilities), Member = "ComputeColorBalance")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Exp2")]
	[Calls(Type = typeof(ColorUtilities), Member = "ColorToInverseGamma")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "GetCurveTexture")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 28)]
	public void ApplySettings(MaterialPropertyBlock properties)
	{
	}

	[CalledBy(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 39)]
	private Texture2D GetCurveTexture(bool hdr)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.Spline), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 253)]
	public ColorGradingSettings()
	{
	}
}
