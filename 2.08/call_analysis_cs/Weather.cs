using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using TLD.AddressableAssets;
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
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(Weather), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(Weather), Member = "UpdateSporeFxQuality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Weather), Member = "SetSnowPresetBlend")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 32)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateSporeFxQuality()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CalledBy(Type = typeof(Weather), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneWeatherOverrideData), Member = "DoWeatherOverride")]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeWeatherSetsForScene()
	{
	}

	[CalledBy(Type = typeof(SceneWeatherOverride), Member = "DoWeatherOverride")]
	[CalledBy(Type = typeof(SceneWeatherOverrideData), Member = "DoWeatherOverride")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void RegisterSceneWeatherSets(WeatherSetData[] sets)
	{
	}

	[CalledBy(Type = typeof(WeatherSetData), Member = "GetBlendedWeatherPair")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetDowngradedWeatherType")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetMoreSeriousWeatherType")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CallerCount(Count = 7)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public WeatherSetData ChooseWeatherSetOfType(WeatherStage reqType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Weather), Member = "GetWeatherSetByName")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Weather), Member = "LoadAddressableCustomWeatherSet")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[Calls(Type = typeof(int), Member = "Parse")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 35)]
	public WeatherSetData GetCustomWeatherSet(string customTypeName)
	{
		return null;
	}

	[CalledBy(Type = typeof(AlmanacGridItem), Member = "SetUpGridItem")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public WeatherSetData GetWeatherSetByName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(Weather), Member = "UpdateSporeFxQuality")]
	[Calls(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Weather), Member = "UpdateFallingSnowPreset")]
	[Calls(Type = typeof(Weather), Member = "IsWindyEnoughForBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "RampDownBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "RampUpBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[Calls(Type = typeof(Weather), Member = "UpdateAndMaybeSendAnalytics")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
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

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[Calls(Type = typeof(Weather), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GameObject GetFallingSnowGameObject()
	{
		return null;
	}

	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FallingSnowPreset), Member = ".ctor")]
	[CallsUnknownMethods(Count = 15)]
	public void SetSnowPresetBlend(WeatherStage a, WeatherStage b, float blend, float blendTimeRemaining)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FallingSnowPreset), Member = "SetBlended")]
	[Calls(Type = typeof(FallingSnowPreset), Member = "Apply")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateFallingSnowPreset()
	{
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "Update")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Update")]
	[CalledBy(Type = typeof(SnowPlaneParticles), Member = "LateUpdate")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetFallingSnowIntensity()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsWindyEnoughForBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "RampDownBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "RampUpBlowingSnow")]
	public void RampBlowingSnow()
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "PrepareFrame")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void KillWeatherParticles()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WarmWeatherState")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Weather), Member = "UpdateFallingSnowPreset")]
	[Calls(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[CallsUnknownMethods(Count = 2)]
	public void WarmWeather()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsWindyEnoughForBlowingSnow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void WarmBlowingSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetSnowColor(Color c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetBlowingSnowColor(Color c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSnowDirection(float heading)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSleep")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsBlizzard()
	{
		return false;
	}

	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsDenseFog()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsFoggy()
	{
		return false;
	}

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CalledBy(Type = typeof(Carrion), Member = "ShouldDisperseLocal")]
	[CalledBy(Type = typeof(FlyOver), Member = "CanSpawnFlyover")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_crow_flyover_test")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSnowing()
	{
		return false;
	}

	[CalledBy(Type = typeof(Wind), Member = "CalculateWindChill")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForHappySuccess")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsClear()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLightSnow()
	{
		return false;
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsHeavySnow()
	{
		return false;
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsElectrostaticFog()
	{
		return false;
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "IsGettingWet")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public WeatherStage GetWeatherStage()
	{
		return default(WeatherStage);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsWeatherStatic()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public float GetBaseTemperature()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetCurrentTemperature()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCurrentTemperatureWithoutHeatSources()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CalledBy(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public float GetCurrentWindchill()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetCurrentTemperatureWithWindchill()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void AddArtificalTempIncrease(float increase)
	{
	}

	[CalledBy(Type = typeof(GenericIndoors), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableCloudParent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public void ForceIndoorEnvironment()
	{
	}

	[CalledBy(Type = typeof(GenericOutdoors), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableCloudParent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public void ForceOutdoorEnvironment()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	public float GetRotationDegreesForRegion(string regionName)
	{
		return 0f;
	}

	[CallerCount(Count = 118)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsIndoorEnvironment()
	{
		return false;
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "StartDetailSurvey")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanSurveyEnvironment()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsIndoorScene()
	{
		return false;
	}

	[CalledBy(Type = typeof(FirstPersonFlashlight), Member = "Update")]
	[CalledBy(Type = typeof(FlareIntensity), Member = "MaybeUpdateIntensityRTPC")]
	[CalledBy(Type = typeof(LightQualitySwitch), Member = "IsValidLocation")]
	[CalledBy(Type = typeof(TorchIntensity), Member = "MaybeUpdateIntensityRTPC")]
	[CalledBy(Type = typeof(FlareItem), Member = "Ignite")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateEffects")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 1)]
	public bool UseOutdoorLightingForLightSources()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void LockAirTemperature(float celsius)
	{
	}

	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionIlluminationArea), Member = "IsInIlluminationArea")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsDenseFog")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 31)]
	public bool IsTooDarkForAction(ActionsToBlock actionBeingChecked)
	{
		return false;
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsFullMoon()
	{
		return false;
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(WeatherSetData), Member = "GetDebugString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(FlyOver), Member = "GetCurrentFormation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 84)]
	public static string GetDebugWeatherText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "RampBlowingSnow")]
	[CalledBy(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsWindyEnoughForBlowingSnow()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RampDownAllSnow()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "RampBlowingSnow")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void RampUpBlowingSnow()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "RampBlowingSnow")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "UpdateWeatherConditions")]
	[CallerCount(Count = 2)]
	public string GetWeatherStageDisplayName(WeatherStage ws)
	{
		return null;
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateTemperatureOnHUD(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInNonRuinedShelter")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(HeatSourceManager), Member = "GetTemperatureIncrease")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Weather), Member = "GetMinAirTemp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void CalculateCurrentTemperature()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
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
		return 0f;
	}

	[CallerCount(Count = 0)]
	private void SetTempHigh(float highTemp)
	{
	}

	[CallerCount(Count = 0)]
	private float GetTempLow()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private void SetTempLow(float lowTemp)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateBlizzardTemperatureDelta()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "Simulate")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void WarmWeatherParticleEmitters()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WarmWeatherState")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[CallsUnknownMethods(Count = 2)]
	public void WarmWeatherState()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToWornClothing")]
	[CallsUnknownMethods(Count = 4)]
	private void ApplyClothingDamage()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateSnowEffectTransforms()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateToxicFogSporeTransforms()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	[CalledBy(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[CallerCount(Count = 2)]
	public bool IsMainMenu()
	{
		return false;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsMainMenu")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void MaybeCreateToxicFogSporeFx()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Weather), Member = "IsMainMenu")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	public void SetToxicFogParameters(float minFogThreshhold, float maxFogThreshhold, float fogValue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void MaybeUpdateWiseWithCurrentTemperature()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private float GetMinAirTemp()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static bool IsClear(WeatherStage ws)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void ToggleDownsampleWindEffect()
	{
	}

	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void DisableWindEffect()
	{
	}

	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableWindEffect()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateAndMaybeSendAnalytics()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AssetHelper), Member = "ValidateKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	private WeatherSetData LoadAddressableCustomWeatherSet(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Weather()
	{
	}
}
