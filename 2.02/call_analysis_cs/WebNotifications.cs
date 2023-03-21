using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class WebNotifications
{
	public string serverTime;

	public string real_server_time;

	public string fake_server_time;

	public List<WebNotification> notifications;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public WebNotifications()
	{
	}
}
