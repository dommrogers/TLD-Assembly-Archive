using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TorchIntensity : MonoBehaviour
{
	public float m_Intensity;

	public bool m_DynamicIntensity;

	public float m_IntensityLerpSpeed;

	public AnimationCurve m_SparkRate;

	public AnimationCurve m_SmokeRate;

	public Gradient m_SmokeColor;

	public AnimationCurve m_SmokeAlpha;

	public AnimationCurve m_SpriteSize;

	public AnimationCurve m_SpriteRateMin;

	public AnimationCurve m_SpriteRateMax;

	public AnimationCurve m_CoreSize;

	public AnimationCurve m_CoreRateMin;

	public AnimationCurve m_CoreRateMax;

	public AnimationCurve m_IndoorIntensityMin;

	public AnimationCurve m_IndoorIntensityMax;

	public AnimationCurve m_OutdoorIntensityMin;

	public AnimationCurve m_OutdoorIntensityMax;

	public GameObject m_CoreParticles;

	public GameObject m_SparkParticles;

	public GameObject m_SmokeParticles;

	public GameObject m_SpriteParticles;

	public GameObject m_IndoorLight;

	public GameObject m_OutdoorLight;

	public GameObject m_RadialGradient;

	private ParticleSystem m_SpriteParticles_ParticleSystem;

	private ParticleRandomEmission m_SpriteParticles_ParticleRandomEmission;

	private ParticleSystem m_CoreParticles_ParticleSystem;

	private ParticleRandomEmission m_CoreParticles_ParticleRandomEmission;

	private ParticleSystem m_SmokeParticles_ParticleSystem;

	private ParticleSystem m_SparkParticles_ParticleSystem;

	private LightRandomIntensity m_IndoorLight_LightRandomIntensity;

	private LightRandomIntensity m_OutdoorLight_LightRandomIntensity;

	private float m_TargetIntensity;

	private float m_PreviousIntensity;

	private float m_LastIntensitySentToWise;

	private GearItem m_GearItem;

	private float m_MaxIndoorLightIntensity;

	private float m_MaxOutdoorLightIntensity;

	private Color m_RadialGradientColor;

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	private void Start()
	{
	}

	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(TorchItem), Member = "GetBurnProgress")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchIntensity), Member = "MaybeUpdateIntensityRTPC")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void SetIntensity(float intensity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetEmissionRate(ParticleSystem ps, float newRate)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TorchIntensity), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(LightRandomIntensity), Member = "GetIntensity")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightRandomIntensity), Member = "GetIntensity")]
	private void MaybeUpdateIntensityRTPC()
	{
	}

	[CallerCount(Count = 0)]
	public TorchIntensity()
	{
	}
}
