using Cpp2ILInjected.CallAnalysis;

public class WebNotification
{
	public string name;

	public string localizedTitle;

	public string localizedScrollableText;

	public string tellMeMoreUrl;

	public string backgroundImageUrl;

	public string startDate;

	public string endDate;

	public string customNotificationType;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public WebNotification()
	{
	}
}
