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
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	private void Start()
	{
	}

	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateFX")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateLight")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateWeather")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateRotation")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateWeather")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateRotation")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateLight")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateFX")]
	public void ManualUpdate(float externalTod)
	{
	}

	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateGimbles")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWeather()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateGimbles")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateRotation(float tod)
	{
	}

	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateGimbles")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(LightShaftGimble), Member = "CalculateDot")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void UpdateMaterial(float tod)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateGimbles")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	private void UpdateLight(float tod)
	{
	}

	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateGimbles")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	private void UpdateFX(float tod)
	{
	}

	[CallerCount(Count = 0)]
	private float GetCombinedIntensity()
	{
		return default(float);
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetFollowTimeOfDay(bool followTod)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "UpdateMaterial")]
	[CallsUnknownMethods(Count = 6)]
	private float CalculateDot()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public LightShaftGimble()
	{
	}
}
