using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public class NowhereToHideElapsedTimeSource : AlternateElapsedTimeSource
{
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override float GetElapsedTimeInHours()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public NowhereToHideElapsedTimeSource()
	{
	}
}
