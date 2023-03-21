using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraActivatedAudio : MonoBehaviour
{
	public string m_Audio;

	public float m_ChancePlayAudioEachRoll;

	public float m_GameHoursBetweenRolls;

	public float m_MinDurationGameMinutes;

	public float m_MaxDurationGameMinutes;

	public GameAudioAiEvent m_GameAudioAiEvent;

	private uint m_AudioID;

	private float m_GameMinutesToPlayLoop;

	private float m_ElapsedGameMinutesPlaying;

	private float m_GameHoursSinceLastRoll;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeStopAudioLoop()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void MaybeStartAudioLoop()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraActivatedAudio()
	{
	}
}
