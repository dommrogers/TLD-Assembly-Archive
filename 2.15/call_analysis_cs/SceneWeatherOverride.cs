using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SceneWeatherOverride : MonoBehaviour
{
	public float m_IndoorTemperatureCelsius;

	public float m_HighTempMinCelsius;

	public float m_HighTempMaxCelsius;

	public float m_LowTempMinCelsius;

	public float m_LowTempMaxCelsius;

	public float m_BlizzardDegreesDrop;

	public float m_BlizzardDegreesChangePerSecond;

	public int m_HourWarmingBegins;

	public int m_HourCoolingBegins;

	public int m_AuroraEarlyWindowProbability;

	public int m_AuroraLateWindowProbability;

	public float m_DegreesPerSecondChangeLow;

	public float m_DegreesPerSecondChangeMedium;

	public float m_DegreesPerSecondChangeHigh;

	public float m_TimeToDisplayTempWhenChanged;

	public float m_MinWindSpeedForBlowingSnow;

	public float m_BlowingSnowTransitionSeconds;

	public float m_MinimumFogDensityScale;

	public Vector4 m_SkyboxHorizonAdjust;

	public WeatherSetData[] m_WeatherSetOverrides;

	public float m_OcclusionTestRange;

	public float m_OcclusionTestFOV;

	public float m_OcclusionReduceWindchillPercent;

	public AudioOcclusionLevel m_OcclusionAudioLevel;

	public bool m_NeverCalmWind;

	public float m_HoursBetweenWindChangeMin;

	public float m_HoursBetweenWindChangeMax;

	public float m_SlightlyWindyMPHThreshold;

	public float m_WindyMPHThreshold;

	public float m_VeryWindyMPHThreshold;

	public float m_MaxWindMPH;

	public float m_MinimumBlizzardWindSpeed;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherSetStage), Member = "Deactivate")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "RegisterSceneWeatherSets")]
	[CallsUnknownMethods(Count = 1)]
	public void DoWeatherOverride()
	{
	}

	[CallerCount(Count = 0)]
	public SceneWeatherOverride()
	{
	}
}
