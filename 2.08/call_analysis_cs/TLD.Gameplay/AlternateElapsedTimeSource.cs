using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public abstract class AlternateElapsedTimeSource : ScriptableObject
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract float GetElapsedTimeInHours();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected AlternateElapsedTimeSource()
	{
	}
}
