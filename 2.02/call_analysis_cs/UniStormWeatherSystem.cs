using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using UnityEngine;

public class UniStormWeatherSystem : MonoBehaviour
{
	private const float SUN_SIZE = 0.1f;

	public WeatherStateConfig[] m_WeatherStateConfigs;

	public TODStateConfig[] m_SpecialTODStates;

	public SpecialTODState m_SpecialTODState;

	public float[] m_SpecialTODStateFixedTimes;

	public bool m_StaticWeather;

	public bool m_LiveEdit;

	public float m_AnimScalar_Ambient;

	public float m_AnimScalar_Directional;

	public float m_MasterTimeKeyOffset;

	public float m_MasterAmbientIntensityScalar;

	public float m_MasterSunLightIntensityScalar;

	public float m_MasterMoonLightIntensityScalar;

	public float m_MasterSunShadowStrengthReduction;

	public float m_MasterMoonShadowStrengthReduction;

	public float m_MasterMoonShadowStrengthCap;

	public float m_FarClipCheat;

	public float m_FogColorMargin;

	public int m_MinuteCounter;

	public int m_HourCounter;

	public int m_DayCounter;

	public int m_Temperature;

	public float m_DayLength;

	public float m_NormalizedTime;

	private float[] m_TODKeyframeTimes;

	public int m_MoonCycleStartDay;

	public float m_MoonPhaseIntensityControl;

	public float m_SunAngle;

	public Color m_MoonLightColor;

	public Color m_MoonLightColorOverride;

	public Color m_StarColor;

	public float m_CloudSpeed;

	public float m_BlizzardFogBlusterRange;

	public float m_BlizzardFogBlusterSpeed;

	public WeatherStage m_PreviousWeatherStage;

	public WeatherStage m_CurrentWeatherStage;

	private float m_NormalizedAuroraAlpha;

	public float m_SkyboxFogSampleDistance;

	public float m_SkyboxFogPower;

	public Material m_SkyboxMaterial;

	public Renderer[] m_SkyGlowRenderers;

	public ColorGradingSettings m_DefaultColorGradingSettings;

	public HeightFogManager m_HeightFogManager;

	public GameObject m_SnowPlaneManager;

	public GameObject m_StarSphere;

	public Texture2D[] m_MoonPhases;

	public Light m_SunLight;

	public Light m_MoonLight;

	public GodrayManager m_GodrayManager;

	public float m_CloudCoverage;

	public float m_FogDensity;

	public GameObject m_LightClouds1;

	public GameObject m_LightClouds2;

	public GameObject m_HighClouds1;

	public GameObject m_MostlyCloudyClouds;

	public static float m_MinimumFogDensityScale;

	public static float m_FogScale;

	private SnowPlaneManager m_SnowPlaneManagerComponent;

	private Renderer m_StarSphereRenderer;

	private Renderer m_LightClouds1_Renderer;

	private Renderer m_LightClouds2_Renderer;

	private Renderer m_HighClouds1_Renderer;

	private Renderer m_MostlyCloudyClouds_Renderer;

	private Renderer m_HorizonCloudsBand1_Renderer;

	private Renderer m_HorizonCloudsBand2_Renderer;

	private Renderer m_HorizonCloudsBand3_Renderer;

	private Renderer m_SkyCloudEdge1_Renderer;

	private Renderer m_SkyCloudEdge2_Renderer;

	private Renderer m_HorizonGrad_Renderer;

	private Material m_SkyboxMaterialCopy;

	public Camera m_MainCamera;

	public WeatherParticleManagerConfiguration m_WeatherParticleManagerConfig;

	private WeatherParticleManager m_WeatherParticleManager;

	private float m_Hour;

	private float m_MinuteCounterCalculator;

	private float m_ActiveSunAngle;

	private bool m_LockAmbientLight;

	private GameObject m_WeatherSystemsGameObject;

	private GameObject m_CloudParentGameObject;

	public float m_DayLengthScale;

	public float m_CurrentWeatherBlend;

	private float m_DeltaTime;

	private bool m_WarmingWeatherState;

	private float m_SecondsSinceLastWeatherChange;

	private bool m_MoonPhaseSet;

	private int m_CurrentMoonPhaseIndex;

	private float m_MoonPhaseIntensityScalar;

	private Vector2 m_BlizzardFogNoiseVec;

	private float m_AmbientLightTransitionTimeSeconds;

	private bool m_Paused;

	private bool m_Indoors;

	private float m_ElapsedHours;

	private float m_ElapsedHoursAccumulator;

	private float m_ElapsedHoursIndoorsAccumulator;

	private float m_ElapsedHoursOutdoorsAccumulator;

	private float m_ElapsedHoursAsleepAccumulator;

	private float m_ElapsedHoursAsleepOutdoorsAccumulator;

	private float m_ElapsedHoursAwakeAccumulator;

	private float m_ElapsedHoursLakeRegionAccumulator;

	private float m_ElapsedHoursCoastalRegionAccumulator;

	private float m_ElapsedHoursRuralRegionAccumulator;

	private float m_ElapsedHoursWhalingStationRegionAccumulator;

	private float m_ElapsedHoursCrashMountainRegionAccumulator;

	private float m_ElapsedHoursMarshRegionAccumulator;

	private float m_ElapsedHoursTracksRegionAccumulator;

	private float m_ElapsedHoursMountainTownRegionAccumulator;

	private float m_ElapsedHoursRiverValleyRegionAccumulator;

	private float m_ElapsedHoursCanneryRegionAccumulator;

	private float m_ElapsedHoursAshCanyonRegionAcculumator;

	private float m_ElapsedHoursBlackrockRegionAccumulator;

	private bool m_LastFrameWasOutside;

	private bool m_LastFrameWasNight;

	private bool m_OutsideSinceBeginningOfNight;

	private bool m_UseMoonColourColorOverride;

	private float m_WeatherTransitionTime;

	private ActiveEnvironment m_ActiveEnvironment;

	public SpecialTODState m_RequestedSpecialTODState;

	private SpecialTODState m_LastSpecialTODState;

	private GameRegion m_CurrentRegion;

	private Animator m_Animator;

	private Vector4 m_CloudTextureOffset_LightClouds1;

	private Vector4 m_CloudTextureOffset_LightClouds2;

	private Vector4 m_CloudTextureOffset_HighClouds1;

	private Vector4 m_CloudTextureOffset_MostlyCloudyClouds;

	private MaterialPropertyBlock m_OnUpdatePropertyBlock;

	private List<SunShadowOverrideVolume> m_SunShadowOverrideVolumes;

	private static float s_OriginalNightToxicFogDensity;

	private static readonly int s_ColorShaderID;

	private static readonly int s_MainTexOffsetShaderID;

	private static readonly int s_TintColorShaderID;

	private static readonly int s_MoonXShaderID;

	private static readonly int s_MoonYShaderID;

	private static readonly int s_MoonZShaderID;

	private static readonly int s_MoonColorShaderID;

	private static readonly int s_MoonTexShaderID;

	private static readonly int s_MoonGlowShaderID;

	private static readonly int s_AmbientLightColorShaderID;

	private static readonly int s_FogColorShaderID;

	private static readonly int s_AtmosphereThicknessShaderID;

	private static readonly int s_ExposureShaderID;

	private static readonly int s_SunSizeShaderID;

	private static readonly int s_SunDiffusionShaderID;

	private static readonly int s_SunDirShaderID;

	private static readonly int s_SunColorShaderID;

	private static readonly int s_HorizonAdjustShaderID;

	private static readonly int s_GlobalSunDirShaderID;

	private static readonly int s_GlobalSunLuminanceShaderID;

	private static readonly int s_GlobalGrassTintScalarShaderID;

	private static readonly int s_FresnelcolorShaderID;

	private const float ENDLESSNIGHT_NORMALIZEDTIME = 0.2f;

	private static float[] m_MoonIntensityByPhaseScalars;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TODStateConfig GetActiveTODState()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public void Awake()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[Calls(Type = typeof(WeatherParticleManager), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(ActiveEnvironment), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "InstantiateUniStorm")]
	[CallsUnknownMethods(Count = 53)]
	public void Init()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDisable()
	{
	}

	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegionManager), Member = "GetCurrentRegion")]
	public void InitializeForScene()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "InitializeForScene")]
	[CallsUnknownMethods(Count = 1)]
	public void InitializeAfterSceneLoad()
	{
	}

	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[CallsUnknownMethods(Count = 497)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalColor")]
	[Calls(Type = typeof(RenderSettings), Member = "get_fogDensity")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "op_UnaryNegation")]
	[Calls(Type = typeof(Vector4), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateShadowStrength")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(Weather), Member = "SetSnowColor")]
	[Calls(Type = typeof(Weather), Member = "SetBlowingSnowColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "op_UnaryNegation")]
	[Calls(Type = typeof(Vector4), Member = "op_Implicit")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[Calls(Type = typeof(Color), Member = "get_black")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalColor")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "WarmWeatherState")]
	[Calls(Type = typeof(Color), Member = "op_Multiply")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Mathf), Member = "Max")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Mathf), Member = "Max")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(RenderSettings), Member = "set_fog")]
	[Calls(Type = typeof(RenderSettings), Member = "set_fogMode")]
	[Calls(Type = typeof(RenderSettings), Member = "set_fogDensity")]
	[Calls(Type = typeof(RenderSettings), Member = "set_fogColor")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "ApproximateColorMatch")]
	[Calls(Type = typeof(Mathf), Member = "Max")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetMoonPhase")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Feat_EfficientMachine), Member = "IncrementElapsedHours")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(Weather), Member = "SetSnowPresetBlend")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 77)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsBrightnessCalibrationActive")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetMoonPhase")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendBiased")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(Vector4), Member = "op_Implicit")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "op_UnaryNegation")]
	[Calls(Type = typeof(Vector4), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Dot")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "op_UnaryNegation")]
	[Calls(Type = typeof(Vector3), Member = "Dot")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(Camera), Member = "set_backgroundColor")]
	[Calls(Type = typeof(Utils), Member = "SetAmbientLight")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Light), Member = "set_color")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "op_UnaryNegation")]
	[Calls(Type = typeof(Light), Member = "set_color")]
	[Calls(Type = typeof(Vector3), Member = "Cross")]
	[Calls(Type = typeof(Vector4), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Vector3), Member = "Cross")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public float GetClearNightFogDensity()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetFogDensity")]
	[CallsUnknownMethods(Count = 13)]
	public void SetToxicFogDensity(float fogDensity)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetOriginalNightToxicFogDensity()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateVisibility")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNightOrNightBlend")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDusk")]
	public float GetMaxAuroraIntensity()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Feat_ColdFusion), Member = "IncrementHours")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Feat_BlizzardWalker), Member = "IncrementHours")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	private void UpdateTimeStats(float timeDeltaHours)
	{
	}

	[Calls(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[CallsUnknownMethods(Count = 1)]
	public void DoLateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	public void DoLateUpdate_part1()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part2")]
	[CallerCount(Count = 0)]
	public void DoLateUpdate_part2()
	{
	}

	[CallerCount(Count = 0)]
	public void ClearSpecialTODState()
	{
	}

	[CallerCount(Count = 0)]
	public void RequestSpecialTODState(SpecialTODState state)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void SetNormalizedTime(float time)
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "InstantiateUniStorm")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	public void SetNormalizedTime(float time, bool forceUpdate)
	{
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "WarmWeatherState")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	public void UpdateSunTransform()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetAmbientLight(Color c)
	{
	}

	[CallerCount(Count = 0)]
	public void LockAmbientLight(bool lockAmbient)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	public void EnableWeatherSystems(bool enable)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CallsUnknownMethods(Count = 3)]
	public void EnableCloudParent(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WeatherStage GetWeatherStage()
	{
		return default(WeatherStage);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Weather), Member = "Deserialize")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UpdateDecalProjectorLifeTimes")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SendWeatherStateToWise")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	public void SetWeatherStage(WeatherStage ws, float transitionTime, bool force = false)
	{
	}

	[CalledBy(Type = typeof(WeatherSetStage), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(WeatherSet), Member = "Update")]
	[CalledBy(Type = typeof(WeatherSetStage), Member = "Activate")]
	[CalledBy(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UpdateDecalProjectorLifeTimes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SendWeatherStateToWise")]
	public void SetWeatherStateAndBlendDirectly(WeatherStage ws, WeatherStage prevWS, float elapsedGameTimeInStage, float transitionGameTimeForStage)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeatherState")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	public void WarmWeatherState()
	{
	}

	[CallerCount(Count = 0)]
	public int GetMoonPhaseIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetMoonPhaseIndex(int phase)
	{
	}

	[CallerCount(Count = 0)]
	public float GetMoonIntensityScalar()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	public void SetMoonPhase()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsFullMoon()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetMoonColourOverride(bool enableOverride)
	{
	}

	[CallerCount(Count = 0)]
	public void SetMoonColourOverrideColour(Color newColor)
	{
	}

	[CallerCount(Count = 0)]
	public void SetPaused(bool paused)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetDayNumber()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetDayNumber(int day)
	{
	}

	[CallerCount(Count = 0)]
	public void SetIsIndoors(bool indoors)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetAuroraAlpha(float alpha)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetMaxAuroraIntensity")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	public bool IsNightOrNightBlend()
	{
		return default(bool);
	}

	[CallerCount(Count = 45)]
	[CallsUnknownMethods(Count = 5)]
	public bool IsNight()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public bool IsNightWithExtendedHours(float extendedHours)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsMorning()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsAfternoon()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	public bool IsNightPreMidnight()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsNightPostMidnight()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(MultiplyNighttimeParticleOpacity), Member = "Update")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "UpdateNightOnlyObject")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetNightPercentage")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDusk")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "UpdateDayOnlyObject")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[CalledBy(Type = typeof(Carrion), Member = "IsTooDark")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	public bool IsDusk()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetNightPercentage")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetMaxAuroraIntensity")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(MultiplyNighttimeParticleOpacity), Member = "Update")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "UpdateDayOnlyObject")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "IsDawn")]
	[CalledBy(Type = typeof(Carrion), Member = "IsTooDark")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "UpdateNightOnlyObject")]
	[CallerCount(Count = 14)]
	public bool IsDawn()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public bool IsDayWithExtendedHours(float extendedHours)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public float GetDawnHourTime()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public bool IsEarlyNightWindowForAuroraActivation()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsLateNightWindowForAuroraActivation()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public float GetDawnTime()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public float GetNightStartTime()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateForDusk")]
	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateForDusk")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetMaxAuroraIntensity")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "GetProgressDusk")]
	[CallerCount(Count = 4)]
	public float GetProgressDusk()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetMaxAuroraIntensity")]
	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateForDawn")]
	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateForDawn")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "GetProgressDawn")]
	public float GetProgressDawn()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[CalledBy(Type = typeof(TransformAtNight), Member = "Update")]
	[CalledBy(Type = typeof(NPCLightingRig), Member = "Update")]
	[CalledBy(Type = typeof(NPCLightingRig), Member = "Update")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	public float GetNightPercentage()
	{
		return default(float);
	}

	[CallerCount(Count = 42)]
	[CallsUnknownMethods(Count = 15)]
	public TODBlendState GetTODBlendState()
	{
		return default(TODBlendState);
	}

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 42)]
	public float GetTODBlendPercent(TODBlendState blendState)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float GetBlendBiasWeightByWeather(WeatherStage stage)
	{
		return default(float);
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetTODBlendBiased(TODBlendState blendState, float linearResult, float weatherBlend)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetSunShadowStrength()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetElapsedHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void SetElapsedHours(float hours)
	{
	}

	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void RegisterSunShadowOverrideVolume(SunShadowOverrideVolume volume)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 2)]
	public void UnregisterSunShadowOverrideVolume(SunShadowOverrideVolume volume)
	{
	}

	[Calls(Type = typeof(Light), Member = "set_shadowStrength")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Light), Member = "set_shadows")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Light), Member = "set_shadows")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Light), Member = "set_shadowStrength")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "BlendShadowStrength")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	private void UpdateShadowStrength()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SendWeatherStateToWise(WeatherStage ws)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "WeatherNameToEnum")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static WeatherStage WeatherNameToEnum(string weatherName)
	{
		return default(WeatherStage);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void TriggerAnimation(string triggerName)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void SetHorizonCloudsBand1Renderer(Renderer r)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetHorizonCloudsBand2Renderer(Renderer r)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(HorizonCloudsBand), Member = "OnEnable")]
	[CalledBy(Type = typeof(HorizonCloudsBand), Member = "OnDisable")]
	public void SetHorizonCloudsBand3Renderer(Renderer r)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetHorizonGradRenderer(Renderer r)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void SetSkyCloudEdge1Renderer(Renderer r)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(HorizonCloudsBand), Member = "OnEnable")]
	[CalledBy(Type = typeof(HorizonCloudsBand), Member = "OnDisable")]
	public void SetSkyCloudEdge2Renderer(Renderer r)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ColorGradingSettings GetDefaultColorGradingSettings()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GodrayManager GetGodrayManager()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	public bool ApproximateColorMatch(Color a, Color b, float margin)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public UniStormWeatherSystem()
	{
	}
}
