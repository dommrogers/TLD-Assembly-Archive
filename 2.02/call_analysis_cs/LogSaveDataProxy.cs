using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class LogSaveDataProxy
{
	public string m_GeneralNotes;

	public List<LogDayInfo> m_LogDayInfoList;

	public LogDayInfo m_TodayLogDayInfo;

	public int m_DayToLogEndOfDayInfo;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LogSaveDataProxy()
	{
	}
}
