using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public abstract class AlternateElapsedTimeSource : ScriptableObject
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	public abstract float GetElapsedTimeInHours();

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected AlternateElapsedTimeSource()
	{
	}
}
