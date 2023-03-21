using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class NotificationSaveData
{
	public List<NotificationFlagInfo> m_NotificationFlagInfo;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public NotificationSaveData()
	{
	}
}
