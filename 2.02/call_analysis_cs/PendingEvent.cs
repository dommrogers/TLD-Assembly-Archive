using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion;

public class PendingEvent
{
	public EventData m_Event;

	public string m_MissionId;

	[CallerCount(Count = 83)]
	[DeduplicatedMethod]
	public PendingEvent(EventData ev, string missionId)
	{
	}
}
