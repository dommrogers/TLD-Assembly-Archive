using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class StoryMissionInfo
{
	public string missionID;

	public string nameLocID;

	public string descriptionLocID;

	public string textureName;

	public bool isActive;

	public bool completedSuccessfully;

	public string timerID;

	public bool isSideMission;

	public string m_NPC_ID;

	public float m_TrustDecayGracePeriodHours;

	public string chapterLocID;

	public bool showWhenCompleted;

	public string icon;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public StoryMissionInfo()
	{
	}
}
