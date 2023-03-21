using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class LogDayInfo
{
	public int m_DayNumber;

	public string m_Notes;

	public int m_WorldExplored;

	public int m_HoursRested;

	public int m_ConditionLow;

	public int m_ConditionHigh;

	public int m_CaloriesBurned;

	public List<AfflictionType> m_Afflictions;

	public List<string> m_LocationLocIDs;

	public List<string> m_RegionLocIDs;

	public List<string> m_RegionSceneNames;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LogDayInfo()
	{
	}
}
