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
		[CalledBy(Type = typeof(PassTimeHelper), Member = "PassTime")]
		[CalledBy(Type = typeof(PassTimeHelper), Member = "OnSleepEnd")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		private static bool TryGetPanel<T>(out T panel, ref T cache) where T : Panel_Base
		{
			panel = null;
			return false;
		}

		[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(PassTimeHelper), Member = "TryGetPanel")]
		[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
		[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
		[Calls(Type = typeof(AccelTimePopup), Member = "IsLabelMessageActive")]
		[Calls(Type = typeof(Rest), Member = "BeginSleeping")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 10)]
		public void PassTime(int hours)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(PassTimeHelper), Member = "TryGetPanel")]
		[Calls(Type = typeof(AccelTimePopup), Member = "EnableLabelMessage")]
		[CallsUnknownMethods(Count = 2)]
		private void OnSleepEnd()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeTriggerAchievement(Bed bed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rest), Member = "BeginSleeping")]
	public void BeginSleeping(Bed b, int durationHours, int maxHours)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSleeping()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(Action_PlayerWakeup), Member = "OnExecute")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(TimeOfDay), Member = "ForceUpdateTodObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "Degrade")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(AiUtils), Member = "DespawnHostileAiAroundPoint")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void EndSleeping(bool interrupted)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumHoursSleptInLastTwentyFour()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumHoursSleptSinceMidnight()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool AllowedToSleepAmount(int amount)
	{
		return false;
	}

	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CalledBy(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "GetWarmthBonusCelsius")]
	[CallsUnknownMethods(Count = 1)]
	public float GetBedWarmthBonusCelsius()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public bool RestNeededForAffliction()
	{
		return false;
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
		return false;
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 1)]
	public bool AllowUnlimitedSleep()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateFatigue(float todSeconds)
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Condition), Member = "IsDegrading")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateCondition(float todSeconds)
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BrokenRib), Member = "AddRest")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateRestForCures(float todSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsFearOrAnxietyPreventingSleep()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldInterruptSleepWithInsomnia()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	private float GetChanceOfHowBadlySleepIsIntnerrupted()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rest), Member = "CanSpawnPredator")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldInterruptSleep()
	{
		return false;
	}

	[CalledBy(Type = typeof(Rest), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Rest), Member = "RestNeededForAffliction")]
	[Calls(Type = typeof(Rest), Member = "AllowUnlimitedSleep")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Rest), Member = "CanSpawnPredator")]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[Calls(Type = typeof(Rest), Member = "UpdateCondition")]
	[Calls(Type = typeof(Rest), Member = "UpdateRestForCures")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(Rest), Member = "UpdateLogWithHoursSlept")]
	[Calls(Type = typeof(Rest), Member = "DisplayDayNumber")]
	[Calls(Type = typeof(Rest), Member = "SpawnPredator")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
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
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateLogWithHoursSlept()
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void DisplayDayNumber()
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void RollForRestInterruption()
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptSleep")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private bool CanSpawnPredator()
	{
		return false;
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StickCharacterControllerToGround")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void SpawnPredator()
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "RollForRestInterruption")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideNoSpawnRegion")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideActiveSpawnRegion")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshArea")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private bool ShouldInterruptWithPredator()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptIfFreezingStartsWhileSleeping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private Fire GetNearbyBuringFire()
	{
		return null;
	}

	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Rest), Member = "GetNearbyBuringFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldInterruptIfFreezingStartsWhileSleeping()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool CanUseFade()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool CanDisplayCancelButton()
	{
		return false;
	}

	[CalledBy(Type = typeof(PassTimeHelper), Member = "PassTime")]
	[CalledBy(Type = typeof(Rest), Member = "BeginSleeping")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(Rest), Member = "ShouldInterruptIfFreezingStartsWhileSleeping")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Rest), Member = "RollForRestInterruption")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void BeginSleeping(Bed b, int durationHours, int maxHours, float fadeOutDuration, PassTimeOptions options, Action onSleepEnd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	private Panel_HUD GetHUD()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public Rest()
	{
	}
}
