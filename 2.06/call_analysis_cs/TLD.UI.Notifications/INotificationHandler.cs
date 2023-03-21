using Cpp2ILInjected.CallAnalysis;

namespace TLD.UI.Notifications;

public interface INotificationHandler
{
	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	void ResetNotificationsData();
}
