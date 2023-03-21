using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityPlugin;

namespace DataPlatform;

public class NotificationManagerPlugin
{
	[PreserveSig]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void NotificationManager_SetNotificationPositionHint(NotificationPositionHint locationHint);

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public NotificationManagerPlugin()
	{
	}
}
