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

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateWeather")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateRotation")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateLight")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateFX")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateLight")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateGimbles")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateFX")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateWeather")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateRotation")]
	public void ManualUpdate(float externalTod)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateWeather()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	private void UpdateRotation(float tod)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightShaftGimble), Member = "CalculateDot")]
	private void UpdateMaterial(float tod)
	{
	}

	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	private void UpdateLight(float tod)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "Update")]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetFollowTimeOfDay(bool followTod)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(LightShaftGimble), Member = "UpdateMaterial")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	private float CalculateDot()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LightShaftGimble()
	{
	}
}
