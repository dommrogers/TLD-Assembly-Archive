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
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeUpdateInteriorAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public static void Enable(CustomEmitterType type, bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public CustomAudioEmitter()
	{
	}
}
