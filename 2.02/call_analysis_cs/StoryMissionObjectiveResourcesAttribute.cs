using System;
using Cpp2ILInjected.CallAnalysis;

public class StoryMissionObjectiveResourcesAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public StoryMissionObjectiveResourcesAttribute()
	{
	}
}
