using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightRandomIntensity : MonoBehaviour
{
	public float m_IntervalSeconds;

	public float m_Min;

	public float m_Max;

	public bool m_AuroraLight;

	public bool m_NightOnly;

	public bool m_Fade;

	public float m_FadeTime;

	private float m_CurrentFadeTime;

	private float m_FadeMultiplier;

	private float m_CurrentTime;

	private float m_Destination;

	private float m_LightIntensityStart;

	private LightTracking m_Light;

	private UniStormWeatherSystem m_UniStorm;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetNightPercentage")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(LightTracking), Member = "EnableLight")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetNightPercentage")]
	[Calls(Type = typeof(LightTracking), Member = "EnableLight")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetNightPercentage")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightIntensity")]
	[CalledBy(Type = typeof(FlareIntensity), Member = "MaybeUpdateIntensityRTPC")]
	[CalledBy(Type = typeof(FlareIntensity), Member = "MaybeUpdateIntensityRTPC")]
	[CalledBy(Type = typeof(TorchIntensity), Member = "MaybeUpdateIntensityRTPC")]
	[CalledBy(Type = typeof(TorchIntensity), Member = "MaybeUpdateIntensityRTPC")]
	public float GetIntensity()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public LightRandomIntensity()
	{
	}
}
