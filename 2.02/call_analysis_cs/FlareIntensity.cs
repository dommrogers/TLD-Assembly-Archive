using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FlareIntensity : MonoBehaviour
{
	public float m_Intensity;

	public bool m_DynamicIntensity;

	public AnimationCurve m_SmokeRate;

	public AnimationCurve m_CoreRate;

	public AnimationCurve m_SparkRate;

	public AnimationCurve m_IndoorIntensityMin;

	public AnimationCurve m_IndoorIntensityMax;

	public AnimationCurve m_OutdoorIntensityMin;

	public AnimationCurve m_OutdoorIntensityMax;

	public GameObject m_SmokeParticles;

	public GameObject m_CoreParticles;

	public GameObject m_SparkParticles;

	public GameObject m_IndoorLight;

	public GameObject m_OutdoorLight;

	public GameObject m_RadialGradient;

	private ParticleSystem m_SmokeParticles_ParticleSystem;

	private ParticleSystem m_CoreParticles_ParticleSystem;

	private ParticleSystem m_SparkParticles_ParticleSystem;

	private LightRandomIntensity m_IndoorLight_LightRandomIntensity;

	private LightRandomIntensity m_OutdoorLight_LightRandomIntensity;

	private float m_PreviousIntensity;

	private float m_LastIntensitySentToWise;

	private GearItem m_GearItem;

	private float m_MaxIndoorLightIntensity;

	private float m_MaxOutdoorLightIntensity;

	private Color m_RadialGradientColor;

	private MeshRenderer m_RadialGradientMeshRenderer;

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(FlareIntensity), Member = "MaybeUpdateIntensityRTPC")]
	[Calls(Type = typeof(FlareIntensity), Member = "SetIntensity")]
	[Calls(Type = typeof(FlareItem), Member = "GetNormalizedBurnTimeLeft")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 21)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(FlareIntensity), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void SetIntensity(float intensity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(FlareIntensity), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(LightRandomIntensity), Member = "GetIntensity")]
	[Calls(Type = typeof(LightRandomIntensity), Member = "GetIntensity")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void MaybeUpdateIntensityRTPC()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FlareIntensity()
	{
	}
}
