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

	[CalledBy(Type = typeof(Condition), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Condition), Member = "ResetAudio")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	public bool HasLowHealthEffect()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetCinematicBlurValue")]
	[Calls(Type = typeof(Condition), Member = "UpdateHeartbeatSound")]
	[Calls(Type = typeof(Condition), Member = "UpdateEarRingingSound")]
	[Calls(Type = typeof(Condition), Member = "UpdateMuffleSound")]
	[Calls(Type = typeof(Condition), Member = "UpdateConditionOnHUD")]
	[Calls(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Willpower), Member = "GetActive")]
	[Calls(Type = typeof(Condition), Member = "HasNonRiskAffliction")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "MaybeIncreaseConditionFromWillpower")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 39)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
		return 0f;
	}

	[CallerCount(Count = 0)]
	public bool IsConsideredDead()
	{
		return false;
	}

	[CalledBy(Type = typeof(StruggleDamageEvent), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ApplyBurnAffliction")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void MaybeShowPainEffect(float damage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void ShowPainEffect(float intensity, float intervalSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "ElectrocutionPulse")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
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

	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(StatusBar), Member = "GetReverseFillValueCondition")]
	[CalledBy(Type = typeof(StatusBar), Member = "GetBuffFillValueCondition")]
	[CalledBy(Type = typeof(StatusBar), Member = "IsBuffActive")]
	[CalledBy(Type = typeof(StatusBar), Member = "ShouldShowBuffedFillSprite")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbite")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	public float GetAdjustedMaxHP()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void DisplayConditionOnHUDForTime(float seconds)
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateCondition")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public bool IsDegrading()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionSprite")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionRiskSprite")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	public bool HasNonRiskAffliction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionRiskSprite")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbiteRisk")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public bool HasRiskAffliction()
	{
		return false;
	}

	[CalledBy(Type = typeof(StatusBar), Member = "IsDebuffActive")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForSorrow")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbite")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbiteRisk")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 36)]
	public bool HasAffliction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbite")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbiteRisk")]
	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[Calls(Type = typeof(Headache), Member = "GetHeadacheActive")]
	[Calls(Type = typeof(SprainPain), Member = "HasSprainPain")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 50)]
	public bool HasSpecificAffliction(AfflictionType afflictionType)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public bool HasBuff()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathString")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWithMoose")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthBear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(Condition), Member = "GetDeathFromAfflictionsUnlocalized")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "UpdateLabels")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetCauseOfDeathString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Condition), Member = "UpdateConditionOnHUD")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetConditionValueForInterfaceDisplay()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	public void DoFallThroughIceDeath()
	{
	}

	[CalledBy(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[CalledBy(Type = typeof(BodyCarry), Member = "PlayHoistEffortAudio")]
	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public bool IsPlayerVulnerable()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[CalledBy(Type = typeof(Condition), Member = "GetDeathFromAfflictions")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private string GetDeathFromAfflictionsUnlocalized()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "GetDeathFromAfflictionsUnlocalized")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetDeathFromAfflictions()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private string GetDeathFromSubConditionsText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Condition), Member = "PlayerDeath")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void PlayPlayerDeathAudio()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CalledBy(Type = typeof(Condition), Member = "KillPlayer")]
	[CalledBy(Type = typeof(Condition), Member = "DoFallThroughIceDeath")]
	[CalledBy(Type = typeof(Suffocating), Member = "Update")]
	[CalledBy(Type = typeof(SpotLightController), Member = "MissionFailure")]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Condition), Member = "PlayPlayerDeathAudio")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void PlayerDeath(string overrideCauseOfDeath = null)
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Willpower), Member = "GetActive")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void MaybeIncreaseConditionFromWillpower()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldPlayInjuredVoiceOver()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[Calls(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void MaybePlayPlayerInjuredVoiceOver()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	private uint GetAfflictionSwitch()
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	private ConditionLevel GetConditionLevel()
	{
		return default(ConditionLevel);
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Condition), Member = "GetConditionValueForInterfaceDisplay")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 58)]
	private void UpdateConditionOnHUD()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateHeartbeatSound()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateEarRingingSound()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Condition), Member = "SendMuffleRTPC")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateMuffleSound()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "DisableLowHealthEffects")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Condition), Member = "ApplyLowHealthStagger")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 66)]
	private void UpdateBlurEffect(float percentCondition, bool lowHealthStagger)
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(vp_FPSController), Member = "AddForce")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private void ApplyLowHealthStagger(float blurFrac, float speedFrac)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[CallerCount(Count = 3)]
	private void DisableLowHealthEffects()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void ResetLowHealthPitchAndRoll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void PlayDeathMusic()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybePlayNearDeathMusic()
	{
	}

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerStruggle), Member = "IsBlackedOutAfterStruggle")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorLegFeet")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetAutoWalkingEnabled")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 26)]
	private void AddHealth(float hp, DamageSource cause, bool showHPonHUD)
	{
	}

	[CallerCount(Count = 0)]
	private bool IsDamageSourceBlockedByClothing(DamageSource cause)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorLegFeet")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private float GetDamageReductionForCause(DamageSource cause)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Condition), Member = "UpdateMuffleSound")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SendMuffleRTPC(float audioParam)
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void ResetAudio()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "ShouldPlayInjuredVoiceOver")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[CalledBy(Type = typeof(Fatigue), Member = "ShouldPlayFatigueVoiceOver")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayFatigueVoiceOver")]
	[CalledBy(Type = typeof(Freezing), Member = "ShouldPlayFreezingVoiceOver")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybePlayPlayerFreezingVoiceOver")]
	[CalledBy(Type = typeof(Hunger), Member = "ShouldPlayHungerVoiceOver")]
	[CalledBy(Type = typeof(Hunger), Member = "MaybePlayPlayerHungryVoiceOver")]
	[CalledBy(Type = typeof(Thirst), Member = "ShouldPlayThirstVoiceOver")]
	[CalledBy(Type = typeof(Thirst), Member = "MaybePlayPlayerThirstVoiceOver")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static bool CanPlayConditionVO()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool ShouldPlayFx(AfflictionOptions options)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool ShouldDoAutoSave(AfflictionOptions options)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Condition()
	{
	}
}
