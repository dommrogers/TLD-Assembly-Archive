using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class ColorGrading : PostProcessEffectSettings
{
	public GradingModeParameter gradingMode;

	public TextureParameter externalLut;

	public TonemapperParameter tonemapper;

	public FloatParameter toneCurveToeStrength;

	public FloatParameter toneCurveToeLength;

	public FloatParameter toneCurveShoulderStrength;

	public FloatParameter toneCurveShoulderLength;

	public FloatParameter toneCurveShoulderAngle;

	public FloatParameter toneCurveGamma;

	public TextureParameter ldrLut;

	public FloatParameter ldrLutContribution;

	public FloatParameter temperature;

	public FloatParameter tint;

	public ColorParameter colorFilter;

	public FloatParameter hueShift;

	public FloatParameter saturation;

	public FloatParameter brightness;

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

	public SplineParameter masterCurve;

	public SplineParameter redCurve;

	public SplineParameter greenCurve;

	public SplineParameter blueCurve;

	public SplineParameter hueVsHueCurve;

	public SplineParameter hueVsSatCurve;

	public SplineParameter satVsSatCurve;

	public SplineParameter lumVsSatCurve;

	public ColorGradingSettingsParameter settings1A;

	public ColorGradingSettingsParameter settings1B;

	public ColorGradingSettingsParameter settings2A;

	public ColorGradingSettingsParameter settings2B;

	public Vector4Parameter blendRecord;

	public FloatParameter blendGamma;

	public FloatParameter blendGammaLimitLow;

	public FloatParameter blendGammaLimitHigh;

	public FloatParameter blendColorScalar;

	public FloatParameter blendHdrScalar;

	public ColorGradingSettingsParameter stimSettings;

	public FloatParameter stimEffectIntensity;

	public FloatParameter stimEffectIntensityTarget;

	public ColorGradingSettingsParameter electrocutionSettings;

	public FloatParameter electrocutionEffectIntensity;

	public FloatParameter electrocutionEffectIntensityTarget;

	public ColorGradingSettingsParameter painSettings;

	public FloatParameter painEffectIntensity;

	public FloatParameter painEffectIntensityTarget;

	public ColorGradingSettingsParameter boostEffectSettings;

	public FloatParameter boostEffectIntensity;

	public FloatParameter boostEffectIntensityTarget;

	public ColorGradingSettingsParameter headacheSettings;

	public FloatParameter headacheEffectIntensity;

	public FloatParameter headacheEffectIntensityTarget;

	public ColorGradingSettingsParameter suffocationSettings;

	public FloatParameter suffocationEffectIntensity;

	public FloatParameter suffocationEffectIntensityTarget;

	public ColorGradingSettingsParameter auxSettings;

	public FloatParameter auxEffectIntensity;

	public FloatParameter auxEffectIntensityTarget;

	public TextureParameter noiseTexture;

	public Vector4Parameter noiseParams;

	public BoolParameter noiseRandomize;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CallsUnknownMethods(Count = 1)]
	public float GetBlendGammaForBrightness(float brightness)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(PostProcessManager), Member = "QuickVolume")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	public static PostProcessVolume ApplyTempLut(ColorGradingSettings temp)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(ColorGrading), Member = "UpdateLutForTimeOfDay")]
	[CallsUnknownMethods(Count = 1)]
	public void ConfigureLutForInterior(ColorGradingSettings customLUT)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ColorGrading), Member = "ConfigureLutForInterior")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(GenericIndoors), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	public void UpdateLutForTimeOfDay(ColorGradingSettings settings1A, ColorGradingSettings settings1B, ColorGradingSettings settings2A, ColorGradingSettings settings2B, float blend1, float blend2, float blendCombine)
	{
	}

	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorGradingSettingsParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorGradingSettingsParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorGradingSettingsParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorGradingSettingsParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorGradingSettingsParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallsUnknownMethods(Count = 73)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorGradingSettingsParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorGradingSettingsParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorGradingSettingsParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorGradingSettingsParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorGradingSettingsParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorGradingSettingsParameter), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	public ColorGrading()
	{
	}
}
