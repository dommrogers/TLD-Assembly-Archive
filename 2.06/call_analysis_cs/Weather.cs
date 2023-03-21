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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(Weather), Member = "Deserialize")]
	[Calls(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Weather), Member = "SetSnowPresetBlend")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Weather), Member = "UpdateSporeFxQuality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
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

	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(Weather), Member = "Deserialize")]
	[Calls(Type = typeof(SceneWeatherOverrideData), Member = "DoWeatherOverride")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void InitializeWeatherSetsForScene()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SceneWeatherOverrideData), Member = "DoWeatherOverride")]
	[CalledBy(Type = typeof(SceneWeatherOverride), Member = "DoWeatherOverride")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void RegisterSceneWeatherSets(WeatherSetData[] sets)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetDowngradedWeatherType")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetBlendedWeatherPair")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetMoreSeriousWeatherType")]
	public WeatherSetData ChooseWeatherSetOfType(WeatherStage reqType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(int), Member = "Parse")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CalledBy(Type = typeof(Weather), Member = "GetWeatherSetByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Weather), Member = "LoadAddressableCustomWeatherSet")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "LoadAddressableCustomWeatherSet")]
	public WeatherSetData GetCustomWeatherSet(string customTypeName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CalledBy(Type = typeof(AlmanacGridItem), Member = "SetUpGridItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 2)]
	public WeatherSetData GetWeatherSetByName(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "UpdateAndMaybeSendAnalytics")]
	[Calls(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[Calls(Type = typeof(Weather), Member = "RampUpBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "RampDownBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "UpdateFallingSnowPreset")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(Weather), Member = "UpdateSporeFxQuality")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsWindyEnoughForBlowingSnow")]
	public void Update()
	{
	}

	[Calls(Type = typeof(Weather), Member = "UpdateToxicFogSporeTransforms")]
	[Calls(Type = typeof(Weather), Member = "WarmWeatherParticleEmitters")]
	[Calls(Type = typeof(GameManager), Member = "HasPlayerObject")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "UpdateSnowEffectTransforms")]
	public void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[Calls(Type = typeof(Weather), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GameObject GetFallingSnowGameObject()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FallingSnowPreset), Member = ".ctor")]
	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallsUnknownMethods(Count = 24)]
	public void SetSnowPresetBlend(WeatherStage a, WeatherStage b, float blend, float blendTimeRemaining)
	{
	}

	[Calls(Type = typeof(FallingSnowPreset), Member = "SetBlended")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[Calls(Type = typeof(FallingSnowPreset), Member = "Apply")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	private void UpdateFallingSnowPreset()
	{
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public float GetFallingSnowIntensity()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsWindyEnoughForBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "RampDownBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "RampUpBlowingSnow")]
	public void RampBlowingSnow()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "PrepareFrame")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void KillWeatherParticles()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "WarmWeatherState")]
	[Calls(Type = typeof(Weather), Member = "UpdateFallingSnowPreset")]
	[Calls(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	public void WarmWeather()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[Calls(Type = typeof(Weather), Member = "IsWindyEnoughForBlowingSnow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	public void WarmBlowingSnow()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public void SetSnowColor(Color c)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	public void SetBlowingSnowColor(Color c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSnowDirection(float heading)
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSleep")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	public bool IsBlizzard()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsDenseFog()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	public bool IsFoggy()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CalledBy(Type = typeof(Carrion), Member = "ShouldDisperseLocal")]
	[CalledBy(Type = typeof(FlyOver), Member = "CanSpawnFlyover")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_crow_flyover_test")]
	public bool IsSnowing()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForHappySuccess")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(Wind), Member = "CalculateWindChill")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	public bool IsClear()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLightSnow()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	public bool IsHeavySnow()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsElectrostaticFog()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "IsGettingWet")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsGettingWet")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsGettingWet")]
	public WeatherStage GetWeatherStage()
	{
		return default(WeatherStage);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
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
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GenericIndoors), Member = "Start")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetCameraVignettingIndoors")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableCloudParent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	public void ForceIndoorEnvironment()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(GenericOutdoors), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableCloudParent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	public void ForceOutdoorEnvironment()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	public float GetRotationDegreesForRegion(string regionName)
	{
		return default(float);
	}

	[CallerCount(Count = 120)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsIndoorEnvironment()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "StartDetailSurvey")]
	public bool CanSurveyEnvironment()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsIndoorScene()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateEffects")]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CalledBy(Type = typeof(FlareItem), Member = "Ignite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(LightQualitySwitch), Member = "IsValidLocation")]
	[CalledBy(Type = typeof(TorchIntensity), Member = "MaybeUpdateIntensityRTPC")]
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
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 68)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(Weather), Member = "IsDenseFog")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MissionIlluminationArea), Member = "IsInIlluminationArea")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	public bool IsTooDarkForAction(ActionsToBlock actionBeingChecked)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	public bool IsFullMoon()
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsUnknownMethods(Count = 87)]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FlyOver), Member = "GetCurrentFormation")]
	[Calls(Type = typeof(FlyOver), Member = "GetCurrentFormation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlyOver), Member = "GetCurrentFormation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(WeatherSetData), Member = "GetDebugString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public static string GetDebugWeatherText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	private void UpdateWeatherSwitchStats()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "UpdateWeatherConditions")]
	public string GetWeatherStageDisplayName(WeatherStage ws)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	private void UpdateTemperatureOnHUD(Panel_HUD hud)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[Calls(Type = typeof(Weather), Member = "GetMinAirTemp")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(HeatSourceManager), Member = "GetTemperatureIncrease")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInNonRuinedShelter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	private void CalculateCurrentTemperature()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	private void UpdateUniStormTemperature()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ParticleSystem), Member = "Simulate")]
	[Calls(Type = typeof(ParticleSystem), Member = "Simulate")]
	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 5)]
	private void WarmWeatherParticleEmitters()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	public void WarmWeatherState()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToWornClothing")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void ApplyClothingDamage()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateSnowEffectTransforms()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
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

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsMainMenu")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void MaybeCreateToxicFogSporeFx()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(Weather), Member = "IsMainMenu")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	public void SetToxicFogParameters(float minFogThreshhold, float maxFogThreshhold, float fogValue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void MaybeUpdateWiseWithCurrentTemperature()
	{
	}

	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	public void ToggleDownsampleWindEffect()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallsUnknownMethods(Count = 2)]
	public void DisableWindEffect()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	public void EnableWindEffect()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void UpdateAndMaybeSendAnalytics()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[CalledBy(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	private WeatherSetData LoadAddressableCustomWeatherSet(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 31)]
	public Weather()
	{
	}
}
