using Cpp2ILInjected.CallAnalysis;

public class BearEncounterInfo
{
	public BearEncounter.BearSpawnEncounterResult m_LatestEncounterResult;

	public bool m_IsActivated;

	public bool m_IsLastEncounter;

	public BearEncounter.PostStruggleBehavior m_PostStruggleBehavior;

	public string m_MissionObjectId;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public BearEncounterInfo()
	{
	}
}
