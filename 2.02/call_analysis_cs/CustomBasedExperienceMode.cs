using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CustomBasedExperienceMode : CustomExperienceMode
{
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CustomBasedExperienceMode()
	{
	}
}
