using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CustomAudioEmitter : MonoBehaviour
{
	public CustomEmitterType m_CustomEmitterType;

	public string m_SoundName;

	private uint m_AudioInstance;

	private static Dictionary<CustomEmitterType, List<CustomAudioEmitter>> s_CustomAudioEmitter;

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeUpdateInteriorAudio")]
	[CallsUnknownMethods(Count = 6)]
	public static void Enable(CustomEmitterType type, bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnDestroy()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public CustomAudioEmitter()
	{
	}
}
