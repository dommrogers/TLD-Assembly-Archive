using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Audio.SimpleAudio;

public class BaseSimpleAudioComponent : MonoBehaviour
{
	public bool m_IsGameObjectStatic;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnValidate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsStatic()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public BaseSimpleAudioComponent()
	{
	}
}
