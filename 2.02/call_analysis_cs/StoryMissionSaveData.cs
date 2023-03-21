using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class StoryMissionSaveData
{
	public List<StoryMissionInfo> m_MissionInfo;

	public List<StoryMissionObjective> m_ObjectiveInfo;

	public bool m_HasBeenUpdated;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public StoryMissionSaveData()
	{
	}
}
