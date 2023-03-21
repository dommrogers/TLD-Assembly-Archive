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

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Gradient), Member = "Evaluate")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_localRotation")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(KeroseneLampIntensity), Member = "SetIntensity")]
	[Calls(Type = typeof(KeroseneLampIntensity), Member = "MaybeUpdateIntensityRTPC")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "GetPercentFuelRemaining")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void InstantFullEmission()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(KeroseneLampIntensity), Member = "Update")]
	public void SetIntensity(float intensity)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	private float GetEmissionRate(ParticleSystem ps)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	private void SetEmissionRate(ParticleSystem ps, float newRate)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(KeroseneLampIntensity), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeUpdateIntensityRTPC()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public KeroseneLampIntensity()
	{
	}
}
