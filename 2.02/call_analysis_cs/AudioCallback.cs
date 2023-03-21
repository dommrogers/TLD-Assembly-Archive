using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AudioCallback : MonoBehaviour
{
	private bool m_DisableAudioEvents;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void ToggleDisableAudioEvents(bool toggle)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnAudioEvent(string audioEventName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "PlayStruggleAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnAudioStruggleEvent(string audioEventName)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 2)]
	public void OnAudioStruggleEventOneShot(string audioEventName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnPlayerVoiceEvent(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public AudioCallback()
	{
	}
}
