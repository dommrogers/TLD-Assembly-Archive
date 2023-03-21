using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BaseSimpleAudioComponent : MonoBehaviour
{
	public bool m_IsGameObjectStatic;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BaseSimpleAudioComponent()
	{
	}
}
