using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TimeOfDay : MonoBehaviour
{
	private sealed class _003CAccelerateCo_003Ed__97 : IEnumerator<object>, IEnumerator, IDisposable
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
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CAccelerateCo_003Ed__97(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
		[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

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

	public string m_DawnStingerAudio;

	public string m_NightStingerAudio;

	public string m_DawnVoiceOver;

	public float m_DawnVoiceOverDelaySeconds;

	public string m_NightVoiceOver;

	public float m_NightVoiceOverDelaySeconds;

	public UniStormWeatherSystem m_WeatherSystem;

	private float m_DayLengthScale;

	private float m_DayLengthScaleDebug;

	private int m_DayLastDawnStingerAudioPlayed;

	private int m_DayLastNightStingerAudioPlayed;

	private int m_DayLastDawnVoiceOverPlayed;

	private int m_DayLastNightVoiceOverPlayed;

	private string m_NextVoiceOver;

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

	[CalledBy(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegionManager), Member = "GetCurrentRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "Reset")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "InitializeForScene")]
	[Calls(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[Calls(Type = typeof(TimeOfDay), Member = "UpdateUniStormDayLength")]
	[Calls(Type = typeof(TimeOfDay), Member = "DebugOnly_UpdateTimeOfDayScale")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(TimeOfDay), Member = "PlayDelayedVoiceOver")]
	[Calls(Type = typeof(TimeOfDay), Member = "UpdateAnalytics")]
	[Calls(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 15)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void Deserialize(string text)
	{
	}

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

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "UpdateTimeScale")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "EnableTimeOfDayScaleDisplay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
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
	[CalledBy(Type = typeof(EntityWard), Member = "UpdateWard")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetConditionLabelDepth")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsTimeLapseActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsDay()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsMorning()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsAfternoon()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsNight()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public bool IsNightWithExtendedHours(float extendedHours)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public bool IsDayWithExtendedHours(float extendedHours)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsNightPreMidnight()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsNightPostMidnight()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsDusk()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 3)]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void SetNormalizedTime(float time)
	{
	}

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(TimeOfDay), Member = "ForceUpdateTodObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(HeightFogManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public string FormatTime(int hours, int minutes)
	{
		return null;
	}

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
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
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(BloodLoss), Member = "Update")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "Update")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "UpdateInfectionRisk")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[CallerCount(Count = 7)]
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

	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(Rest), Member = "EndSleeping")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TodMaterial), Member = "ForceUpdateAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ForceUpdateTodObjects()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
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
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Weather), Member = "IsDenseFog")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	public string GetHoursDaylightString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetGenericTODString()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateUniStorm")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void InstantiateUniStorm(Camera mainCamera)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "AccelerateCo")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	public void AccelerateTime(float minutes, float realtimeDurationSeconds)
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "AccelerateTime")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_timeaccelerate")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator AccelerateCo(float minutes, float realtimeDurationSeconds)
	{
		return null;
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	private void CheckAchievements()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SendDailyAnalyticsEvent")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(SkillsManager), Member = "GetNumSkills")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkillFromIndex")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 35)]
	private void DoEndOfDayAnalytics(int numDaysSurvived)
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetTimeOfDayScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateUniStormDayLength()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateUniStormTimeScollBarDisplay()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void DebugOnly_UpdateTimeOfDayScale()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Weather), Member = "IsDenseFog")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 27)]
	private void MaybePlayTimeOfDayStingers()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "Queue")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void PlayDelayedVoiceOver()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeUpdateWiseWithCurrentHour()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 15)]
	private void UpdateAnalytics()
	{
	}

	[CallerCount(Count = 0)]
	public void IncrementElapsedHours(float timeDeltaHours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TimeOfDay()
	{
	}
}
