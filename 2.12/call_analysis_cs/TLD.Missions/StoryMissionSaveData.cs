using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Missions;

public class StoryMissionSaveData
{
	public List<StoryMissionInfo> m_MissionInfo;

	public List<StoryMissionObjective> m_ObjectiveInfo;

	public bool m_HasBeenUpdated;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public StoryMissionSaveData()
	{
	}
}
