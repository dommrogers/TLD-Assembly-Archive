using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Fatigue : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public Fatigue fatigue;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass76_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CEndSuppressHeavyBreathingCallback_003Eb__0()
		{
		}
	}

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

	private PanelReference<Panel_HUD> m_HUD;

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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Fatigue), Member = "UpdateFatigueStatusOnHUD")]
	[Calls(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	public string GetFatigueStateString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public float GetNormalizedFatigue()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateFatigue")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyFatigueBuff")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(Infection), Member = "UpdateInfection")]
	[CalledBy(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[CalledBy(Type = typeof(FoodPoisoning), Member = "UpdateFoodPoisoning")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateDysentery")]
	[CalledBy(Type = typeof(BloodLoss), Member = "MaybeApplyDamage")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CalledBy(Type = typeof(FatigueBuff), Member = "Apply")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStimExitEffects")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[CallerCount(Count = 14)]
	public void AddFatigue(float fatigueValue)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsExhausted()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetCurrentTotalFatigueBurnPerHour()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void CalculateTotalFatigueBurnPerHour()
	{
	}

	[CallerCount(Count = 0)]
	private FatigueLevel GetFatigueLevel()
	{
		return default(FatigueLevel);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void DisplayFatigueOnHUDForTime(float seconds)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	private string GetFatigueTextForHud()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeUpdateFatigueStatusLabel()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateFatigueStatusOnHUD()
	{
	}

	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CallerCount(Count = 0)]
	private bool ShouldPlayFatigueVoiceOver()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CallsUnknownMethods(Count = 5)]
	private void MaybePlayFatigueVoiceOver()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeUpdateExhaustedStatusInLog()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	private float CalculateFatigueIncrease(float realtimeSeconds)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SuppressHeavyBreathing(bool suppress)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	public static void EndSuppressHeavyBreathingCallback()
	{
	}

	[CallerCount(Count = 0)]
	public void ResetMovementTimers()
	{
	}

	[CallerCount(Count = 0)]
	public void HeavyBreathingInit()
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	[CallsUnknownMethods(Count = 3)]
	private bool MovingUpIncline()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Fatigue), Member = "CatchBreath")]
	[Calls(Type = typeof(Fatigue), Member = "MovingUpIncline")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[CalledBy(Type = typeof(Fatigue), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Fatigue), Member = "MaybePlayFatigueVoiceOver")]
	[Calls(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	[Calls(Type = typeof(Fatigue), Member = "MovingUpIncline")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallerCount(Count = 1)]
	private void UpdateHeavyBreathing()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void UpdateDebugText(Panel_HUD hud)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HeavyBreathingState GetHeavyBreathingState()
	{
		return default(HeavyBreathingState);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	private void CatchBreath()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Fatigue), Member = "MovingUpIncline")]
	[Calls(Type = typeof(Fatigue), Member = "CatchBreath")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	private void MaybeCatchBreath()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateHeavyBreathingLoopRTPC()
	{
	}

	[CallerCount(Count = 0)]
	private void SetHeavyBreathingState(HeavyBreathingState state)
	{
	}

	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Fatigue), Member = "ComputeHeavyBreathingState")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Fatigue), Member = "ComputeHeavyBreathingState")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	private void MaybePlayHeavyBreathingLoop()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	[CallsUnknownMethods(Count = 1)]
	private HeavyBreathingState ComputeHeavyBreathingState(HeavyBreathingLevels thresholds)
	{
		return default(HeavyBreathingState);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HeavyBreathingShouldSuppressVO()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Fatigue()
	{
	}
}
