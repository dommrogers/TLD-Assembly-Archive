using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Notification
{
	public string m_Name;

	public string m_LocalizedTitle;

	public string m_LocalizedScrollableText;

	public string m_TellMeMoreUrl;

	public string m_BackgroundImageUrl;

	public Texture2D m_BackgroundImage;

	public CustomNotificationType m_CustomNotificationType;

	[CalledBy(Type = typeof(Notifications), Member = "LoadNotifications")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public Notification(Notifications.Data d)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Notifications), Member = "LoadNotifications")]
	[CallsUnknownMethods(Count = 1)]
	public Notification(WebNotification wn)
	{
	}
}
