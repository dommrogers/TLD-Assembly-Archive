using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class Condition : MonoBehaviour
{
	public float m_CurrentHP;

	public float m_MaxHP;

	public float m_CriticalHP;

	public float m_TimeToDisplayConditionWhenChanged;

	public float m_TimeToDisplayConditionDelta;

	public float m_HPIncreasePerDayWhileHealthy;

	public float m_HPDecreasePerDayFromStarving;

	public float m_HPDecreasePerDayFromDehydration;

	public float m_HPDecreasePerDayFromExhaustion;

	public float m_HPDecreasePerDayFromFreezing;

	public float m_SlightlyInjuredThreshold;

	public float m_InjuredThreshold;

	public float m_VeryInjuredThreshold;

	public float m_NearDeathThreshold;

	public float m_HeartbeatThreshold;

	public string m_SlightlyInjuredVoiceOver;

	public string m_InjuredVoiceOver;

	public string m_VeryInjuredVoiceOver;

	public string m_NearDeathVoiceOver;

	public string m_DieVoiceOver;

	public string m_DieFromWolfVoiceOver;

	public float m_MinSecondsBetweenVoiceOverVariations;

	public float m_MinSecondsBetweenVoiceOverVariationsWhileBleeding;

	public float m_HPToStartBlur;

	public float m_HPForMaxBlur;

	public float m_BlurStartVal;

	public float m_BlurMaxVal;

	public float m_EarRingingLengthIndoors;

	public float m_EarRingingDelay;

	public float m_EarRingingFadeInTime;

	public float m_EarRingingMuffleDelay;

	public float m_EarRingingMuffleFadeInTime;

	public float m_SoundMufflingMaxValue;

	public bool m_NeverDie;

	public bool m_Invulnerable;

	public bool m_HideDamageEvents;

	public bool m_ForceUncrouched;

	public int m_OverrideBlurLevel;

	public float m_ConditionBlurNoiseStepMin;

	public float m_ConditionBlurNoiseStepMax;

	public float m_ConditionBlurMinOffsetRange;

	public float m_ConditionBlurMaxOffsetRange;

	public float m_ConditionMinScreenFadeAmount;

	public float m_ConditionMaxScreenFadeAmount;

	public float m_ConditionBlur2Min;

	public float m_ConditionBlur2Max;

	public float m_StaggerNoiseStepMin;

	public float m_StaggerNoiseStepMax;

	public float m_StaggerForward;

	public float m_StaggerSide;

	public float m_StaggerRoll;

	public float m_StaggerForwardMotionFrac;

	public float m_StaggerSideMotionFrac;

	public float m_StaggerRollMotionFrac;

	public float m_RestingPitchMin;

	public float m_RestingPitchMax;

	public float m_RestingRollMin;

	public float m_RestingRollMax;

	public float m_MaxVelocityForSpeedFracCalc;

	public float m_StaggerForceScalar;

	private static Vector2 m_NoiseStep;

	private Vector2 m_ConditionBlurNoisePos;

	private Vector2 m_StaggerNoisePos;

	private float m_BasePitch;

	private float m_BaseRoll;

	private float m_RestingRollDirection;

	private ConditionLevel m_ConditionLevelForPreviousVoiceOver;

	private float m_NumSecondsSinceLastVoiceOver;

	private float m_TimeDisableConditionOnHUD;

	private float m_HealthDelta;

	private float m_TimeStopDisplayHealthDelta;

	private DamageSource m_CauseOfDeath;

	private bool m_SleepingWhenKilled;

	private uint m_HeartbeatAudioId;

	private uint m_EarRingingAudioId;

	private float m_EarRingingAudioParam;

	private float m_TimeToDelayEarRinging;

	private float m_TimeToFadeEarRinging;

	private float m_TimeToDelaySoundMuffling;

	private float m_TimeToFadeSoundMuffling;

	private float m_LastBurnDamageEffectTime;

	private float m_LastElectricalEffectTime;

	private float m_LastHeartBeatRTPCSent;

	private float m_LastMuffleRTPCSent;

	private MotionBlur[] m_BlurEffects;

	private bool m_CanPlayNearDeathMusic;

	private bool m_StartHasBeenCalled;

	private bool m_SuppressVoiceOver;

	private float m_DeltaTimeAccumulator;

	private static ConditionSaveDataProxy m_ConditionSaveDataProxy;

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(Condition), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Condition), Member = "ResetAudio")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	public bool HasLowHealthEffect()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Condition), Member = "HasNonRiskAffliction")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Willpower), Member = "GetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Condition), Member = "MaybeIncreaseConditionFromWillpower")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[Calls(Type = typeof(Condition), Member = "UpdateConditionOnHUD")]
	[Calls(Type = typeof(Condition), Member = "UpdateMuffleSound")]
	[Calls(Type = typeof(Condition), Member = "UpdateEarRingingSound")]
	[Calls(Type = typeof(Condition), Member = "UpdateHeartbeatSound")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetCinematicBlurValue")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Condition), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void ForceKill()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	public void KillPlayer(DamageSource damageSource, string overrideCauseOfDeath = null)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetNormalizedCondition()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public bool IsConsideredDead()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CalledBy(Type = typeof(StruggleDamageEvent), Member = "ApplyDamage")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ApplyBurnAffliction")]
	public void MaybeShowPainEffect(float damage)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void ShowPainEffect(float intensity, float intervalSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "ElectrocutionPulse")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void ShowElectricalEffect(float intensity, float intervalSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	public void AddHealthWithNoHudNotification(float hp, DamageSource damageSource)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	public void AddHealth(float hp, DamageSource cause)
	{
	}

	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[CalledBy(Type = typeof(StatusBar), Member = "ShouldShowBuffedFillSprite")]
	[CalledBy(Type = typeof(StatusBar), Member = "IsBuffActive")]
	[CalledBy(Type = typeof(StatusBar), Member = "GetBuffFillValueCondition")]
	[CalledBy(Type = typeof(StatusBar), Member = "GetReverseFillValueCondition")]
	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbite")]
	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	public float GetAdjustedMaxHP()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void DisplayConditionOnHUDForTime(float seconds)
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateCondition")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	public bool IsDegrading()
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionSprite")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionRiskSprite")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	public bool HasNonRiskAffliction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionRiskSprite")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbiteRisk")]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public bool HasRiskAffliction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(StatusBar), Member = "IsDebuffActive")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbite")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbiteRisk")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForSorrow")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool HasAffliction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 50)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[Calls(Type = typeof(SprainPain), Member = "HasSprainPain")]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbiteRisk")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbite")]
	[Calls(Type = typeof(Headache), Member = "GetHeadacheActive")]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	public bool HasSpecificAffliction(AfflictionType afflictionType)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool HasBuff()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	public void StartEarRinging(bool allowOutdoors = false)
	{
	}

	[CallerCount(Count = 0)]
	public void ForceStartEarRinging()
	{
	}

	[CallerCount(Count = 0)]
	public void SetCauseOfDeath(DamageSource cause)
	{
	}

	[Calls(Type = typeof(Condition), Member = "GetDeathFromAfflictionsUnlocalized")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthBear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWithMoose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathString")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	public string GetCauseOfDeathStringUntranslated()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DamageSource GetCauseOfDeath()
	{
		return default(DamageSource);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "UpdateLabels")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	public string GetCauseOfDeathString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(Condition), Member = "UpdateConditionOnHUD")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	public int GetConditionValueForInterfaceDisplay()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	public void DoFallThroughIceDeath()
	{
	}

	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CalledBy(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[CalledBy(Type = typeof(BodyCarry), Member = "PlayHoistEffortAudio")]
	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[CallerCount(Count = 4)]
	public bool IsPlayerVulnerable()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Condition), Member = "GetDeathFromAfflictions")]
	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private string GetDeathFromAfflictionsUnlocalized()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Condition), Member = "GetDeathFromAfflictionsUnlocalized")]
	[CallerCount(Count = 0)]
	private string GetDeathFromAfflictions()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 8)]
	private string GetDeathFromSubConditionsText()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CalledBy(Type = typeof(Condition), Member = "PlayerDeath")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	private void PlayPlayerDeathAudio()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "DoFallThroughIceDeath")]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CalledBy(Type = typeof(Condition), Member = "KillPlayer")]
	[CalledBy(Type = typeof(Suffocating), Member = "Update")]
	[CalledBy(Type = typeof(SpotLightController), Member = "MissionFailure")]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(Condition), Member = "PlayPlayerDeathAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	private void PlayerDeath(string overrideCauseOfDeath = null)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Willpower), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void MaybeIncreaseConditionFromWillpower()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldPlayInjuredVoiceOver()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CallerCount(Count = 1)]
	private void MaybePlayPlayerInjuredVoiceOver()
	{
	}

	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	private uint GetAfflictionSwitch()
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	private ConditionLevel GetConditionLevel()
	{
		return default(ConditionLevel);
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Condition), Member = "GetConditionValueForInterfaceDisplay")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 58)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	private void UpdateConditionOnHUD()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void UpdateHeartbeatSound()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void UpdateEarRingingSound()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "SendMuffleRTPC")]
	[Calls(Type = typeof(Condition), Member = "SendMuffleRTPC")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void UpdateMuffleSound()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[Calls(Type = typeof(Condition), Member = "DisableLowHealthEffects")]
	[Calls(Type = typeof(Condition), Member = "DisableLowHealthEffects")]
	[Calls(Type = typeof(Condition), Member = "ApplyLowHealthStagger")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[CallsUnknownMethods(Count = 66)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Condition), Member = "DisableLowHealthEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void UpdateBlurEffect(float percentCondition, bool lowHealthStagger)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(vp_FPSController), Member = "AddForce")]
	[CalledBy(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void ApplyLowHealthStagger(float blurFrac, float speedFrac)
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[CalledBy(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[CalledBy(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[CallerCount(Count = 3)]
	[CallAnalysisFailed]
	private void DisableLowHealthEffects()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void ResetLowHealthPitchAndRoll()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	private void PlayDeathMusic()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void MaybePlayNearDeathMusic()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorLegFeet")]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetAutoWalkingEnabled")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(PlayerStruggle), Member = "IsBlackedOutAfterStruggle")]
	private void AddHealth(float hp, DamageSource cause, bool showHPonHUD)
	{
	}

	[CallerCount(Count = 0)]
	private bool IsDamageSourceBlockedByClothing(DamageSource cause)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorLegFeet")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	private float GetDamageReductionForCause(DamageSource cause)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Condition), Member = "UpdateMuffleSound")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(Condition), Member = "UpdateMuffleSound")]
	private void SendMuffleRTPC(float audioParam)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Condition), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void ResetAudio()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CalledBy(Type = typeof(Condition), Member = "ShouldPlayInjuredVoiceOver")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayFatigueVoiceOver")]
	[CalledBy(Type = typeof(Thirst), Member = "MaybePlayPlayerThirstVoiceOver")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Thirst), Member = "ShouldPlayThirstVoiceOver")]
	[CalledBy(Type = typeof(Hunger), Member = "MaybePlayPlayerHungryVoiceOver")]
	[CalledBy(Type = typeof(Hunger), Member = "ShouldPlayHungerVoiceOver")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybePlayPlayerFreezingVoiceOver")]
	[CalledBy(Type = typeof(Fatigue), Member = "ShouldPlayFatigueVoiceOver")]
	[CalledBy(Type = typeof(Freezing), Member = "ShouldPlayFreezingVoiceOver")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	public static bool CanPlayConditionVO()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool ShouldPlayFx(AfflictionOptions options)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool ShouldDoAutoSave(AfflictionOptions options)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Condition()
	{
	}
}
