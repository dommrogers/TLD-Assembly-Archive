using System;
using Cpp2ILInjected.CallAnalysis;

public class StoryMissionObjectiveResourcesAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public StoryMissionObjectiveResourcesAttribute()
	{
	}
}
