using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CustomBasedExperienceMode : CustomExperienceMode
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CustomBasedExperienceMode()
	{
	}
}
