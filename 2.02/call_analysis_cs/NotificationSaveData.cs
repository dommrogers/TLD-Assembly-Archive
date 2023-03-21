using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class NotificationSaveData
{
	public List<NotificationFlagInfo> m_NotificationFlagInfo;

	[CalledBy(Type = typeof(NotificationFlagManager), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public NotificationSaveData()
	{
	}
}
