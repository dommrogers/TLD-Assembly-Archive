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
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			[DebuggerHidden]
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

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
		[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	public void Start()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(PlayerVoice), Member = "Queue")]
	[Calls(Type = typeof(TimeOfDay), Member = "DebugOnly_UpdateTimeOfDayScale")]
	[Calls(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(TimeOfDay), Member = "UpdateAnalytics")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetTimeOfDayScale")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "InitializeForScene")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "InitializeForScene")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "Start")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
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
		return default(bool);
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
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetDayLengthSecondsUnscaled()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "EnableTimeOfDayScaleDisplay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	public void SetDayLengthScale(float scale)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetDayLengthScale()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetConditionLabelDepth")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	[CalledBy(Type = typeof(EntityWard), Member = "UpdateWard")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CalledBy(Type = typeof(EntityWard), Member = "Update")]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlaceFootPrintDecal")]
	[CalledBy(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(Suffocating), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	public bool IsTimeLapseActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "GetCustomWeightsForCurrentXpMode")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(Wind), Member = "CalculateWindChill")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceDayOnlyObject")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "ShouldSleepInDenAfterWaypointLoop")]
	[CalledBy(Type = typeof(TodMaterial), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetDenSleepDurationInHours")]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceUpdate")]
	public bool IsDay()
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

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_crow_flyover_test")]
	[CalledBy(Type = typeof(AchievementManager), Member = "Update")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	[CalledBy(Type = typeof(Feat_NightWalker), Member = "GetFatigueScale")]
	[CalledBy(Type = typeof(PlayAudioTrigger), Member = "Play")]
	[CalledBy(Type = typeof(PlayAudioTrigger), Member = "Play")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceNightOnlyObject")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(Fatigue), Member = "AddFatigue")]
	[CalledBy(Type = typeof(FlyOver), Member = "CanSpawnFlyover")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsNight()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool IsNightWithExtendedHours(float extendedHours)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsDayWithExtendedHours(float extendedHours)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsNightPreMidnight()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsNightPostMidnight()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "UpdateNightOnlyObject")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "UpdateDayOnlyObject")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(Carrion), Member = "IsTooDark")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	public bool IsDusk()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(Carrion), Member = "IsTooDark")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallerCount(Count = 5)]
	public bool IsDawn()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDusk")]
	[CallsUnknownMethods(Count = 1)]
	public float GetProgressDusk()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDawnHourTime()
	{
		return default(float);
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetProgressDawn()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetDayNumber()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetHour()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetMinutes()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetNormalizedTime()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 25)]
	public void SetNormalizedTime(float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "ForceDay")]
	[Calls(Type = typeof(HeightFogManager), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(TodMaterial), Member = "ForceUpdateAll")]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "ForceNight")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void SetNormalizedTime(float time, bool forceUpdate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetUniStormAuroraAlpha(float alpha)
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	public string FormatTime(int hours, int minutes)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	public void Accelerate(float realTimeSeconds, float gameTimeHours, bool doFadeToBlack = true)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public float GetTODSeconds(float realTimeSeconds)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetTODSecondsUnscaled(float realTimeSeconds)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Fear), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFog), Member = "Update")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Anxiety), Member = "Update")]
	public float GetTODMinutes(float realTimeSeconds)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetTODMinutesUnscaled(float realTimeSeconds)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "UpdateInfectionRisk")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[CalledBy(Type = typeof(BloodLoss), Member = "Update")]
	[CalledBy(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(InfectionRisk), Member = "Update")]
	public float GetTODHours(float realTimeSeconds)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetTODHoursUnscaled(float realTimeSeconds)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetRealTimeSeconds(float todHours)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetRealTimeSecondsUnscaled(float todHours)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetSecondsPlayedUnscaled()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetHoursPlayedNotPaused()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsInitializedForScene()
	{
		return default(bool);
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

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
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
		return default(float);
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateCurrentTimeLabel")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetHoursDaylightString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetGenericTODString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateUniStorm")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Init")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	public void InstantiateUniStorm(Camera mainCamera)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_timeaccelerate")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
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

	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	private void CheckAchievements()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SendDailyAnalyticsEvent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SendDailyAnalyticsEvent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Utils), Member = "SendDailyAnalyticsEvent")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkillFromIndex")]
	[Calls(Type = typeof(Utils), Member = "SendDailyAnalyticsEvent")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SendDailyAnalyticsEvent")]
	private void DoEndOfDayAnalytics(int numDaysSurvived)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetTimeOfDayScale")]
	private void UpdateUniStormDayLength()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateUniStormTimeScollBarDisplay()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	private void DebugOnly_UpdateTimeOfDayScale()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private void MaybePlayTimeOfDayStingers()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "Queue")]
	[CallsUnknownMethods(Count = 1)]
	private void PlayDelayedVoiceOver()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void MaybeUpdateWiseWithCurrentHour()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
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
