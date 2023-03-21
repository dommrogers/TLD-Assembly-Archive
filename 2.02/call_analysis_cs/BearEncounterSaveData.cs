using Cpp2ILInjected.CallAnalysis;

public class BearEncounterSaveData
{
	public float m_CurrentTimerSpawnSeconds;

	public float m_HoursPlayed;

	public string m_Guid;

	public BearEncounter.BearSpawnState m_BearSpawnState;

	public BearEncounter.BearSpawnEncounterResult m_LatestEncounterResult;

	public bool m_LastEncounter;

	public BearEncounter.PostStruggleBehavior m_PostStruggleBehavior;

	public bool m_IsEncounterEnabled;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public BearEncounterSaveData()
	{
	}
}
