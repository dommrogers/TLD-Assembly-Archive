using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BaseSimpleAudioComponent : MonoBehaviour
{
	public bool m_IsGameObjectStatic;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsStatic()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BaseSimpleAudioComponent()
	{
	}
}
