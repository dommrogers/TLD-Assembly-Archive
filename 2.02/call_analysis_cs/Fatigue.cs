using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Fatigue : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public Fatigue fatigue;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CEndSuppressHeavyBreathingCallback_003Eb__0()
		{
		}
	}

	public float m_PauseBreathingAfterSpeech;

	public float m_SuppressVOAfterRopeExertionSeconds;

	public HeavyBreathingLevels m_MinSecondsPerState;

	public HeavyBreathingLevels m_GeneralBreathThresholds;

	public HeavyBreathingLevels m_RopeClimbBreathThresholds;

	public float m_NormalizedCriticalHealth;

	public float m_NormalizedSeriousHealth;

	public HeavyBreathingState m_InclineMinState;

	public float m_InclineBreathingStartDelay;

	public float m_InclineAngle;

	public HeavyBreathingState m_SprintDisabledState;

	public bool m_EnableCatchBreath;

	public float m_StaminaLevelForRecovery;

	private HeavyBreathingState m_HeavyBreathingState;

	private float m_SecondsInCurrentState;

	private float m_SecondsOnIncline;

	private bool m_SuppressCatchBreathAudio;

	private bool m_SuppressHeavyBreathing;

	private bool m_StaminaWasBelowLevelForRecovery;

	private float m_RopeActivitySpeechSuppressionTime;

	private float m_LastBreathLevelRTPCSent;

	private float m_LastInclineAngle;

	private float m_SinInclineAngle;

	public float m_CurrentFatigueBurnPerHour;

	public float m_CurrentFatigue;

	public float m_MaxFatigue;

	public float m_FatigueIncreasePerHourStanding;

	public float m_FatigueIncreasePerHourWalking;

	public float m_FatigueIncreasePerHourSprintingMin;

	public float m_FatigueIncreasePerHourSprintingMax;

	public float m_SecondsSprintingForMaxFatigueIncrease;

	public float m_FullBackPackScaleFactor;

	public float m_RestedThreshold;

	public float m_SlightlyTiredThreshold;

	public float m_TiredThreshold;

	public float m_VeryTiredThreshold;

	public float m_ExhaustedThreshold;

	public string m_SlightlyTiredVoiceOver;

	public string m_TiredVoiceOver;

	public string m_VeryTiredVoiceOver;

	public string m_ExhaustedVoiceOver;

	public float m_MinSecondsBetweenVoiceOverVariations;

	public float m_TimeToDisplayFatigueWhenChanged;

	private FatigueLevel m_FatigueLevelForPreviousVoiceOver;

	private float m_NumSecondsSinceLastVoiceOver;

	private float m_TimeDisableFatigueOnHUD;

	private int m_FatigueLevelLastStatusChange;

	private bool m_ExhaustedInLog;

	private bool m_StartHasBeenCalled;

	private bool m_SuppressVoiceOver;

	private float m_TotalFatigueBurnPerHour;

	private float m_FatigueValueLastFrame;

	private static FatigueSaveDataProxy m_FatigueSaveDataProxy;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SuppressHeavyBreathing(bool suppress)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 17)]
	public static void EndSuppressHeavyBreathingCallback()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void ResetMovementTimers()
	{
	}

	[CallerCount(Count = 0)]
	public void HeavyBreathingInit()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private bool MovingUpIncline()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Fatigue), Member = "MovingUpIncline")]
	[Calls(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	[Calls(Type = typeof(Fatigue), Member = "MaybePlayFatigueVoiceOver")]
	[Calls(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	[Calls(Type = typeof(Fatigue), Member = "UpdateHeavyBreathingLoopRTPC")]
	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	private void UpdateHeavyBreathing()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void UpdateDebugText()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public HeavyBreathingState GetHeavyBreathingState()
	{
		return default(HeavyBreathingState);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void CatchBreath()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Fatigue), Member = "MovingUpIncline")]
	[Calls(Type = typeof(Fatigue), Member = "CatchBreath")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetSprintStaminaRemainingAsPercentage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void MaybeCatchBreath()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetSprintStaminaRemainingAsPercentage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void UpdateHeavyBreathingLoopRTPC()
	{
	}

	[CallerCount(Count = 0)]
	private void SetHeavyBreathingState(HeavyBreathingState state)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[Calls(Type = typeof(Fatigue), Member = "ComputeHeavyBreathingState")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(Fatigue), Member = "ComputeHeavyBreathingState")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybePlayHeavyBreathingLoop()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[CallsDeduplicatedMethods(Count = 1)]
	private HeavyBreathingState ComputeHeavyBreathingState(HeavyBreathingLevels thresholds)
	{
		return default(HeavyBreathingState);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool HeavyBreathingShouldSuppressVO()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Fatigue), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Fatigue), Member = "MaybeUpdateExhaustedStatusInLog")]
	[Calls(Type = typeof(Fatigue), Member = "UpdateFatigueStatusOnHUD")]
	[Calls(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Fatigue), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetFatigueStateString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public float GetNormalizedFatigue()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[CalledBy(Type = typeof(FatigueBuff), Member = "Apply")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyFatigueBuff")]
	[CalledBy(Type = typeof(BloodLoss), Member = "MaybeApplyDamage")]
	[CalledBy(Type = typeof(FoodPoisoning), Member = "UpdateFoodPoisoning")]
	[CalledBy(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[CalledBy(Type = typeof(Infection), Member = "UpdateInfection")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateFatigue")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStimExitEffects")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateDysentery")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	public void AddFatigue(float fatigueValue)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsExhausted()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetCurrentTotalFatigueBurnPerHour()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 4)]
	private void CalculateTotalFatigueBurnPerHour()
	{
	}

	[CallerCount(Count = 0)]
	private FatigueLevel GetFatigueLevel()
	{
		return default(FatigueLevel);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void DisplayFatigueOnHUDForTime(float seconds)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetFatigueTextForHud()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void MaybeUpdateFatigueStatusLabel()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[CallerCount(Count = 1)]
	private void UpdateFatigueStatusOnHUD()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	private bool ShouldPlayFatigueVoiceOver()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	private void MaybePlayFatigueVoiceOver()
	{
	}

	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeUpdateExhaustedStatusInLog()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private float CalculateFatigueIncrease(float realtimeSeconds)
	{
		return default(float);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Fatigue()
	{
	}
}
