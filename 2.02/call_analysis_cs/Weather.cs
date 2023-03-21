using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using SpecialEvents;
using UnityEngine;
using UnityEngine.SceneManagement;

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

	public float m_ClothingDamagePerHourInBlizzard;

	private bool _003Cm_HasCalculatedTemperature_003Ek__BackingField;

	public WeatherSet[] m_DefaultWeatherSets;

	public List<WeatherSet> m_WeatherSetsForScene;

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
		[DeduplicatedMethod]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Weather), Member = "UpdateSporeFxQuality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Weather), Member = "SetSnowPresetBlend")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Weather), Member = "GetInstancedWeatherSet")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsRestoreInProgress")]
	[Calls(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 72)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateSporeFxQuality()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CalledBy(Type = typeof(Weather), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 7)]
	private void InitializeWeatherSetsForScene()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybeLoadOverrideForced(string baseName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybeLoadOverrideForHardcodedLocation(string baseName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybeLoadOverrideForIndoors(string baseName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool MaybeLoadOverrideForRegion(string baseName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybeLoadOverrideForScene(string baseName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpecialEvent), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybeLoadOverrideForEvent(string baseName)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private bool MaybeLoadOverrideForChallenge(string baseName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForced")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForHardcodedLocation")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForIndoors")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForRegion")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForScene")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForEvent")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(SceneWeatherOverride), Member = "DoWeatherOverride")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool TryLoadOverridePrefabFromPath(string path)
	{
		return false;
	}

	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CalledBy(Type = typeof(Weather), Member = "RegisterSceneWeatherSets")]
	[CalledBy(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[CalledBy(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[CalledBy(Type = typeof(Weather), Member = "GetWeatherSetByName")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 25)]
	public WeatherSet GetInstancedWeatherSet(GameObject prefab, bool justAdd = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(SceneWeatherOverride), Member = "DoWeatherOverride")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(Weather), Member = "GetInstancedWeatherSet")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public void RegisterSceneWeatherSets(WeatherSet[] sets)
	{
	}

	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "GetInstancedWeatherSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	public WeatherSet ChooseWeatherSetOfType(WeatherStage reqType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Weather), Member = "GetWeatherSetByName")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Weather), Member = "GetInstancedWeatherSet")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "ParseInt32")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 97)]
	public WeatherSet GetCustomWeatherSet(string customTypeName)
	{
		return null;
	}

	[CalledBy(Type = typeof(AlmanacGridItem), Member = "SetUpGridItem")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Weather), Member = "GetInstancedWeatherSet")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 21)]
	public WeatherSet GetWeatherSetByName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(Weather), Member = "UpdateSporeFxQuality")]
	[Calls(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Weather), Member = "UpdateFallingSnowPreset")]
	[Calls(Type = typeof(Weather), Member = "IsWindyEnoughForBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "RampDownBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "RampUpBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[Calls(Type = typeof(Weather), Member = "UpdateBlizzardTemperatureDelta")]
	[Calls(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[Calls(Type = typeof(Weather), Member = "UpdateAndMaybeSendAnalytics")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "HasPlayerObject")]
	[Calls(Type = typeof(Weather), Member = "UpdateSnowEffectTransforms")]
	[Calls(Type = typeof(Weather), Member = "UpdateToxicFogSporeTransforms")]
	[Calls(Type = typeof(Weather), Member = "WarmWeatherParticleEmitters")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FallingSnowPreset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 55)]
	public void SetSnowPresetBlend(WeatherStage a, WeatherStage b, float blend, float blendTimeRemaining)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FallingSnowPreset), Member = "SetBlended")]
	[Calls(Type = typeof(FallingSnowPreset), Member = "Apply")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateFallingSnowPreset()
	{
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "Update")]
	[CalledBy(Type = typeof(SnowPlaneParticles), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetSnowColor(Color c)
	{
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetBlowingSnowColor(Color c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetSnowDirection(float heading)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSleep")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "GetHoursDaylightString")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateBlizzardTemperatureDelta")]
	[CalledBy(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(Wind), Member = "MaybeChangePhase")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CalledBy(Type = typeof(LeanTo), Member = "Update")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsBlizzard()
	{
		return false;
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "GetHoursDaylightString")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsDenseFog()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsClear()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLightSnow()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsHeavySnow()
	{
		return false;
	}

	[CalledBy(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[CalledBy(Type = typeof(Weather), Member = "Serialize")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsGettingWet")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetWetnessIncreasePerHour")]
	[CalledBy(TypeFullName = "InternalUserReport.<>c__DisplayClass7_0", Member = "<Send>b__1")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public WeatherStage GetWeatherStage()
	{
		return default(WeatherStage);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	public float GetCurrentTemperatureWithoutHeatSources()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CalledBy(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetCurrentWindchill()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(TimeOfDay), Member = "SetCameraVignettingIndoors")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 41)]
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
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 39)]
	public void ForceOutdoorEnvironment()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 5)]
	public float GetRotationDegreesForRegion(string regionName)
	{
		return 0f;
	}

	[CallerCount(Count = 116)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool IsIndoorEnvironment()
	{
		return false;
	}

	[DeduplicatedMethod]
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
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateEffects")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
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
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionIlluminationArea), Member = "IsInIlluminationArea")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsDenseFog")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 48)]
	public bool IsTooDarkForAction(ActionsToBlock actionBeingChecked)
	{
		return false;
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(WeatherSet), Member = "GetDebugString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraElectrolyzerFadeRatio")]
	[Calls(Type = typeof(FlyOver), Member = "GetCurrentFormation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "Magnitude")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 109)]
	public static string GetDebugWeatherText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "RampBlowingSnow")]
	[CalledBy(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void RampUpBlowingSnow()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "RampBlowingSnow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void RampDownBlowingSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWeatherSwitchStats()
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "UpdateWeatherConditions")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetWeatherStageDisplayName(WeatherStage ws)
	{
		return null;
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 36)]
	private void UpdateTemperatureOnHUD()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInNonRuinedShelter")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetOutdoorTempDropCelcius")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(HeatSourceManager), Member = "GetTemperatureIncrease")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Weather), Member = "GetMinAirTemp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 40)]
	private void CalculateCurrentTemperature()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void WarmWeatherState()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToWornClothing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void ApplyClothingDamage()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 21)]
	private void UpdateSnowEffectTransforms()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 17)]
	private void UpdateToxicFogSporeTransforms()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	[CalledBy(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsMainMenu()
	{
		return false;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsMainMenu")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void MaybeCreateToxicFogSporeFx()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(Weather), Member = "IsMainMenu")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 28)]
	public void SetToxicFogParameters(float minFogThreshhold, float maxFogThreshhold, float fogValue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeUpdateWiseWithCurrentTemperature()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
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
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	private void UpdateAndMaybeSendAnalytics()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 42)]
	public Weather()
	{
	}
}
