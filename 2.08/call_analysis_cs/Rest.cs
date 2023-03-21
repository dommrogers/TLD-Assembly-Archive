using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gameplay.Condition;
using TLD.Serialization;
using TLD.UI.Generics;
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

		private Panel_HUD m_HUD;

		private Panel_FeedFire m_FeedFire;

		private Panel_Cooking m_Cooking;

		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		private static bool TryGetPanel<T>(out T panel, ref T cache) where T : Panel_Base
		{
			panel = null;
			return default(bool);
		}

		[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "OnExecute")]
		[Calls(Type = typeof(AccelTimePopup), Member = "IsLabelMessageActive")]
		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
		[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
		[Calls(Type = typeof(Rest), Member = "BeginSleeping")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 6)]
		[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		public void PassTime(int hours)
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(AccelTimePopup), Member = "EnableLabelMessage")]
		private void OnSleepEnd()
		{
		}

		[CallerCount(Count = 6)]
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

	private PanelReference<Panel_HUD> m_HUDReference;

	private PanelReference<Panel_Rest> m_RestPanel;

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

	private Panel_HUD m_HUD;

	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeTriggerAchievement(Bed bed)
	{
	}

	[Calls(Type = typeof(Rest), Member = "BeginSleeping")]
	[CallerCount(Count = 0)]
	public void BeginSleeping(Bed b, int durationHours, int maxHours)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSleeping()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(Action_PlayerWakeup), Member = "OnExecute")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Bed), Member = "Degrade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TodMaterial), Member = "ForceUpdateAll")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AiUtils), Member = "DespawnHostileAiAroundPoint")]
	public void EndSleeping(bool interrupted)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public int GetNumHoursSleptInLastTwentyFour()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumHoursSleptSinceMidnight()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool AllowedToSleepAmount(int amount)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(Bed), Member = "GetWarmthBonusCelsius")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	public float GetBedWarmthBonusCelsius()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CallsUnknownMethods(Count = 9)]
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

	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	public bool AllowUnlimitedSleep()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateFatigue(float todSeconds)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "IsDegrading")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateCondition(float todSeconds)
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(BrokenRib), Member = "AddRest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void UpdateRestForCures(float todSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsFearOrAnxietyPreventingSleep()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldInterruptSleepWithInsomnia()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	private float GetChanceOfHowBadlySleepIsIntnerrupted()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rest), Member = "CanSpawnPredator")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldInterruptSleep()
	{
		return default(bool);
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Rest), Member = "DisplayDayNumber")]
	[Calls(Type = typeof(Rest), Member = "UpdateLogWithHoursSlept")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Rest), Member = "SpawnPredator")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[CalledBy(Type = typeof(Rest), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Rest), Member = "UpdateLogWithHoursSlept")]
	[Calls(Type = typeof(Rest), Member = "AllowUnlimitedSleep")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Rest), Member = "RestNeededForAffliction")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Rest), Member = "CanSpawnPredator")]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[Calls(Type = typeof(Rest), Member = "UpdateCondition")]
	[Calls(Type = typeof(Rest), Member = "UpdateRestForCures")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	private void UpdateWhenSleeping()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateLogWithPredatorInterruption()
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	private void UpdateLogWithHoursSlept()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallsUnknownMethods(Count = 1)]
	private void DisplayDayNumber()
	{
	}

	[Calls(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	private void RollForRestInterruption()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptSleep")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CanSpawnPredator()
	{
		return default(bool);
	}

	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "StickCharacterControllerToGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void SpawnPredator()
	{
	}

	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshArea")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideActiveSpawnRegion")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshArea")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideActiveSpawnRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshArea")]
	[CalledBy(Type = typeof(Rest), Member = "RollForRestInterruption")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideNoSpawnRegion")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	private bool ShouldInterruptWithPredator()
	{
		return default(bool);
	}

	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsUnknownMethods(Count = 1)]
	private void AccelerateTimeOfDay(int minutes, float fadeOutSeconds, bool useFade)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void TrackHoursOfSleep()
	{
	}

	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptIfFreezingStartsWhileSleeping")]
	[CallsUnknownMethods(Count = 6)]
	private Fire GetNearbyBuringFire()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Rest), Member = "GetNearbyBuringFire")]
	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CalledBy(Type = typeof(PassTimeHelper), Member = "PassTime")]
	[Calls(Type = typeof(Rest), Member = "RollForRestInterruption")]
	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[Calls(Type = typeof(Rest), Member = "ShouldInterruptIfFreezingStartsWhileSleeping")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void BeginSleeping(Bed b, int durationHours, int maxHours, float fadeOutDuration, PassTimeOptions options, Action onSleepEnd)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private Panel_HUD GetHUD()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public Rest()
	{
	}
}
