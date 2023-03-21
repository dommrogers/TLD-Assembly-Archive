using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AudioToggle : MonoBehaviour
{
	public string m_LoopAudio;

	public string m_TurnOffAudio;

	public bool m_StartOn;

	private uint m_LoopAudioID;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AudioToggle), Member = "TurnOn")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AudioToggle), Member = "TurnOn")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void TurnOff()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(AudioToggle), Member = "Start")]
	[CalledBy(Type = typeof(AudioToggle), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 1)]
	private void TurnOn()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AudioToggle()
	{
	}
}
