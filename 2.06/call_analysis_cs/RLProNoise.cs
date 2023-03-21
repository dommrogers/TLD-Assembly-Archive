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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 106)]
	public RLProNoise()
	{
	}
}
