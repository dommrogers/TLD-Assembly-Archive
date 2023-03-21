using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class NotificationSaveData
{
	public List<NotificationFlagInfo> m_NotificationFlagInfo;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public NotificationSaveData()
	{
	}
}
