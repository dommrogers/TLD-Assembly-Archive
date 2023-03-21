using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Fatigue : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public Fatigue fatigue;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SuppressHeavyBreathing(bool suppress)
	{
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public static void EndSuppressHeavyBreathingCallback()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ResetMovementTimers()
	{
	}

	[CallerCount(Count = 0)]
	public void HeavyBreathingInit()
	{
	}

	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private bool MovingUpIncline()
	{
		return false;
	}

	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fatigue), Member = "MovingUpIncline")]
	[Calls(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	[Calls(Type = typeof(Fatigue), Member = "MaybePlayFatigueVoiceOver")]
	[Calls(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	[Calls(Type = typeof(Fatigue), Member = "UpdateHeavyBreathingLoopRTPC")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateHeavyBreathing()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void UpdateDebugText()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public HeavyBreathingState GetHeavyBreathingState()
	{
		return default(HeavyBreathingState);
	}

	[CalledBy(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void CatchBreath()
	{
	}

	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetSprintStaminaRemainingAsPercentage")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(Fatigue), Member = "MovingUpIncline")]
	[Calls(Type = typeof(Fatigue), Member = "CatchBreath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeCatchBreath()
	{
	}

	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetSprintStaminaRemainingAsPercentage")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateHeavyBreathingLoopRTPC()
	{
	}

	[CallerCount(Count = 0)]
	private void SetHeavyBreathingState(HeavyBreathingState state)
	{
	}

	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(Fatigue), Member = "ComputeHeavyBreathingState")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybePlayHeavyBreathingLoop()
	{
	}

	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private HeavyBreathingState ComputeHeavyBreathingState(HeavyBreathingLevels thresholds)
	{
		return default(HeavyBreathingState);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HeavyBreathingShouldSuppressVO()
	{
		return false;
	}

	[CalledBy(Type = typeof(Fatigue), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[Calls(Type = typeof(Fatigue), Member = "UpdateFatigueStatusOnHUD")]
	[Calls(Type = typeof(Fatigue), Member = "MaybeUpdateExhaustedStatusInLog")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Fatigue), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetFatigueStateString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public float GetNormalizedFatigue()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStimExitEffects")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[CalledBy(Type = typeof(FatigueBuff), Member = "Apply")]
	[CalledBy(Type = typeof(BloodLoss), Member = "MaybeApplyDamage")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateDysentery")]
	[CalledBy(Type = typeof(FoodPoisoning), Member = "UpdateFoodPoisoning")]
	[CalledBy(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[CalledBy(Type = typeof(Infection), Member = "UpdateInfection")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyFatigueBuff")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateFatigue")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public void AddFatigue(float fatigueValue)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsExhausted()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCurrentTotalFatigueBurnPerHour()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void DisplayFatigueOnHUDForTime(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetFatigueTextForHud()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeUpdateFatigueStatusLabel()
	{
	}

	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 37)]
	private void UpdateFatigueStatusOnHUD()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldPlayFatigueVoiceOver()
	{
		return false;
	}

	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void MaybePlayFatigueVoiceOver()
	{
	}

	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeUpdateExhaustedStatusInLog()
	{
	}

	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	private float CalculateFatigueIncrease(float realtimeSeconds)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Fatigue()
	{
	}
}
