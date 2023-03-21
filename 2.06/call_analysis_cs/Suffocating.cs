using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void BlockSuffocating(bool block)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSuffocatingBlocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AfflictionTriggerVolume), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(AfflictionTriggerVolume), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(AfflictionTriggerVolume), Member = "OnDisable")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_suffocating")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerCough), Member = "MaybeStart")]
	public void StartSuffocating(SuffocatingSettings suffocatingSettingsPrefab = null)
	{
	}

	[CalledBy(Type = typeof(AfflictionTriggerVolume), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AfflictionTriggerVolume), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_suffocating")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	[CalledBy(Type = typeof(Suffocating), Member = "ForceStopSuffocating")]
	[CallerCount(Count = 4)]
	public void MaybeStopSuffocating()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	public void ForceStopSuffocating(bool stopSilently)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSuffocatingTimeRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetSoffocatingTimeRemainingAsPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private void ApplySuffocation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplySuffocatingVisualEffect()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	public bool HasSuffocatingRisk()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Suffocating), Member = "StopSuffocating")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(Suffocating), Member = "Update")]
	[CalledBy(Type = typeof(Suffocating), Member = "Update")]
	[CalledBy(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[CalledBy(Type = typeof(Suffocating), Member = "ForceStopSuffocating")]
	[Calls(Type = typeof(PlayerCough), Member = "Stop")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallerCount(Count = 6)]
	private void StopAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	private void StopSuffocating()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public Suffocating()
	{
	}
}
