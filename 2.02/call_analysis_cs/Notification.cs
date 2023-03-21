using System;
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Notification(Notifications.Data d)
	{
	}

	[CalledBy(Type = typeof(Notifications), Member = "LoadNotifications")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "TryParse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Notification(WebNotification wn)
	{
	}
}
