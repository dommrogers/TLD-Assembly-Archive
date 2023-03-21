using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class NotificationSaveData
{
	public List<NotificationFlagInfo> m_NotificationFlagInfo;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public NotificationSaveData()
	{
	}
}
