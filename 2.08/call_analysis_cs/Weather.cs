using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using TLD.Gear;
using TLD.ModularElectrolizer;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Weather : MonoBehaviour
{
	public delegate void EnvironemntChangedEvent(bool isIndoor);

	public float m_IndoorTemperatureCelsius;

	public float m_HighTempMinCelsius;

	public float m_HighTempMaxCelsius;

	public float m_LowTempMinCelsius;

	public float m_LowTempMaxCelsius;

	public float m_BlizzardDegreesDrop;

	public float m_BlizzardDegreesChangePerSecond;

	public int m_HourWarmingBegins;

	public int m_HourCoolingBegins;

	public int m_MaxAirTemperature;

	public int m_AuroraActivationWindowStart;

	public int m_AuroraActivationWindowEnd;

	public int m_AuroraEarlyWindowProbability;

	public int m_AuroraLateWindowProbability;

	public float m_DegreesPerSecondChangeLow;

	public float m_DegreesPerSecondChangeMedium;

	public float m_DegreesPerSecondChangeHigh;

	public float m_TimeToDisplayTempWhenChanged;

	public float m_MinWindSpeedForBlowingSnow;

	public float m_BlowingSnowTransitionSeconds;

	public GameObject m_FallingSnowPrefab;

	public GameObject m_BlowingSnowPrefabLowQuality;

	public GameObject m_BlowingSnowPrefabMediumQuality;

	public GameObject m_BlowingSnowPrefabHighQuality;

	public GameObject m_BlowingSnowPrefabUltraQuality;

	public GameObject m_BlowingSnowPrefabXboxOneQuality;

	public GameObject m_BlowingSnowPrefabPS4Quality;

	private GameObject m_BlowingSnowPrefab;

	public int m_ChancesOfPickingElectrostaticFogInActivationWindow;

	public int m_ElectrostaticFogSelectionWindowStart;

	public int m_ElectrostaticFogSelectionWindowEnd;

	public int m_ElectrostaticFogActivationWindowStart;

	public int m_ElectrostaticFogActivationWindowEnd;

	public GameObject m_ToxicFogSporeFxPrefab;

	public MinMax m_MinForceX;

	public MinMax m_MinForceY;

	public MinMax m_MinForceZ;

	public MinMax m_MaxForceX;

	public MinMax m_MaxForceY;

	public MinMax m_MaxForceZ;

	public float m_SporeFxLowQuality;

	public float m_SporeFxMediumQuality;

	public float m_SporeFxHighQuality;

	public float m_SporeFxUltraQuality;

	public float m_SporeFxXboxQuality;

	public float m_SporeFxPs4Quality;

	public float m_SporeFxSwitchQuality;

	private float m_SporeFxQuality;

	private GameObject m_ToxicFogSporeFxGO;

	private ParticleSystem m_ToxicFogSporeFxComponent;

	private PanelReference<Panel_HUD> m_HUD;

	public float m_ClothingDamagePerHourInBlizzard;

	private bool _003Cm_HasCalculatedTemperature_003Ek__BackingField;

	public WeatherSetData[] m_DefaultWeatherSets;

	public List<WeatherSetData> m_WeatherSetsForScene;

	public FallingSnowPreset m_FallingSnowCurrentPreset;

	public GameObject m_FallingSnow;

	public GameObject m_BlowingSnow;

	public float m_FallingSnowEnforceLifetimeLimit;

	public ParticleSystem m_FallingSnowParticleSystem;

	public ParticleSystemRenderer m_FallingSnowParticleSystemRenderer;

	public ParticleSystem m_BlowingSnowParticleSystem;

	public float m_TimeShelteredToDisplayMessage;

	public Vector4 m_SkyboxHorizonAdjust;

	public int m_MinAirTemperature;

	public RegionOrientation[] m_RegionOrientationValues;

	public static EnvironemntChangedEvent OnEnvironmentChanged;

	public static string m_RegionFromSaveSlot;

	public static bool m_DebugWeather;

	private FallingSnowPreset[] m_FallingSnowPresets;

	private WeatherStage[] m_FallingSnowStages;

	private WeatherStage[] m_FallingSnowStagesTmp;

	private float m_FallingSnowPresetBlend;

	private Quaternion m_BlowingSnowRotation;

	private float m_BlowingSnowAlphaMultiplier;

	private bool m_WarmedWeatherState;

	private WeatherStage m_CurrentWeatherStage;

	private bool m_IsIndoors;

	private float m_BaseTemperature;

	private float m_CurrentTemperature;

	private float m_CurrentTemperatureWithoutHeatSources;

	private float m_CurrentWindChill;

	private float m_TempHigh;

	private float m_TempLow;

	private bool m_GenerateNewTempHigh;

	private bool m_GenerateNewTempLow;

	private float m_ArtificalTempIncrease;

	private TODBlendState m_LastTimeOfDay;

	private int m_BaseTemperatureAccumulatorForTimeOfDay;

	private int m_WindchillAccumulatorForTimeOfDay;

	private int m_TemperatureCountForTimeOfDay;

	private float m_PrevBodyTemp;

	private float m_NextTempCheckTime;

	private float m_LastDegreeChangePerSecondCausingMessage;

	private float m_CurrentBlizzardDegreesDrop;

	private int m_UpdateCount;

	private bool m_WarmWeatherParticleEmittersInLateUpdate;

	private float m_LastTemperatureSentToWise;

	private float m_TimeSheltered;

	private bool m_PlayedWindClothingLoop;

	private float m_LockedAirTemperature;

	private bool m_StartHasBeenCalled;

	private QualityPostFx m_CachedQuality;

	private static WeatherSaveDataProxy m_WeatherSaveDataProxy;

	private const string STORY_MODE_OVERRIDE = "_STORY";

	public bool m_HasCalculatedTemperature
	{
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(Weather), Member = "Deserialize")]
	[Calls(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Weather), Member = "SetSnowPresetBlend")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Weather), Member = "UpdateSporeFxQuality")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 32)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CalledBy(Type = typeof(Weather), Member = "Start")]
	private void UpdateSporeFxQuality()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneWeatherOverrideData), Member = "DoWeatherOverride")]
	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CalledBy(Type = typeof(Weather), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeWeatherSetsForScene()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(SceneWeatherOverrideData), Member = "DoWeatherOverride")]
	[CalledBy(Type = typeof(SceneWeatherOverride), Member = "DoWeatherOverride")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void RegisterSceneWeatherSets(WeatherSetData[] sets)
	{
	}

	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetDowngradedWeatherType")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetMoreSeriousWeatherType")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetBlendedWeatherPair")]
	public WeatherSetData ChooseWeatherSetOfType(WeatherStage reqType)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Weather), Member = "GetWeatherSetByName")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	public WeatherSetData GetCustomWeatherSet(string customTypeName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CalledBy(Type = typeof(AlmanacGridItem), Member = "SetUpGridItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	public WeatherSetData GetWeatherSetByName(string name)
	{
		return null;
	}

	[Calls(Type = typeof(Weather), Member = "RampUpBlowingSnow")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "UpdateAndMaybeSendAnalytics")]
	[Calls(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[Calls(Type = typeof(Weather), Member = "RampDownBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(Weather), Member = "UpdateFallingSnowPreset")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "UpdateSporeFxQuality")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsWindyEnoughForBlowingSnow")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "HasPlayerObject")]
	[Calls(Type = typeof(Weather), Member = "UpdateSnowEffectTransforms")]
	[Calls(Type = typeof(Weather), Member = "UpdateToxicFogSporeTransforms")]
	[Calls(Type = typeof(Weather), Member = "WarmWeatherParticleEmitters")]
	public void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "Start")]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GameObject GetFallingSnowGameObject()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FallingSnowPreset), Member = ".ctor")]
	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CallsUnknownMethods(Count = 15)]
	public void SetSnowPresetBlend(WeatherStage a, WeatherStage b, float blend, float blendTimeRemaining)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[Calls(Type = typeof(FallingSnowPreset), Member = "SetBlended")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FallingSnowPreset), Member = "Apply")]
	private void UpdateFallingSnowPreset()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "Update")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public float GetFallingSnowIntensity()
	{
		return default(float);
	}

	[Calls(Type = typeof(Weather), Member = "RampDownBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "RampUpBlowingSnow")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsWindyEnoughForBlowingSnow")]
	public void RampBlowingSnow()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "PrepareFrame")]
	[CallsUnknownMethods(Count = 5)]
	public void KillWeatherParticles()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "UpdateFallingSnowPreset")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WarmWeatherState")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	public void WarmWeather()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[Calls(Type = typeof(Weather), Member = "IsWindyEnoughForBlowingSnow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public void WarmBlowingSnow()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void SetSnowColor(Color c)
	{
	}

	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetBlowingSnowColor(Color c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSnowDirection(float heading)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSleep")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	public bool IsBlizzard()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	public bool IsDenseFog()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	public bool IsFoggy()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_crow_flyover_test")]
	[CalledBy(Type = typeof(FlyOver), Member = "CanSpawnFlyover")]
	[CalledBy(Type = typeof(Carrion), Member = "ShouldDisperseLocal")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	public bool IsSnowing()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(Wind), Member = "CalculateWindChill")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForHappySuccess")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 5)]
	public bool IsClear()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	public bool IsLightSnow()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsHeavySnow()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	public bool IsElectrostaticFog()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsGettingWet")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsGettingWet")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsGettingWet")]
	public WeatherStage GetWeatherStage()
	{
		return default(WeatherStage);
	}

	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsWeatherStatic()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public float GetBaseTemperature()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetCurrentTemperature()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCurrentTemperatureWithoutHeatSources()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CallerCount(Count = 2)]
	public float GetCurrentWindchill()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetCurrentTemperatureWithWindchill()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void AddArtificalTempIncrease(float increase)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(GenericIndoors), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableCloudParent")]
	public void ForceIndoorEnvironment()
	{
	}

	[CalledBy(Type = typeof(GenericOutdoors), Member = "Start")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableCloudParent")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void ForceOutdoorEnvironment()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	public float GetRotationDegreesForRegion(string regionName)
	{
		return default(float);
	}

	[CallerCount(Count = 118)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsIndoorEnvironment()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CharcoalItem), Member = "StartDetailSurvey")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanSurveyEnvironment()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsIndoorScene()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateEffects")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(FlareItem), Member = "Ignite")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CalledBy(Type = typeof(LightQualitySwitch), Member = "IsValidLocation")]
	[CalledBy(Type = typeof(TorchIntensity), Member = "MaybeUpdateIntensityRTPC")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(FirstPersonFlashlight), Member = "Update")]
	[CalledBy(Type = typeof(FirstPersonFlashlight), Member = "Update")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(LightQualitySwitch), Member = "IsValidLocation")]
	[CalledBy(Type = typeof(LightQualitySwitch), Member = "IsValidLocation")]
	[CalledBy(Type = typeof(LightQualitySwitch), Member = "IsValidLocation")]
	[CalledBy(Type = typeof(FlareIntensity), Member = "MaybeUpdateIntensityRTPC")]
	public bool UseOutdoorLightingForLightSources()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void LockAirTemperature(float celsius)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[Calls(Type = typeof(Weather), Member = "IsDenseFog")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(MissionIlluminationArea), Member = "IsInIlluminationArea")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 8)]
	public bool IsTooDarkForAction(ActionsToBlock actionBeingChecked)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	public bool IsFullMoon()
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(FlyOver), Member = "GetCurrentFormation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 87)]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(FlyOver), Member = "GetCurrentFormation")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlyOver), Member = "GetCurrentFormation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(WeatherSetData), Member = "GetDebugString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public static string GetDebugWeatherText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Weather), Member = "RampBlowingSnow")]
	private bool IsWindyEnoughForBlowingSnow()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RampDownAllSnow()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "RampBlowingSnow")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void RampUpBlowingSnow()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "RampBlowingSnow")]
	[CallsUnknownMethods(Count = 4)]
	private void RampDownBlowingSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWeatherSwitchStats()
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "UpdateWeatherConditions")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public string GetWeatherStageDisplayName(WeatherStage ws)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	private void UpdateTemperatureOnHUD(Panel_HUD hud)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Weather), Member = "GetMinAirTemp")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(HeatSourceManager), Member = "GetTemperatureIncrease")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInNonRuinedShelter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 1)]
	private void CalculateCurrentTemperature()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateUniStormTemperature()
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
	private void GenerateTempHigh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void GenerateTempLow()
	{
	}

	[CallerCount(Count = 0)]
	private float GetTempHigh()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private void SetTempHigh(float highTemp)
	{
	}

	[CallerCount(Count = 0)]
	private float GetTempLow()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private void SetTempLow(float lowTemp)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateBlizzardTemperatureDelta()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[Calls(Type = typeof(ParticleSystem), Member = "Simulate")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "Simulate")]
	private void WarmWeatherParticleEmitters()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WarmWeatherState")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[CallsUnknownMethods(Count = 2)]
	public void WarmWeatherState()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToWornClothing")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void ApplyClothingDamage()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	private void UpdateSnowEffectTransforms()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateToxicFogSporeTransforms()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	[CalledBy(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	public bool IsMainMenu()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsMainMenu")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 6)]
	public void MaybeCreateToxicFogSporeFx()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(Weather), Member = "IsMainMenu")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	public void SetToxicFogParameters(float minFogThreshhold, float maxFogThreshhold, float fogValue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void MaybeUpdateWiseWithCurrentTemperature()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	private float GetMinAirTemp()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static bool IsClear(WeatherStage ws)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void ToggleDownsampleWindEffect()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	public void DisableWindEffect()
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 2)]
	public void EnableWindEffect()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	private void UpdateAndMaybeSendAnalytics()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private WeatherSetData LoadAddressableCustomWeatherSet(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Weather()
	{
	}
}
