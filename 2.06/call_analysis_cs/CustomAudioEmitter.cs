using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CustomAudioEmitter : MonoBehaviour
{
	public CustomEmitterType m_CustomEmitterType;

	public string m_SoundName;

	private uint m_AudioInstance;

	private static Dictionary<CustomEmitterType, List<CustomAudioEmitter>> s_CustomAudioEmitter;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeUpdateInteriorAudio")]
	[CallsUnknownMethods(Count = 6)]
	public static void Enable(CustomEmitterType type, bool enable)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public CustomAudioEmitter()
	{
	}
}
