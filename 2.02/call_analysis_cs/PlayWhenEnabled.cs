using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayWhenEnabled : MonoBehaviour
{
	public string m_Audio;

	private uint m_AudioID;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PlayWhenEnabled()
	{
	}
}
