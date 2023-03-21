using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InteriorLightingManager : MonoBehaviour
{
	public bool m_ForceClearWeather;

	public float m_MiddayMultiplier;

	public float m_MiddayAmbientMultiplier;

	public float m_SandboxAmbientMultiplier;

	public GameObject m_LightGroupParent;

	private List<InteriorLightingGroup> m_LightGroupList;

	public GameObject m_LooseLightParent;

	private List<Light> m_LooseLightList;

	private List<float> m_LooseLightsOriginal;

	public GameObject m_LooseLightMiddayParent;

	private List<Light> m_LooseLightsMiddayList;

	private List<float> m_LooseLightsMiddayOriginal;

	public GameObject m_FxParent;

	private List<ParticleSystem> m_ParticleList;

	private List<float> m_FXOriginalRate;

	public GameObject m_LightShaftParent;

	private List<LightShaftGimble> m_LightShaftGimbleList;

	private List<LightShaftTod> m_LightShaftTodList;

	public bool m_AutoGenerateCurves;

	public int m_CurveControlPoints;

	public ScaledCurve m_ClearWeatherCurve;

	public ScaledCurve m_PartlyCloudyWeatherCurve;

	public ScaledCurve m_CloudyWeatherCurve;

	public ScaledCurve m_LightSnowWeatherCurve;

	public ScaledCurve m_HeavySnowWeatherCurve;

	public ScaledCurve m_LightFogWeatherCurve;

	public ScaledCurve m_DenseFogWeatherCurve;

	public ScaledCurve m_BlizzardWeatherCurve;

	public ScaledCurve m_AuroraCurve;

	public MinMax m_ClearWeatherIntensity;

	public MinMax m_PartlyCloudyWeatherIntensity;

	public MinMax m_CloudyWeatherIntensity;

	public MinMax m_LightSnowWeatherIntensity;

	public MinMax m_HeavySnowWeatherIntensity;

	public MinMax m_LightFogWeatherIntensity;

	public MinMax m_DenseFogWeatherIntensity;

	public MinMax m_BlizzardWeatherIntensity;

	public MinMax m_AuroraIntensity;

	public MinMax m_CycleRate;

	public MinMax m_GroupCycleRate;

	public MinMax m_WindRateMultiplier;

	public MinMax m_NormalizedWindSpeed;

	public float m_AuroraRed;

	public float m_AuroraGreen;

	public float m_AuroraBlue;

	public float m_AuroraColorization;

	private float m_RandomRate;

	private float m_KeyStep;

	private float m_ScrubTimer;

	private float m_CurWeatherVal;

	private float m_LitGrpIntensity;

	private float m_TodIntensitySun;

	private float m_TodIntensityCalc;

	private float m_CurMiddayVal;

	private float m_CurMiddayAmb;

	private float m_AuroraFade;

	private Color m_SunColour;

	private float m_SunBright;

	private TodAmbientLight m_AmbientLight;

	private WeatherStage m_WeatherCur;

	private WeatherStage m_WeatherPrv;

	private float m_WeatherBlend;

	private TODBlendState curTodBS;

	private float curTodPercent;

	private bool m_Initialized;

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetStartingValues")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "FilterGroupedObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "FindLooseLights")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "FindLightGroups")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "InitializeCurves")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "FindLightShaftControllers")]
	[CallerCount(Count = 1)]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateParticles")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetAuroraColours")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateParticles")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateLightShaft")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrength")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateLightShaft")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "MiddayIntensities")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "MiddayIntensities")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	private void Update()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetGroupSpreadOffset")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetAuroraColours")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetBlendedCurve")]
	[Calls(Type = typeof(InteriorLightingGroup), Member = "ScrubUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	private void UpdateLights(float scrubTime, float todSun, float todCalc, float auroraIntensity)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	private Color GetAuroraColours()
	{
		return default(Color);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InteriorLightingManager), Member = "SetEmissionRate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateParticles(float timeOfDayIntensity)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void UpdateLightShaft(float timeOfDayIntensity, bool followTod)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateParticles")]
	[CallsUnknownMethods(Count = 4)]
	private void SetEmissionRate(ParticleSystem ps, float er)
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	private void InitializeCurves()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "GetBlendedCurve")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "GetBlendedCurve")]
	[CallsUnknownMethods(Count = 1)]
	private float EvaluateCurve(WeatherStage curWeather, float curTime)
	{
		return default(float);
	}

	[Calls(Type = typeof(InteriorLightingManager), Member = "EvaluateCurve")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InteriorLightingManager), Member = "EvaluateCurve")]
	private float GetBlendedCurve(WeatherStage weather1, WeatherStage weather2, float curTime, float weatherBlend)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 3)]
	private float GetWindMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[CallsUnknownMethods(Count = 3)]
	private float GetGroupSpreadOffset()
	{
		return default(float);
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	private float GetTimeOfDayIntensity()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	private float MiddayIntensities()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	private float GetSunlightIntensity(float sunlight, Color sunColor)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	private void FindLightShaftControllers()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void FindLightGroups()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallsUnknownMethods(Count = 16)]
	private void FindLooseLights()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void FindParticleSystems()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallsUnknownMethods(Count = 62)]
	private void GetStartingValues()
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallsUnknownMethods(Count = 56)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	private void FilterGroupedObjects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 91)]
	public InteriorLightingManager()
	{
	}
}
