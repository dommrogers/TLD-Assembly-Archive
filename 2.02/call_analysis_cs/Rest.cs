using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class Rest : MonoBehaviour
{
	public enum PassTimeOptions
	{
		None = 0,
		DoFade = 2,
		DisplayCancelButton = 4
	}

	public class PassTimeHelper
	{
		private bool m_PreviousFrostbiteState;

		private bool m_PreviousHypothermiaState;

		private bool m_PreviousPassTimeUISuppressedState;

		private bool m_PreviousLabelMessageState;

		[Calls(Type = typeof(Rest), Member = "BeginSleeping")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 25)]
		[CalledBy(Type = typeof(Action_PlayTimeline.Action_SetCinematicProperties), Member = "OnExecute")]
		[Calls(Type = typeof(AccelTimePopup), Member = "IsLabelMessageActive")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
		[CallerCount(Count = 1)]
		public void PassTime(int hours)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(AccelTimePopup), Member = "EnableLabelMessage")]
		[CallsUnknownMethods(Count = 7)]
		private void OnSleepEnd()
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public PassTimeHelper()
		{
		}
	}

	public float m_ReduceFatiguePerHourRest;

	public int m_MaxHoursSleepPerDay;

	public float m_SleepFadeOutSeconds;

	public GameObject m_WolfPrefab;

	public GameObject m_BearPrefab;

	public float m_ChancePredatorInterruptionInsideSpawnRegion;

	public float m_ChancePredatorInterruptionInsideSpawnRegionWhenInSnowShelter;

	public float m_DistanceFireProtectsFromPredatorInterruption;

	public bool m_WakeUpAtFullRest;

	private bool m_Sleeping;

	private float m_NumSecondsSleeping;

	private float m_SleepDurationSeconds;

	private float m_SleepDurationHours;

	private float m_DayLengthScaleBeforeSleeping;

	private int m_InterruptionAfterSecondsSleeping;

	private bool m_PredatorInterruption;

	private Bed m_Bed;

	private int[] m_LastTwentyFourHoursOfSleep;

	private int m_HourLastFrame;

	private int m_LastDisplayedDayNumberOnAwake;

	private bool m_TimeAccelerated;

	private bool m_ShouldInterruptWhenFreezing;

	private bool m_StartHasBeenCalled;

	private bool m_ForceSleepLength;

	private bool m_ForceSleepWakeTime;

	private float m_ForcedWakeTime;

	private int m_ForcedSleepLength;

	private PassTimeOptions m_PassTimeOptions;

	private static RestSaveDataProxy m_RestSaveDataProxy;

	private Action m_OnSleepEnd;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Rest), Member = "TrackHoursOfSleep")]
	[Calls(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[Calls(Type = typeof(Rest), Member = "TrackHoursOfSleep")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 6)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void MaybeTriggerAchievement(Bed bed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rest), Member = "BeginSleeping")]
	public void BeginSleeping(Bed b, int durationHours, int maxHours)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public bool IsSleeping()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(Action_PlayerWakeup), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(AiUtils), Member = "DespawnHostileAiAroundPoint")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "ForceUpdateTodObjects")]
	[Calls(Type = typeof(Bed), Member = "Degrade")]
	public void EndSleeping(bool interrupted)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public int GetNumHoursSleptInLastTwentyFour()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public int GetNumHoursSleptSinceMidnight()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public bool AllowedToSleepAmount(int amount)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "GetWarmthBonusCelsius")]
	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CalledBy(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public float GetBedWarmthBonusCelsius()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	public bool RestNeededForAffliction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetForceSleepLength(int hours)
	{
	}

	[CallerCount(Count = 0)]
	public void SetForceSleepWakeTime(float wakeTime)
	{
	}

	[CallerCount(Count = 0)]
	public void ClearForceSleepLength()
	{
	}

	[CallerCount(Count = 0)]
	public void ClearForceSleepWakeTime()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsForcedSleep()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	public bool AllowUnlimitedSleep()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateFatigue(float todSeconds)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Condition), Member = "IsDegrading")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void UpdateCondition(float todSeconds)
	{
	}

	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateConditonBuffDuration")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(BrokenRib), Member = "AddRest")]
	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void UpdateRestForCures(float todSeconds)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsFearOrAnxietyPreventingSleep()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Rest), Member = "CanSpawnPredator")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldInterruptSleep()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Rest), Member = "UpdateLogWithHoursSlept")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[CalledBy(Type = typeof(Rest), Member = "Update")]
	[Calls(Type = typeof(Rest), Member = "SpawnPredator")]
	[Calls(Type = typeof(Rest), Member = "UpdateLogWithHoursSlept")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Rest), Member = "RestNeededForAffliction")]
	[Calls(Type = typeof(Rest), Member = "AllowUnlimitedSleep")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Rest), Member = "CanSpawnPredator")]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[Calls(Type = typeof(Rest), Member = "UpdateCondition")]
	[Calls(Type = typeof(Rest), Member = "UpdateRestForCures")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateWhenSleeping()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateLogWithPredatorInterruption()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateLogWithHoursSlept()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void DisplayDayNumber()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 1)]
	private void RollForRestInterruption()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptSleep")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private bool CanSpawnPredator()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(BaseAi), Member = "StickCharacterControllerToGround")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void SpawnPredator()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideActiveSpawnRegion")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshArea")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshArea")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideActiveSpawnRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshArea")]
	[CalledBy(Type = typeof(Rest), Member = "RollForRestInterruption")]
	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideNoSpawnRegion")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private bool ShouldInterruptWithPredator()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsUnknownMethods(Count = 3)]
	private void AccelerateTimeOfDay(int minutes, float fadeOutSeconds, bool useFade)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Rest), Member = "Update")]
	[CalledBy(Type = typeof(Rest), Member = "Update")]
	[CallsUnknownMethods(Count = 13)]
	private void TrackHoursOfSleep()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptIfFreezingStartsWhileSleeping")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private Fire GetNearbyBuringFire()
	{
		return null;
	}

	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Rest), Member = "GetNearbyBuringFire")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	private bool ShouldInterruptIfFreezingStartsWhileSleeping()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool CanUseFade()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool CanDisplayCancelButton()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CalledBy(Type = typeof(PassTimeHelper), Member = "PassTime")]
	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(Rest), Member = "ShouldInterruptIfFreezingStartsWhileSleeping")]
	[Calls(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	public void BeginSleeping(Bed b, int durationHours, int maxHours, float fadeOutDuration, PassTimeOptions options, Action onSleepEnd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Rest()
	{
	}
}
