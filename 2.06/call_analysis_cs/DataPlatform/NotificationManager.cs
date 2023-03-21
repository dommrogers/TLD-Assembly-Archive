using Cpp2ILInjected.CallAnalysis;
using UnityPlugin;

namespace DataPlatform;

public class NotificationManager
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetNotificationPositionHint(NotificationPositionHint locationHint)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public NotificationManager()
	{
	}
}
