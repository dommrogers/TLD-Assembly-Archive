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

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "InitializeCurves")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "FindLightGroups")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "FindLooseLights")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "FindLightShaftControllers")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "FilterGroupedObjects")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetStartingValues")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "MiddayIntensities")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateParticles")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "UpdateLightShaft")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetAuroraColours")]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrength")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetGroupSpreadOffset")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetAuroraColours")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "GetBlendedCurve")]
	[Calls(Type = typeof(InteriorLightingGroup), Member = "ScrubUpdate")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 17)]
	private void UpdateLights(float scrubTime, float todSun, float todCalc, float auroraIntensity)
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[CallsUnknownMethods(Count = 1)]
	private Color GetAuroraColours()
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InteriorLightingManager), Member = "SetEmissionRate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateParticles(float timeOfDayIntensity)
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateLightShaft(float timeOfDayIntensity, bool followTod)
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateParticles")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void SetEmissionRate(ParticleSystem ps, float er)
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeCurves()
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "GetBlendedCurve")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 1)]
	private float EvaluateCurve(WeatherStage curWeather, float curTime)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(InteriorLightingManager), Member = "EvaluateCurve")]
	private float GetBlendedCurve(WeatherStage weather1, WeatherStage weather2, float curTime, float weatherBlend)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float GetWindMultiplier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float GetGroupSpreadOffset()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CallsUnknownMethods(Count = 1)]
	private float GetTimeOfDayIntensity()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CallsUnknownMethods(Count = 1)]
	private float MiddayIntensities()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	private float GetSunlightIntensity(float sunlight, Color sunColor)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void FindLightShaftControllers()
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void FindLightGroups()
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	private void FindLooseLights()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void FindParticleSystems()
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void GetStartingValues()
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 20)]
	private void FilterGroupedObjects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public InteriorLightingManager()
	{
	}
}
