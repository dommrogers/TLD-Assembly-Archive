using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using TLD.Gameplay.Condition;
using TLD.Serialization;
using TLD.UI.Generics;
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

	private AK.Wwise.Event m_SlightlyInjuredAudio;

	private AK.Wwise.Event m_InjuredAudio;

	private AK.Wwise.Event m_VeryInjuredAudio;

	private AK.Wwise.Event m_NearDeathAudio;

	private AK.Wwise.Event m_DieAudio;

	private AK.Wwise.Event m_DieFromWolfAudio;

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

	private PanelReference<Panel_HUD> m_HUD;

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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(Condition), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 6)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	public bool HasLowHealthEffect()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Condition), Member = "HasNonRiskAffliction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetCinematicBlurValue")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "UpdateHeartbeatSound")]
	[Calls(Type = typeof(Condition), Member = "UpdateEarRingingSound")]
	[Calls(Type = typeof(Condition), Member = "UpdateMuffleSound")]
	[Calls(Type = typeof(Willpower), Member = "GetActive")]
	[Calls(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Condition), Member = "UpdateConditionOnHUD")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
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

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(StruggleDamageEvent), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ApplyBurnAffliction")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeShowPainEffect(float damage)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void ShowPainEffect(float intensity, float intervalSeconds)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ShowElectricalEffect(float intensity, float intervalSeconds)
	{
	}

	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallerCount(Count = 0)]
	public void AddHealthWithNoHudNotification(float hp, DamageSource damageSource)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	public void AddHealth(float hp, DamageSource cause)
	{
	}

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(StatusBar), Member = "GetReverseFillValueCondition")]
	[CalledBy(Type = typeof(StatusBar), Member = "GetBuffFillValueCondition")]
	[CalledBy(Type = typeof(StatusBar), Member = "IsBuffActive")]
	[CalledBy(Type = typeof(StatusBar), Member = "ShouldShowBuffedFillSprite")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Rest), Member = "UpdateCondition")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 6)]
	public bool IsDegrading()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionSprite")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionRiskSprite")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 11)]
	public bool HasNonRiskAffliction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionRiskSprite")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbiteRisk")]
	public bool HasRiskAffliction()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbite")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbiteRisk")]
	[CalledBy(Type = typeof(StatusBar), Member = "IsDebuffActive")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForSorrow")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 18)]
	public bool HasAffliction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetRisksCount")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(SprainPain), Member = "HasSprainPain")]
	[Calls(Type = typeof(Headache), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[Calls(Type = typeof(BrokenRib), Member = "HasBrokenRib")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbiteRisk")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbite")]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	public bool HasSpecificAffliction(AfflictionType afflictionType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "FreezingBuffActive")]
	public bool HasBuff()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
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

	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathString")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthBear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWithMoose")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Condition), Member = "GetDeathFromAfflictionsUnlocalized")]
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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	public string GetCauseOfDeathString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Condition), Member = "UpdateConditionOnHUD")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	public int GetConditionValueForInterfaceDisplay()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	public void DoFallThroughIceDeath()
	{
	}

	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(BodyCarry), Member = "PlayHoistEffortAudio")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CalledBy(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsPlayerVulnerable()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[CalledBy(Type = typeof(Condition), Member = "GetDeathFromAfflictions")]
	[CallsUnknownMethods(Count = 8)]
	private string GetDeathFromAfflictionsUnlocalized()
	{
		return null;
	}

	[Calls(Type = typeof(Condition), Member = "GetDeathFromAfflictionsUnlocalized")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	private string GetDeathFromAfflictions()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	private string GetDeathFromSubConditionsText()
	{
		return null;
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CalledBy(Type = typeof(Condition), Member = "PlayerDeath")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	private void PlayPlayerDeathAudio()
	{
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Condition), Member = "PlayPlayerDeathAudio")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CalledBy(Type = typeof(Condition), Member = "KillPlayer")]
	[CalledBy(Type = typeof(Condition), Member = "DoFallThroughIceDeath")]
	[CalledBy(Type = typeof(Suffocating), Member = "Update")]
	[CalledBy(Type = typeof(SpotLightController), Member = "MissionFailure")]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[CallsUnknownMethods(Count = 1)]
	private void PlayerDeath(string overrideCauseOfDeath = null)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeIncreaseConditionFromWillpower()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	private bool ShouldPlayInjuredVoiceOver()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void MaybePlayPlayerInjuredVoiceOver()
	{
	}

	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Condition), Member = "GetConditionValueForInterfaceDisplay")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void UpdateConditionOnHUD()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void UpdateHeartbeatSound()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateEarRingingSound()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[Calls(Type = typeof(Condition), Member = "SendMuffleRTPC")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Condition), Member = "SendMuffleRTPC")]
	private void UpdateMuffleSound()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[Calls(Type = typeof(Condition), Member = "DisableLowHealthEffects")]
	[Calls(Type = typeof(Condition), Member = "DisableLowHealthEffects")]
	[Calls(Type = typeof(Condition), Member = "ApplyLowHealthStagger")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Condition), Member = "DisableLowHealthEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	private void UpdateBlurEffect(float percentCondition, bool lowHealthStagger)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private void ApplyLowHealthStagger(float blurFrac, float speedFrac)
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[CalledBy(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[CalledBy(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	private void DisableLowHealthEffects()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetLowHealthPitchAndRoll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	private void PlayDeathMusic()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	private void MaybePlayNearDeathMusic()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorLegFeet")]
	[Calls(Type = typeof(PlayerStruggle), Member = "IsBlackedOutAfterStruggle")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 36)]
	private void AddHealth(float hp, DamageSource cause, bool showHPonHUD)
	{
	}

	[CallerCount(Count = 0)]
	private bool IsDamageSourceBlockedByClothing(DamageSource cause)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorLegFeet")]
	private float GetDamageReductionForCause(DamageSource cause)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(Condition), Member = "UpdateMuffleSound")]
	[CalledBy(Type = typeof(Condition), Member = "UpdateMuffleSound")]
	private void SendMuffleRTPC(float audioParam)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 4)]
	private void ResetAudio()
	{
	}

	[CalledBy(Type = typeof(Freezing), Member = "MaybePlayPlayerFreezingVoiceOver")]
	[CalledBy(Type = typeof(Freezing), Member = "ShouldPlayFreezingVoiceOver")]
	[CalledBy(Type = typeof(Hunger), Member = "ShouldPlayHungerVoiceOver")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayFatigueVoiceOver")]
	[CalledBy(Type = typeof(Thirst), Member = "ShouldPlayThirstVoiceOver")]
	[CalledBy(Type = typeof(Thirst), Member = "MaybePlayPlayerThirstVoiceOver")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Hunger), Member = "MaybePlayPlayerHungryVoiceOver")]
	[CalledBy(Type = typeof(Fatigue), Member = "ShouldPlayFatigueVoiceOver")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CalledBy(Type = typeof(Condition), Member = "ShouldPlayInjuredVoiceOver")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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
	public Condition()
	{
	}
}
