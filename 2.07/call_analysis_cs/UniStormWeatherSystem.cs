using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Electrostatic;
using TLD.Events;
using TLD.Scenes;
using TLD.Stats;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class UniStormWeatherSystem : MonoBehaviour, IElectrostaticSource
{
	private class RegionTimeAccumulator
	{
		public SceneSet m_Region;

		public StatID m_Stat;

		public float m_ElapsedHours;

		[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CAwake_003Eb__142_0(WeatherStatesData x)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetClearNightFogDensity_003Eb__151_0(WeatherStatesData x)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CSetToxicFogDensity_003Eb__152_0(WeatherStatesData x)
		{
			return false;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "InstantiateUniStorm")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(WeatherParticleManager), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 17)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	private bool IsPaused()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "WarmWeatherState")]
	[CallerCount(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetFogDensity")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public float GetClearNightFogDensity()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetFogDensity")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void SetToxicFogDensity(float fogDensity)
	{
	}

	[CallerCount(Count = 0)]
	public float GetOriginalNightToxicFogDensity()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "CalculateWeatherChangeAuroraIntensity")]
	public float GetElectroStaticActive()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetElectrostaticStrength()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraValue")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetElectroStaticActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "CalculateWeatherChangeAuroraIntensity")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDusk")]
	[CallsUnknownMethods(Count = 3)]
	public float GetClearAuroraIntensity()
	{
		return 0f;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private float GetElectrostaticFogIntensity()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetElectroStaticActive")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	[CallerCount(Count = 2)]
	private float CalculateWeatherChangeAuroraIntensity(WeatherStage auroraWeatherStage)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RegionTimeAccumulator), Member = "AddTime")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateTimeStats(float timeDeltaHours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	public void SetNormalizedTime(float time)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	public void SetNormalizedTime(float time, bool forceUpdate)
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "InstantiateUniStorm")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "WarmWeatherState")]
	[CallerCount(Count = 6)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void UpdateSunTransform()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetAmbientLight(Color c)
	{
	}

	[CallerCount(Count = 0)]
	public void LockAmbientLight(bool lockAmbient)
	{
	}

	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void EnableWeatherSystems(bool enable)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameEvent), Member = "Post")]
	[CallsUnknownMethods(Count = 1)]
	private void ChangeWeatherState(WeatherStage current, WeatherStage previous)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Deserialize")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(TypeFullName = "LightingCapture.<CaptureFrame>d__15", Member = "MoveNext")]
	[CalledBy(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "ChangeWeatherState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SendWeatherStateToWise")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UpdateDecalProjectorLifeTimes")]
	[CallsUnknownMethods(Count = 2)]
	public void SetWeatherStage(WeatherStage ws, float transitionTime, bool force = false)
	{
	}

	[CalledBy(Type = typeof(WeatherSetStage), Member = "Activate")]
	[CalledBy(Type = typeof(WeatherSetStage), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UpdateDecalProjectorLifeTimes")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "ChangeWeatherState")]
	[CallsUnknownMethods(Count = 2)]
	public void SetWeatherStateAndBlendDirectly(WeatherStage ws, WeatherStage prevWS, float elapsedGameTimeInStage, float transitionGameTimeForStage)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeatherState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[CallsUnknownMethods(Count = 1)]
	public void WarmWeatherState()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetMoonPhaseIndex()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetMoonPhaseIndex(int phase)
	{
	}

	[CallerCount(Count = 0)]
	public float GetMoonIntensityScalar()
	{
		return 0f;
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
		return false;
	}

	[CallerCount(Count = 0)]
	public void SetMoonColourOverride(bool enableOverride)
	{
	}

	[CallerCount(Count = 0)]
	public void SetMoonColourOverrideColour(Color newColor)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetDayNumber()
	{
		return 0;
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

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsNightOrNightBlend()
	{
		return false;
	}

	[CalledBy(Type = typeof(GodrayManager), Member = "Update")]
	[CalledBy(Type = typeof(HighlightFog), Member = "UpdateTOD")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "UpdateTOD")]
	[CalledBy(Type = typeof(MultiplyNighttimeParticleOpacity), Member = "Update")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsNight()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsNightWithExtendedHours(float extendedHours)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsMorning()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsAfternoon()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsNightPreMidnight()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsNightPostMidnight()
	{
		return false;
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsDusk()
	{
		return false;
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsDawn()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsDayWithExtendedHours(float extendedHours)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDawnHourTime()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsEarlyNightWindowForAuroraActivation()
	{
		return false;
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLateNightWindowForAuroraActivation()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsInsideElectrostaticFogSelectionWindow()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsInsideElectrostaticFogActivationWindow()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDawnTime()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetNightStartTime()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "GetProgressDusk")]
	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateForDusk")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public float GetProgressDusk()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "GetProgressDawn")]
	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateForDawn")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public float GetProgressDawn()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[CalledBy(Type = typeof(NPCLightingRig), Member = "Update")]
	[CalledBy(Type = typeof(TransformAtNight), Member = "Update")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CallsUnknownMethods(Count = 2)]
	public float GetNightPercentage()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateIntensities")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "GetTimeOfDayIntensity")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "GetTODBlendState")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceMiddayObject")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "UpdateMiddayObject")]
	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateAndMaybeSendAnalytics")]
	[CalledBy(Type = typeof(HighlightFog), Member = "UpdateTOD")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "UpdateTOD")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "GetTimeOfDayIntensity")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "MiddayIntensities")]
	[CalledBy(Type = typeof(LightTOD), Member = "Update")]
	[CalledBy(Type = typeof(LightTOD), Member = "UpdateTOD")]
	[CalledBy(Type = typeof(MultiplyNighttimeParticleOpacity), Member = "Update")]
	[CalledBy(Type = typeof(Rainbow), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetNightPercentage")]
	[CallerCount(Count = 38)]
	[CallsUnknownMethods(Count = 2)]
	public TODBlendState GetTODBlendState()
	{
		return default(TODBlendState);
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateIntensities")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "GetTimeOfDayIntensity")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "GetTODBlendPercent")]
	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CalledBy(Type = typeof(HighlightFog), Member = "UpdateTOD")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "UpdateTOD")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "GetTimeOfDayIntensity")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "MiddayIntensities")]
	[CalledBy(Type = typeof(LightTOD), Member = "Update")]
	[CalledBy(Type = typeof(LightTOD), Member = "UpdateTOD")]
	[CalledBy(Type = typeof(MultiplyNighttimeParticleOpacity), Member = "Update")]
	[CalledBy(Type = typeof(Rainbow), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "GetNightPercentage")]
	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 2)]
	public float GetTODBlendPercent(TODBlendState blendState)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float GetBlendBiasWeightByWeather(WeatherStage stage)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetTODBlendBiased(TODBlendState blendState, float linearResult, float weatherBlend)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetSunShadowStrength()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetElapsedHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void SetElapsedHours(float hours)
	{
	}

	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "OnTriggerEnter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void RegisterSunShadowOverrideVolume(SunShadowOverrideVolume volume)
	{
	}

	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterSunShadowOverrideVolume(SunShadowOverrideVolume volume)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "GetBlendFactor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	private void UpdateShadowStrength()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(WeatherSetStage), Member = "Activate")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CallerCount(Count = 2)]
	public static void SendWeatherStateToWise(WeatherStage ws)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lock_weather")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lock_weather_instant")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "WeatherNameToEnum")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetHorizonCloudsBand1Renderer(Renderer r)
	{
	}

	[CalledBy(Type = typeof(HorizonCloudsBand), Member = "OnEnable")]
	[CalledBy(Type = typeof(HorizonCloudsBand), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	public void SetHorizonCloudsBand2Renderer(Renderer r)
	{
	}

	[CalledBy(Type = typeof(HorizonCloudsBand), Member = "OnEnable")]
	[CalledBy(Type = typeof(HorizonCloudsBand), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	public void SetHorizonCloudsBand3Renderer(Renderer r)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int GetIndexOfWeatherStage(WeatherStage stage)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public UniStormWeatherSystem()
	{
	}
}
