using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AudioCallback : MonoBehaviour
{
	private bool m_DisableAudioEvents;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ToggleDisableAudioEvents(bool toggle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnAudioEvent(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 2)]
	public void OnAudioStruggleEvent(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 1)]
	public void OnAudioStruggleEventOneShot(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	public void OnPlayerVoiceEvent(string audioEventName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AudioCallback()
	{
	}
}
