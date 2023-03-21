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
using UnityEngine.Rendering.PostProcessing;

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
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		[DebuggerHidden]
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

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 9)]
	public void Start()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[Calls(Type = typeof(TimeOfDay), Member = "UpdateAnalytics")]
	[Calls(Type = typeof(PlayerVoice), Member = "Queue")]
	[Calls(Type = typeof(TimeOfDay), Member = "DebugOnly_UpdateTimeOfDayScale")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "InitializeForScene")]
	[Calls(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetTimeOfDayScale")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "InitializeForScene")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "Start")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetTODLocked(bool isLocked)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 34)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "EnableTimeOfDayScaleDisplay")]
	[CallsUnknownMethods(Count = 3)]
	public void SetDayLengthScale(float scale)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetDayLengthScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetConditionLabelDepth")]
	[CalledBy(Type = typeof(EntityWard), Member = "UpdateWard")]
	[CalledBy(Type = typeof(EntityWard), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[CalledBy(Type = typeof(Suffocating), Member = "Update")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlaceFootPrintDecal")]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	public bool IsTimeLapseActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(EyeGlow), Member = "TurnOffEyeGlow")]
	[CalledBy(Type = typeof(EyeGlow), Member = "Update")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(Wind), Member = "CalculateWindChill")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "GetCustomWeightsForCurrentXpMode")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(TodMaterial), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceDayOnlyObject")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetDenSleepDurationInHours")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "ShouldSleepInDenAfterWaypointLoop")]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CallerCount(Count = 16)]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool IsAfternoon()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(PlayAudioTrigger), Member = "Play")]
	[CalledBy(Type = typeof(PlayAudioTrigger), Member = "Play")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_crow_flyover_test")]
	[CalledBy(Type = typeof(AchievementManager), Member = "Update")]
	[CalledBy(Type = typeof(Feat_NightWalker), Member = "GetFatigueScale")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceNightOnlyObject")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(Fatigue), Member = "AddFatigue")]
	[CalledBy(Type = typeof(FlyOver), Member = "CanSpawnFlyover")]
	[CallerCount(Count = 17)]
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

	[CalledBy(Type = typeof(TodSmokeTrail), Member = "UpdateDayOnlyObject")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "UpdateNightOnlyObject")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(Carrion), Member = "IsTooDark")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallerCount(Count = 9)]
	public bool IsDusk()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Carrion), Member = "IsTooDark")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[CallsUnknownMethods(Count = 1)]
	public void SetNormalizedTime(float time)
	{
	}

	[CalledBy(Type = typeof(BrightnessCalibration), Member = "ForceDay")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "ForceNight")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(HeightFogManager), Member = "Update")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[Calls(Type = typeof(TimeOfDay), Member = "ForceUpdateTodObjects")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public void SetNormalizedTime(float time, bool forceUpdate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetUniStormAuroraAlpha(float alpha)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	public string FormatTime(int hours, int minutes)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	public void Accelerate(float realTimeSeconds, float gameTimeHours, bool doFadeToBlack = true)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
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

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Anxiety), Member = "Update")]
	[CalledBy(Type = typeof(Fear), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFog), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public float GetTODMinutes(float realTimeSeconds)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetTODMinutesUnscaled(float realTimeSeconds)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[CalledBy(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "Update")]
	[CalledBy(Type = typeof(BloodLoss), Member = "Update")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(InfectionRisk), Member = "UpdateInfectionRisk")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetRealTimeSeconds(float todHours)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Rest), Member = "EndSleeping")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(TodMaterial), Member = "ForceUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void ForceUpdateTodObjects()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	public void SetCameraVignettingIndoors()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
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

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateCurrentTimeLabel")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 7)]
	public string GetHoursDaylightString()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	public string GetGenericTODString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateUniStorm")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "Init")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UpdateSunTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public void InstantiateUniStorm(Camera mainCamera)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_timeaccelerate")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	public void AccelerateTime(float minutes, float realtimeDurationSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[IteratorStateMachine(typeof(_003CAccelerateCo_003Ed__106))]
	public IEnumerator AccelerateCo(float minutes, float realtimeDurationSeconds)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	private void CheckAchievements()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateUniStormTimeScollBarDisplay()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	private void DebugOnly_UpdateTimeOfDayScale()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
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
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 9)]
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
