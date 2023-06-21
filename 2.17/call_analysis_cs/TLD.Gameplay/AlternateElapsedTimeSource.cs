using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public abstract class AlternateElapsedTimeSource : ScriptableObject
{
	public abstract float GetElapsedTimeInHours();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected AlternateElapsedTimeSource()
	{
	}
}
