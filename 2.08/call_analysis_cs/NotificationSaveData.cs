using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class NotificationSaveData
{
	public List<NotificationFlagInfo> m_NotificationFlagInfo;

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public NotificationSaveData()
	{
	}
}
