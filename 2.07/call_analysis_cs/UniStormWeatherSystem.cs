using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Electrostatic;
using TLD.Events;
using TLD.Scenes;
using TLD.Stats;
using TLD.UI.Generics;
using UnityEngine;

public class UniStormWeatherSystem : MonoBehaviour, IElectrostaticSource
{
	private class RegionTimeAccumulator
	{
		public SceneSet m_Region;

		public StatID m_Stat;

		public float m_ElapsedHours;

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
		[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
		public void AddTime(float deltaHours, float threshold)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public RegionTimeAccumulator()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<WeatherStatesData> _003C_003E9__142_0;

		public static Predicate<WeatherStatesData> _003C_003E9__151_0;

		public static Predicate<WeatherStatesData> _003C_003E9__152_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal bool _003CAwake_003Eb__142_0(WeatherStatesData x)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetClearNightFogDensity_003Eb__151_0(WeatherStatesData x)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CSetToxicFogDensity_003Eb__152_0(WeatherStatesData x)
		{
			return default(bool);
		}
	}

	public WeatherStageChangeEvent m_WeatherStageChangeEvent;

	private const float SUN_SIZE = 0.1f;

	public WeatherStatesData[] m_WeatherStateConfigs;

	public TODStateData[] m_SpecialTODStates;

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

	private PanelReference<Panel_Loading> m_Loading;

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

	private bool m_Indoors;

	private float m_ElapsedHours;

	private float m_ElapsedHoursAccumulator;

	private float m_ElapsedHoursIndoorsAccumulator;

	private float m_ElapsedHoursOutdoorsAccumulator;

	private float m_ElapsedHoursAsleepAccumulator;

	private float m_ElapsedHoursAsleepOutdoorsAccumulator;

	private float m_ElapsedHoursAwakeAccumulator;

	private List<RegionTimeAccumulator> m_RegionTimes;

	private bool m_LastFrameWasOutside;

	private bool m_LastFrameWasNight;

	private bool m_OutsideSinceBeginningOfNight;

	private bool m_UseMoonColourColorOverride;

	private float m_WeatherTransitionTime;

	private ActiveEnvironment m_ActiveEnvironment;

	public SpecialTODState m_RequestedSpecialTODState;

	private SpecialTODState m_LastSpecialTODState;

	private SceneSet m_CurrentRegion;

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
	public TODStateData GetActiveTODState()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "InstantiateUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(WeatherParticleManager), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	public void Init()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDisable()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "Reset")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void InitializeForScene()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "InitializeForScene")]
	[CallsUnknownMethods(Count = 1)]
	public void InitializeAfterSceneLoad()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsPaused()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "WarmWeatherState")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	public void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetFogDensity")]
	[CallsUnknownMethods(Count = 7)]
	public float GetClearNightFogDensity()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetFogDensity")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetToxicFogDensity(float fogDensity)
	{
	}

	[CallerCount(Count = 0)]
	public float GetOriginalNightToxicFogDensity()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "CalculateWeatherChangeAuroraIntensity")]
	public float GetElectroStaticActive()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetElectrostaticStrength()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraValue")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDusk")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetElectroStaticActive")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "CalculateWeatherChangeAuroraIntensity")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	public float GetClearAuroraIntensity()
	{
		return default(float);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private float GetElectrostaticFogIntensity()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetElectroStaticActive")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	private float CalculateWeatherChangeAuroraIntensity(WeatherStage auroraWeatherStage)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(RegionTimeAccumulator), Member = "AddTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	private void UpdateTimeStats(float timeDeltaHours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[CallsUnknownMethods(Count = 1)]
	public void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void DoLateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[CallsUnknownMethods(Count = 1)]
	public void DoLateUpdate_part1()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part2")]
	[CallsUnknownMethods(Count = 3)]
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

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[CallerCount(Count = 0)]
	public void SetNormalizedTime(float time)
	{
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallerCount(Count = 0)]
	public void SetNormalizedTime(float time, bool forceUpdate)
	{
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "InstantiateUniStorm")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "WarmWeatherState")]
	[CallsUnknownMethods(Count = 9)]
	public void UpdateSunTransform()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetAmbientLight(Color c)
	{
	}

	[CallerCount(Count = 0)]
	public void LockAmbientLight(bool lockAmbient)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CallsUnknownMethods(Count = 3)]
	public void EnableWeatherSystems(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EnableCloudParent(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WeatherStage GetWeatherStage()
	{
		return default(WeatherStage);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameEvent), Member = "Post")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[CallsUnknownMethods(Count = 1)]
	private void ChangeWeatherState(WeatherStage current, WeatherStage previous)
	{
	}

	[CalledBy(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "ChangeWeatherState")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UpdateDecalProjectorLifeTimes")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SendWeatherStateToWise")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Weather), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public void SetWeatherStage(WeatherStage ws, float transitionTime, bool force = false)
	{
	}

	[CalledBy(Type = typeof(WeatherSetStage), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherSetStage), Member = "Activate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UpdateDecalProjectorLifeTimes")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "ChangeWeatherState")]
	public void SetWeatherStateAndBlendDirectly(WeatherStage ws, WeatherStage prevWS, float elapsedGameTimeInStage, float transitionGameTimeForStage)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeatherState")]
	[CallsUnknownMethods(Count = 1)]
	public void WarmWeatherState()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetMoonPhaseIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetMoonPhaseIndex(int phase)
	{
	}

	[CallerCount(Count = 0)]
	public float GetMoonIntensityScalar()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetMoonPhase()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
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
	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	public void SetAuroraAlpha(float alpha)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsNightOrNightBlend()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(HighlightFog), Member = "UpdateTOD")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MultiplyNighttimeParticleOpacity), Member = "Update")]
	[CalledBy(Type = typeof(GodrayManager), Member = "Update")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "UpdateTOD")]
	public bool IsNight()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsNightWithExtendedHours(float extendedHours)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsMorning()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsAfternoon()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsNightPreMidnight()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool IsNightPostMidnight()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsDusk()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsDawn()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool IsDayWithExtendedHours(float extendedHours)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDawnHourTime()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsEarlyNightWindowForAuroraActivation()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLateNightWindowForAuroraActivation()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsInsideElectrostaticFogSelectionWindow()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsInsideElectrostaticFogActivationWindow()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDawnTime()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetNightStartTime()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateForDusk")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "GetProgressDusk")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateForDusk")]
	public float GetProgressDusk()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "GetProgressDawn")]
	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateForDawn")]
	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateForDawn")]
	[CallsUnknownMethods(Count = 2)]
	public float GetProgressDawn()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NPCLightingRig), Member = "Update")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[CalledBy(Type = typeof(TransformAtNight), Member = "Update")]
	[CalledBy(Type = typeof(NPCLightingRig), Member = "Update")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	public float GetNightPercentage()
	{
		return default(float);
	}

	[CallerCount(Count = 38)]
	[CallsUnknownMethods(Count = 2)]
	public TODBlendState GetTODBlendState()
	{
		return default(TODBlendState);
	}

	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 2)]
	public float GetTODBlendPercent(TODBlendState blendState)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float GetBlendBiasWeightByWeather(WeatherStage stage)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetTODBlendBiased(TODBlendState blendState, float linearResult, float weatherBlend)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 4)]
	public void RegisterSunShadowOverrideVolume(SunShadowOverrideVolume volume)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "OnDisable")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "OnTriggerExit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void UnregisterSunShadowOverrideVolume(SunShadowOverrideVolume volume)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "GetBlendFactor")]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateShadowStrength()
	{
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CalledBy(Type = typeof(WeatherSetStage), Member = "Activate")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	public static void SendWeatherStateToWise(WeatherStage ws)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lock_weather_instant")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lock_weather")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "WeatherNameToEnum")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static WeatherStage WeatherNameToEnum(string weatherName)
	{
		return default(WeatherStage);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void TriggerAnimation(string triggerName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetHorizonCloudsBand1Renderer(Renderer r)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(HorizonCloudsBand), Member = "OnEnable")]
	[CalledBy(Type = typeof(HorizonCloudsBand), Member = "OnDisable")]
	public void SetHorizonCloudsBand2Renderer(Renderer r)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(HorizonCloudsBand), Member = "OnEnable")]
	[CalledBy(Type = typeof(HorizonCloudsBand), Member = "OnDisable")]
	public void SetHorizonCloudsBand3Renderer(Renderer r)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void SetHorizonGradRenderer(Renderer r)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public void SetSkyCloudEdge1Renderer(Renderer r)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
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

	[CallerCount(Count = 0)]
	public bool ApproximateColorMatch(Color a, Color b, float margin)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private int GetIndexOfWeatherStage(WeatherStage stage)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public UniStormWeatherSystem()
	{
	}
}
