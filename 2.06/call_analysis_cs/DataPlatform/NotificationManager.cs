using Cpp2ILInjected.CallAnalysis;
using UnityPlugin;

namespace DataPlatform;

public class NotificationManager
{
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static void SetNotificationPositionHint(NotificationPositionHint locationHint)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public NotificationManager()
	{
	}
}
