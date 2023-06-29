using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using TLD.AI;
using TLD.Audio;
using TLD.Gear;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class TimeOfDay : MonoBehaviour
{
	private sealed class _003CAccelerateCo_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TimeOfDay _003C_003E4__this;

		public float realtimeDurationSeconds;

		public float minutes;

		private float _003CdayLengthScaleBeforeAccelerate_003E5__2;

		private float _003Ctimer_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CAccelerateCo_003Ed__106(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
		[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private static TimeOfDay _003CInstance_003Ek__BackingField;

	public GameObject m_UniStormPrefab;

	public GameObject m_UniStorm;

	public int m_DebugTimeSpeedupCounter;

	public int m_StartTimeHour;

	public int m_StartTimeMinutes;

	public int m_DayDurationInMinutes;

	public int m_NightDurationInMinutes;

	public int m_DawnStingerHourStart;

	public int m_DawnStingerMinutesStart;

	public int m_NightStingerHourStart;

	public int m_NightStingerMinutesStart;

	public AK.Wwise.Event m_DawnStingerEvent;

	public AK.Wwise.Event m_NightStingerEvent;

	public AK.Wwise.Event m_DawnVoiceOverEvent;

	public float m_DawnVoiceOverDelaySeconds;

	public AK.Wwise.Event m_NightVoiceOverEvent;

	public float m_NightVoiceOverDelaySeconds;

	private PanelReference<Panel_HUD> m_HUDReference;

	public UniStormWeatherSystem m_WeatherSystem;

	private float m_DayLengthScale;

	private float m_DayLengthScaleDebug;

	private int m_DayLastDawnStingerAudioPlayed;

	private int m_DayLastNightStingerAudioPlayed;

	private int m_DayLastDawnVoiceOverPlayed;

	private int m_DayLastNightVoiceOverPlayed;

	private AK.Wwise.Event m_NextVoiceOver;

	private float m_TimeToPlayNextVoiceOver;

	private StringBuilder m_StringBuilder;

	private int m_DaysSurvivedLastFrame;

	private bool m_WasNightLastFrame;

	private int m_SkipUpdateCount;

	private int m_LastHourSentToWise;

	private bool m_StartHasBeenCalled;

	private bool m_WeatherInitializedForScene;

	private bool m_WeatherInitializedAfterSceneLoad;

	private int m_IsTimeLapseActiveCounter;

	private bool m_LockedTOD;

	private static TimeOfDaySaveDataProxy m_TimeOfDaySaveDataProxy;

	private string m_CurrentScene;

	private int m_DayEntered;

	private int m_HourEntered;

	private float m_ElapsedRealSecondsInScene;

	private float m_ElapsedGameHoursInScene;

	private Panel_Loading m_Loading;

	private Panel_HUD m_HUD;

	public static TimeOfDay Instance
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "InitializeForScene")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "InitializeForScene")]
	[Calls(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetTimeOfDayScale")]
	[Calls(Type = typeof(TimeOfDay), Member = "DebugOnly_UpdateTimeOfDayScale")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(PlayerVoice), Member = "Queue")]
	[Calls(Type = typeof(TimeOfDay), Member = "UpdateAnalytics")]
	[Calls(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetTODLocked(bool isLocked)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTODLocked()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void TimeLapseBegin()
	{
	}

	[CallerCount(Count = 0)]
	public void TimeLapseEnd()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetDayLengthSeconds()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetDayLengthSecondsUnscaled()
	{
		return 0f;
	}

	[CallerCount(Count = 34)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "EnableTimeOfDayScaleDisplay")]
	[CallsUnknownMethods(Count = 3)]
	public void SetDayLengthScale(float scale)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetDayLengthScale()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlaceFootPrintDecal")]
	[CalledBy(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(Suffocating), Member = "Update")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CalledBy(Type = typeof(EntityWard), Member = "Update")]
	[CalledBy(Type = typeof(EntityWard), Member = "UpdateWard")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetConditionLabelDepth")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(AiPtarmigan), Member = "ComputeDistanceForTarget")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsTimeLapseActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "ShouldSleepInDenAfterWaypointLoop")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetDenSleepDurationInHours")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(TodMaterial), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceDayOnlyObject")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "GetCustomWeightsForCurrentXpMode")]
	[CalledBy(Type = typeof(Wind), Member = "CalculateWindChill")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsDay()
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

	[CalledBy(Type = typeof(FlyOver), Member = "CanSpawnFlyover")]
	[CalledBy(Type = typeof(Fatigue), Member = "AddFatigue")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceNightOnlyObject")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(Feat_NightWalker), Member = "GetFatigueScale")]
	[CalledBy(Type = typeof(AchievementManager), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_crow_flyover_test")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(PlayAudioTrigger), Member = "Play")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 17)]
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
	public bool IsDayWithExtendedHours(float extendedHours)
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

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CalledBy(Type = typeof(Carrion), Member = "IsTooDark")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "UpdateDayOnlyObject")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "UpdateNightOnlyObject")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsDusk()
	{
		return false;
	}

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CalledBy(Type = typeof(Carrion), Member = "IsTooDark")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsDawn()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDusk")]
	[CallsUnknownMethods(Count = 1)]
	public float GetProgressDusk()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDawnHourTime()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	[CallsUnknownMethods(Count = 1)]
	public float GetProgressDawn()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetDayNumber()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetHour()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetMinutes()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetNormalizedTime()
	{
		return 0f;
	}

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	public void SetNormalizedTime(float time)
	{
	}

	[CalledBy(Type = typeof(BrightnessCalibration), Member = "ForceNight")]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "ForceDay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(TodMaterial), Member = "ForceUpdateAll")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(HeightFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public void SetNormalizedTime(float time, bool forceUpdate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetUniStormAuroraAlpha(float alpha)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 1)]
	public string FormatTime(int hours, int minutes)
	{
		return null;
	}

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsUnknownMethods(Count = 2)]
	public void Accelerate(float realTimeSeconds, float gameTimeHours, bool doFadeToBlack = true)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public float GetTODSeconds(float realTimeSeconds)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetTODSecondsUnscaled(float realTimeSeconds)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Anxiety), Member = "Update")]
	[CalledBy(Type = typeof(Fear), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFog), Member = "Update")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public float GetTODMinutes(float realTimeSeconds)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetTODMinutesUnscaled(float realTimeSeconds)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(BloodLoss), Member = "Update")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "Update")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "UpdateInfectionRisk")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public float GetTODHours(float realTimeSeconds)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetTODHoursUnscaled(float realTimeSeconds)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetRealTimeSeconds(float todHours)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetRealTimeSecondsUnscaled(float todHours)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetSecondsPlayedUnscaled()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetHoursPlayedNotPaused()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsInitializedForScene()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetHoursPlayedNotPaused(float hours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TodMaterial), Member = "ForceUpdateAll")]
	public void ForceUpdateTodObjects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void SetCameraVignettingIndoors()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[CallsUnknownMethods(Count = 1)]
	public TODBlendState GetTODBlendState()
	{
		return default(TODBlendState);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CallsUnknownMethods(Count = 1)]
	public float GetTODBlendPercent(TODBlendState blendState)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateCurrentTimeLabel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 7)]
	public string GetHoursDaylightString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetGenericTODString()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateUniStorm")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void InstantiateUniStorm(Camera mainCamera)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_timeaccelerate")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	public void AccelerateTime(float minutes, float realtimeDurationSeconds)
	{
	}

	[IteratorStateMachine(typeof(_003CAccelerateCo_003Ed__106))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerator AccelerateCo(float minutes, float realtimeDurationSeconds)
	{
		return null;
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 6)]
	private void CheckAchievements()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SendDailyAnalyticsEvent")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkillFromIndex")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BaseAi), Member = "get_Moose")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "get_Rabbit")]
	[Calls(Type = typeof(BaseAi), Member = "get_Stag")]
	[Calls(Type = typeof(BaseAi), Member = "get_Doe")]
	[Calls(Type = typeof(BaseAi), Member = "get_NormalWolf")]
	[Calls(Type = typeof(BaseAi), Member = "get_Timberwolf")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 4)]
	private void DoEndOfDayAnalytics(int numDaysSurvived)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetTimeOfDayScale")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateUniStormDayLength()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateUniStormTimeScollBarDisplay()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void DebugOnly_UpdateTimeOfDayScale()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void MaybePlayTimeOfDayStingers()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "Queue")]
	[CallsUnknownMethods(Count = 1)]
	private void PlayDelayedVoiceOver()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeUpdateWiseWithCurrentHour()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAnalytics()
	{
	}

	[CallerCount(Count = 0)]
	public void IncrementElapsedHours(float timeDeltaHours)
	{
	}

	[CallerCount(Count = 0)]
	public TimeOfDay()
	{
	}
}
