using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class KeroseneLampIntensity : MonoBehaviour
{
	public float m_Intensity;

	public bool m_DynamicIntensity;

	public AnimationCurve m_FlameRateMin;

	public AnimationCurve m_FlameRateMax;

	public Gradient m_FlameColor;

	public float m_IndoorIntensity;

	public float m_OutdoorIntensity;

	public float m_FillIntensity;

	public float m_RimIntensity;

	public Gradient m_GlassColor;

	public GameObject m_FlameParticles;

	private LightTracking m_IndoorLight;

	private LightTracking m_IndoorLightCore;

	private LightTracking m_SelfLightFill;

	private LightTracking m_SelfLightRim;

	private LightTracking m_OutdoorLight;

	public GameObject m_LitGlass;

	public GameObject m_Glass;

	public GameObject m_RadialGradient;

	private float m_ParticleIntensity;

	private ParticleSystem m_FlameParticles_ParticleSystem;

	private ParticleRandomEmission m_FlameParticles_ParticleRandomEmission;

	private Material m_LitGlassMaterial;

	private float m_PreviousIntensity;

	private float m_LastIntensitySentToWise;

	private GearItem m_GearItem;

	private float m_MaxFlameParticlesEmission;

	private Color m_RadialGradientColor;

	private float currentCameraAngle;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void InstantFullEmission()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetIntensity(float intensity)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	private float GetEmissionRate(ParticleSystem ps)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetEmissionRate(ParticleSystem ps, float newRate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeUpdateIntensityRTPC()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public KeroseneLampIntensity()
	{
	}
}
