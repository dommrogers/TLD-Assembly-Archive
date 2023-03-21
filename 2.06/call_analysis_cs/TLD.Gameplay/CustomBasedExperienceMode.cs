using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public class CustomBasedExperienceMode : CustomExperienceMode
{
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CustomBasedExperienceMode()
	{
	}
}
