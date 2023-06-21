using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion;

public class PendingEvent
{
	public EventData m_Event;

	public string m_MissionId;

	[DeduplicatedMethod]
	[CallerCount(Count = 234)]
	public PendingEvent(EventData ev, string missionId)
	{
	}
}
