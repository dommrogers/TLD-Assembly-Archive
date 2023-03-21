using System;
using System.Collections.Generic;
using System.Linq;
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

	[Calls(Type = typeof(InteriorLightingManager), Member = "GetStartingValues")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "FindLooseLights")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InteriorLightingManager), Member = "FilterGroupedObjects")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "FindLightGroups")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "InitializeCurves")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InteriorLightingManager), Member = "FindLightShaftControllers")]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetAuroraColours")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateParticles")]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrength")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateLightShaft")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateParticles")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateLightShaft")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "MiddayIntensities")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "MiddayIntensities")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[Calls(Type = typeof(InteriorLightingGroup), Member = "ScrubUpdate")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetBlendedCurve")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetAuroraColours")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetGroupSpreadOffset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	private void UpdateLights(float scrubTime, float todSun, float todCalc, float auroraIntensity)
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	private Color GetAuroraColours()
	{
		return default(Color);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InteriorLightingManager), Member = "SetEmissionRate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateParticles(float timeOfDayIntensity)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateLightShaft(float timeOfDayIntensity, bool followTod)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateParticles")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
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
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
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
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	private void InitializeCurves()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "GetBlendedCurve")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "GetBlendedCurve")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	private float EvaluateCurve(WeatherStage curWeather, float curTime)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "EvaluateCurve")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "EvaluateCurve")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	private float GetBlendedCurve(WeatherStage weather1, WeatherStage weather2, float curTime, float weatherBlend)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float GetWindMultiplier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	private float GetGroupSpreadOffset()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	private float GetTimeOfDayIntensity()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CallerCount(Count = 2)]
	private float MiddayIntensities()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	private float GetSunlightIntensity(float sunlight, Color sunColor)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void FindLightShaftControllers()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallsUnknownMethods(Count = 5)]
	private void FindLightGroups()
	{
	}

	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void FindLooseLights()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void FindParticleSystems()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void GetStartingValues()
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void FilterGroupedObjects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public InteriorLightingManager()
	{
	}
}
