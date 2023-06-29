using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using TLD.BigCarry;
using TLD.Gameplay.Condition;
using TLD.Gear;
using TLD.SaveState;
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

	[CalledBy(Type = typeof(Condition), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	public bool HasLowHealthEffect()
	{
		return false;
	}

	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
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
	[Calls(Type = typeof(Condition), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "GetMaxHPModifier")]
	public float GetAdjustedMaxHP()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(StatusBar), Member = "GetFillValuesCondition")]
	[CalledBy(Type = typeof(StatusBar), Member = "IsBuffActive")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_condition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[CalledBy(Type = typeof(FoodMaxStatBuffManager), Member = "AddStatBuff")]
	[CalledBy(Type = typeof(FoodMaxStatBuffManager), Member = "AddStatValue")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(FoodMaxStatBuffManager), Member = "GetStatBuff")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	public float GetMaxHPModifier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(FoodMaxStatBuffManager), Member = "AddStatBuff")]
	[CalledBy(Type = typeof(FoodMaxStatBuffManager), Member = "AddStatValue")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void DisplayConditionOnHUDForTime(float seconds)
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateCondition")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public bool IsDegrading()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionSprite")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionRiskSprite")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeAbortReadingWithHUDMessage")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public bool HasNonRiskAffliction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionRiskSprite")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbiteRisk")]
	[CallsUnknownMethods(Count = 6)]
	public bool HasRiskAffliction()
	{
		return false;
	}

	[CalledBy(Type = typeof(StatusBar), Member = "IsDebuffActive")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForSorrow")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbite")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbiteRisk")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	public bool HasAffliction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[CalledBy(Type = typeof(Condition), Member = "GetAfflictionSwitch")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbite")]
	[Calls(Type = typeof(Frostbite), Member = "HasFrostbiteRisk")]
	[Calls(Type = typeof(BrokenRib), Member = "HasBrokenRib")]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[Calls(Type = typeof(Headache), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(SprainPain), Member = "HasSprainPain")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetRisksCount")]
	[Calls(Type = typeof(PlayerManager), Member = "HasIngestedCarryCapacityDebuff")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 30)]
	public bool HasSpecificAffliction(AfflictionType afflictionType)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "FreezingBuffActive")]
	[CallsUnknownMethods(Count = 3)]
	public bool HasBuff()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
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
	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWithMoose")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthBear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(Condition), Member = "GetDeathFromAfflictionsUnlocalized")]
	[CallsUnknownMethods(Count = 3)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetCauseOfDeathString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Condition), Member = "UpdateConditionOnHUD")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
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
	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "PlayHoistEffortAudio")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
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
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	private string GetDeathFromAfflictionsUnlocalized()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "GetDeathFromAfflictionsUnlocalized")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetDeathFromAfflictions()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	private string GetDeathFromSubConditionsText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsUnknownMethods(Count = 3)]
	private void PlayPlayerDeathAudio()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CalledBy(Type = typeof(Condition), Member = "KillPlayer")]
	[CalledBy(Type = typeof(Condition), Member = "DoFallThroughIceDeath")]
	[CalledBy(Type = typeof(Suffocating), Member = "Update")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallsUnknownMethods(Count = 3)]
	private void PlayerDeath(string overrideCauseOfDeath = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeIncreaseConditionFromWillpower()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	private bool ShouldPlayInjuredVoiceOver()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 5)]
	private void MaybePlayPlayerInjuredVoiceOver()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
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
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Condition), Member = "GetConditionValueForInterfaceDisplay")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 8)]
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
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateHeartbeatSound()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateEarRingingSound()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "SendMuffleRTPC")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateMuffleSound()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "DisableLowHealthEffects")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Condition), Member = "ApplyLowHealthStagger")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateBlurEffect(float percentCondition, bool lowHealthStagger)
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "UpdateBlurEffect")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 38)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerStruggle), Member = "IsBlackedOutAfterStruggle")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorLegFeet")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[Calls(Type = typeof(Condition), Member = "GetMaxHPModifier")]
	[Calls(Type = typeof(Condition), Member = "DisplayConditionOnHUDForTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
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
	[CallsUnknownMethods(Count = 2)]
	private float GetDamageReductionForCause(DamageSource cause)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Condition), Member = "UpdateMuffleSound")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void SendMuffleRTPC(float audioParam)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
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
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
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
	public Condition()
	{
	}
}
