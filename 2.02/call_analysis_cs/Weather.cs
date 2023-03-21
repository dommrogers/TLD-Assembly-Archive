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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallsUnknownMethods(Count = 72)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(Weather), Member = "Deserialize")]
	[Calls(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsRestoreInProgress")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Weather), Member = "SetSnowPresetBlend")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Weather), Member = "GetInstancedWeatherSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Weather), Member = "UpdateSporeFxQuality")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateSporeFxQuality()
	{
	}

	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(Weather), Member = "Deserialize")]
	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 3)]
	private void InitializeWeatherSetsForScene()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private bool MaybeLoadOverrideForced(string baseName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybeLoadOverrideForHardcodedLocation(string baseName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	private bool MaybeLoadOverrideForIndoors(string baseName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	private bool MaybeLoadOverrideForRegion(string baseName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybeLoadOverrideForScene(string baseName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "TryLoadOverridePrefabFromPath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpecialEvent), Member = "IsCurrentExperienceMode")]
	private bool MaybeLoadOverrideForEvent(string baseName)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private bool MaybeLoadOverrideForChallenge(string baseName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CalledBy(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CalledBy(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForced")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForHardcodedLocation")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForRegion")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForScene")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForEvent")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForIndoors")]
	[CalledBy(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CalledBy(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SceneWeatherOverride), Member = "DoWeatherOverride")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	private bool TryLoadOverridePrefabFromPath(string path)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(Weather), Member = "RegisterSceneWeatherSets")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[CalledBy(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[CalledBy(Type = typeof(Weather), Member = "GetWeatherSetByName")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public WeatherSet GetInstancedWeatherSet(GameObject prefab, bool justAdd = false)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Weather), Member = "GetInstancedWeatherSet")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(SceneWeatherOverride), Member = "DoWeatherOverride")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 20)]
	public void RegisterSceneWeatherSets(WeatherSet[] sets)
	{
	}

	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[Calls(Type = typeof(Weather), Member = "GetInstancedWeatherSet")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Weather), Member = "GetInstancedWeatherSet")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public WeatherSet ChooseWeatherSetOfType(WeatherStage reqType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 97)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(Weather), Member = "GetWeatherSetByName")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.Number), Member = "ParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(Weather), Member = "GetInstancedWeatherSet")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public WeatherSet GetCustomWeatherSet(string customTypeName)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CalledBy(Type = typeof(AlmanacGridItem), Member = "SetUpGridItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "GetInstancedWeatherSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public WeatherSet GetWeatherSetByName(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Weather), Member = "RampUpBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "UpdateBlizzardTemperatureDelta")]
	[Calls(Type = typeof(Weather), Member = "RampDownBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[Calls(Type = typeof(Weather), Member = "UpdateAndMaybeSendAnalytics")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "IsWindyEnoughForBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(Weather), Member = "UpdateFallingSnowPreset")]
	[Calls(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(Weather), Member = "UpdateSporeFxQuality")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "HasPlayerObject")]
	[Calls(Type = typeof(Weather), Member = "UpdateSnowEffectTransforms")]
	[Calls(Type = typeof(Weather), Member = "UpdateToxicFogSporeTransforms")]
	[Calls(Type = typeof(Weather), Member = "WarmWeatherParticleEmitters")]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[Calls(Type = typeof(Weather), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
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
	[CallsUnknownMethods(Count = 55)]
	[Calls(Type = typeof(FallingSnowPreset), Member = ".ctor")]
	[Calls(Type = typeof(FallingSnowPreset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	public void SetSnowPresetBlend(WeatherStage a, WeatherStage b, float blend, float blendTimeRemaining)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FallingSnowPreset), Member = "SetBlended")]
	[Calls(Type = typeof(FallingSnowPreset), Member = "Apply")]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateFallingSnowPreset()
	{
	}

	[CalledBy(Type = typeof(SnowPlaneParticles), Member = "LateUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "Update")]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "PrepareFrame")]
	[CallsUnknownMethods(Count = 5)]
	public void KillWeatherParticles()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[Calls(Type = typeof(Weather), Member = "UpdateFallingSnowPreset")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WarmWeatherState")]
	public void WarmWeather()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsWindyEnoughForBlowingSnow")]
	public void WarmBlowingSnow()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetSnowColor(Color c)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public void SetBlowingSnowColor(Color c)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetSnowDirection(float heading)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CalledBy(Type = typeof(LeanTo), Member = "Update")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(Wind), Member = "MaybeChangePhase")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Weather), Member = "UpdateBlizzardTemperatureDelta")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "GetHoursDaylightString")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSleep")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	public bool IsBlizzard()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "GetHoursDaylightString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	public bool IsDenseFog()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsFoggy()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_crow_flyover_test")]
	[CalledBy(Type = typeof(FlyOver), Member = "CanSpawnFlyover")]
	[CalledBy(Type = typeof(Carrion), Member = "ShouldDisperseLocal")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	public bool IsSnowing()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForHappySuccess")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Wind), Member = "CalculateWindChill")]
	[CallerCount(Count = 5)]
	public bool IsClear()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLightSnow()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsHeavySnow()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "IsGettingWet")]
	[CalledBy(Type = typeof(InternalUserReport._003C_003Ec__DisplayClass7_0), Member = "<Send>b__1")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetWetnessIncreasePerHour")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsGettingWet")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Weather), Member = "Serialize")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsGettingWet")]
	public WeatherStage GetWeatherStage()
	{
		return default(WeatherStage);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
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

	[CallerCount(Count = 0)]
	public float GetCurrentTemperatureWithoutHeatSources()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CalledBy(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CallsUnknownMethods(Count = 2)]
	public float GetCurrentWindchill()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetCurrentTemperatureWithWindchill()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void AddArtificalTempIncrease(float increase)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetCameraVignettingIndoors")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[CalledBy(Type = typeof(GenericIndoors), Member = "Start")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableCloudParent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void ForceIndoorEnvironment()
	{
	}

	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[CalledBy(Type = typeof(GenericOutdoors), Member = "Start")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableCloudParent")]
	public void ForceOutdoorEnvironment()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 5)]
	public float GetRotationDegreesForRegion(string regionName)
	{
		return default(float);
	}

	[CallerCount(Count = 116)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	public bool IsIndoorEnvironment()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsIndoorScene()
	{
		return default(bool);
	}

	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateEffects")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CalledBy(Type = typeof(FlareItem), Member = "Ignite")]
	[CalledBy(Type = typeof(TorchIntensity), Member = "MaybeUpdateIntensityRTPC")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LightQualitySwitch), Member = "IsValidLocation")]
	[CalledBy(Type = typeof(LightQualitySwitch), Member = "IsValidLocation")]
	[CalledBy(Type = typeof(LightQualitySwitch), Member = "IsValidLocation")]
	[CalledBy(Type = typeof(FlareIntensity), Member = "MaybeUpdateIntensityRTPC")]
	[CalledBy(Type = typeof(FirstPersonFlashlight), Member = "Update")]
	[CalledBy(Type = typeof(FirstPersonFlashlight), Member = "Update")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LightQualitySwitch), Member = "IsValidLocation")]
	public bool UseOutdoorLightingForLightSources()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void LockAirTemperature(float celsius)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Weather), Member = "IsDenseFog")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MissionIlluminationArea), Member = "IsInIlluminationArea")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	public bool IsTooDarkForAction(ActionsToBlock actionBeingChecked)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	public bool IsFullMoon()
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraElectrolyzerFadeRatio")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(FlyOver), Member = "GetCurrentFormation")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsUnknownMethods(Count = 109)]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Vector3), Member = "Magnitude")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FlyOver), Member = "GetCurrentFormation")]
	[Calls(Type = typeof(FlyOver), Member = "GetCurrentFormation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(WeatherSet), Member = "GetDebugString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public static string GetDebugWeatherText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[CalledBy(Type = typeof(Weather), Member = "RampBlowingSnow")]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsWindyEnoughForBlowingSnow()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RampDownAllSnow()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Weather), Member = "RampBlowingSnow")]
	private void RampUpBlowingSnow()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "RampBlowingSnow")]
	[CallsUnknownMethods(Count = 4)]
	private void RampDownBlowingSnow()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UpdateWeatherSwitchStats()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "UpdateWeatherConditions")]
	public string GetWeatherStageDisplayName(WeatherStage ws)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	private void UpdateTemperatureOnHUD()
	{
	}

	[CallsUnknownMethods(Count = 40)]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[Calls(Type = typeof(Weather), Member = "GetMinAirTemp")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(HeatSourceManager), Member = "GetTemperatureIncrease")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetOutdoorTempDropCelcius")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInNonRuinedShelter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void CalculateCurrentTemperature()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateUniStormTemperature()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void GenerateTempHigh()
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WarmWeatherState")]
	public void WarmWeatherState()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToWornClothing")]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	private void ApplyClothingDamage()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	private void UpdateSnowEffectTransforms()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 17)]
	private void UpdateToxicFogSporeTransforms()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	public bool IsMainMenu()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Weather), Member = "IsMainMenu")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	public void MaybeCreateToxicFogSporeFx()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(Weather), Member = "IsMainMenu")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 3)]
	public void SetToxicFogParameters(float minFogThreshhold, float maxFogThreshhold, float fogValue)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void MaybeUpdateWiseWithCurrentTemperature()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[CallsUnknownMethods(Count = 11)]
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
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	public void EnableWindEffect()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(Weather), Member = "Update")]
	[CallsUnknownMethods(Count = 15)]
	private void UpdateAndMaybeSendAnalytics()
	{
	}

	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Weather()
	{
	}
}
