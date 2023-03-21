using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Suffocating : MonoBehaviour
{
	public LocalizedString m_SufocatingRiskLocalizedString;

	public LocalizedString m_SufocatingDescription;

	public LocalizedString m_SufocatingTreatment;

	public LocalizedString m_SuffocatingCause;

	public string m_SuffocatingRiskIcon;

	public float m_SuffocatingDelayTimerSeconds;

	public float m_SuffocatingTimerSeconds;

	public float m_SuffocatingVFXDurationSeconds;

	public MinMax m_SuffocatingVisualEffectStrengthRange;

	public AnimationCurve m_SuffocatingVisualEffectStrength;

	public string m_NoBreathingSound;

	public float m_NoBreathingSoundDelayTimeMinSeconds;

	public float m_NoBreathingSoundDelayTimeMaxSeconds;

	public string m_AudioEvent;

	private static SuffocatingSaveDataProxy m_SuffocatingSaveDataProxy;

	private bool m_IsSuffocating;

	private int m_SuffocatingTriggerCounter;

	private float m_SuffocatingDelayTimeRemaining;

	private float m_SuffocatingTimeRemaining;

	private float m_SoundDelayTimeRemaining;

	private float m_SuffocatingVisualEffectTimer;

	private float m_SuffocatingTimerSecondsOverride;

	private bool m_BlockSuffocating;

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void BlockSuffocating(bool block)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsSuffocatingBlocked()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AfflictionTriggerVolume), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_suffocating")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerCough), Member = "MaybeStart")]
	[CalledBy(Type = typeof(AfflictionTriggerVolume), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(AfflictionTriggerVolume), Member = "OnDisable")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	public void StartSuffocating(SuffocatingSettings suffocatingSettingsPrefab = null)
	{
	}

	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AfflictionTriggerVolume), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_suffocating")]
	[CalledBy(Type = typeof(AfflictionTriggerVolume), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	[CalledBy(Type = typeof(Suffocating), Member = "ForceStopSuffocating")]
	public void MaybeStopSuffocating()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	public void ForceStopSuffocating(bool stopSilently)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetSuffocatingTimeRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetSoffocatingTimeRemainingAsPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private void ApplySuffocation()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Suffocating), Member = "Update")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "SuffocationPulse")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void ApplySuffocatingVisualEffect()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Suffocating), Member = "ApplySuffocatingVisualEffect")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSuffocating()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public bool HasSuffocatingRisk()
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Suffocating), Member = "ForceStopSuffocating")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerCough), Member = "Stop")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(Suffocating), Member = "StopSuffocating")]
	[CalledBy(Type = typeof(Suffocating), Member = "Update")]
	[CalledBy(Type = typeof(Suffocating), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void StopAudio()
	{
	}

	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	[CallerCount(Count = 0)]
	private void StopSuffocating()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public Suffocating()
	{
	}
}
