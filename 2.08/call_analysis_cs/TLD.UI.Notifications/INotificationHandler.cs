using Cpp2ILInjected.CallAnalysis;

namespace TLD.UI.Notifications;

public interface INotificationHandler
{
	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void ResetNotificationsData();
}
