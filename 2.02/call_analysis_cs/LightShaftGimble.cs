using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightShaftGimble : MonoBehaviour
{
	public bool m_FollowTod;

	public ScaledCurve m_Horizontal;

	public ScaledCurve m_Vertical;

	public ScaledCurve m_MaximumRayIntensity;

	public ScaledCurve m_MaximumLightIntensity;

	public GameObject[] m_LightShaft;

	public Light m_Light;

	public ParticleSystem m_Particles;

	public bool m_UseLightColour;

	public bool m_UseRayIntensityOnly;

	public bool m_FadeWithViewAngle;

	public bool m_AffectedByClouds;

	public bool m_AffectedByFog;

	public MinMax m_FogRange;

	public GameObject m_HorizontalGimble;

	public GameObject m_VerticalGimble;

	private float m_ExternalIntensity;

	private float m_TodIntensity;

	private float m_WeatherIntensity;

	private float m_GlobalTod;

	private float m_Dot;

	private float m_LightStartIntensity;

	private Renderer[] m_LightShaftRenderer;

	private Color m_ParticleStartColour;

	private ParticleSystem.MainModule m_ParticleMainModule;

	private bool m_UseManagerTOD;

	private MaterialPropertyBlock m_MatProp;

	private static readonly int m_shaderGain;

	private static readonly int m_shaderColor;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 19)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateWeather")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateRotation")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateLight")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateFX")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateGimbles")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateWeather")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateRotation")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateLight")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateFX")]
	public void ManualUpdate(float externalTod)
	{
	}

	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateWeather()
	{
	}

	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateRotation(float tod)
	{
	}

	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(LightShaftGimble), Member = "CalculateDot")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateMaterial(float tod)
	{
	}

	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateLight(float tod)
	{
	}

	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateFX(float tod)
	{
	}

	[CallerCount(Count = 0)]
	private float GetCombinedIntensity()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetTimeOfDayIntensity(float todIntensity)
	{
	}

	[CallerCount(Count = 0)]
	public void SetExternalIntensity(float newIntensity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void UseExternalTod(bool externalTod)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetFollowTimeOfDay(bool followTod)
	{
	}

	[CalledBy(Type = typeof(LightShaftGimble), Member = "UpdateMaterial")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private float CalculateDot()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LightShaftGimble()
	{
	}
}
