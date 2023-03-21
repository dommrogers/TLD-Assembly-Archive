using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProNoise : PostProcessEffectSettings
{
	public FloatParameter stretchResolution;

	public FloatParameter n_NoiseLinesAmountY;

	public BoolParameter f_Granularity;

	public FloatParameter f_GranularityAmount;

	public BoolParameter f_TapeNoise;

	public FloatParameter n_NoiseSignalProcessing;

	public FloatParameter f_TapeNoiseAmount;

	public FloatParameter tapeLinesAmount;

	public FloatParameter f_TapeNoiseTH;

	public FloatParameter f_TapeNoiseSpeed;

	public BoolParameter f_LineNoise;

	public FloatParameter f_LineNoiseAmount;

	public FloatParameter f_LineNoiseSpeed;

	public BoolParameter f_SignalNoise;

	public FloatParameter f_SignalNoisePower;

	public FloatParameter f_SignalNoiseAmount;

	public BoolParameter mask;

	public TextureParameter maskTexture;

	public BoolParameter unscaledTime;

	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 19)]
	public RLProNoise()
	{
	}
}
