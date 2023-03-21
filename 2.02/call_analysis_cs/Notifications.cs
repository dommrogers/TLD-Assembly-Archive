using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Notifications : ScriptableObject
{
	[Serializable]
	public class Data
	{
		public string m_Name;

		public string m_TitleLocId;

		public string m_ScrollableTextLocId;

		public string m_TellMeMoreUrl;

		public Texture2D m_BackgroundImage;

		public string m_StartDate;

		public string m_EndDate;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public Data()
		{
		}
	}

	public enum Options
	{
		None,
		IncludeViewed
	}

	private bool m_ExcludeViewed;

	private string m_StagingServerQueryUrl;

	private string m_LiveServerQueryUrl;

	private string m_LanguageField;

	private string m_PlatformField;

	private List<Data> m_Notifications;

	private WebNotifications m_WebNotifications;

	private List<Notification> m_LoadedData;

	private DateTime m_LastRefreshTime;

	private Options m_LastRefreshOptions;

	private WebNotifications m_LastWebNotifications;

	private string m_LastLanguage;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Notifications), Member = "GetValidNotifications")]
	[CallsUnknownMethods(Count = 1)]
	public int GetCount(Options opts)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Notifications), Member = "GetCount")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "HasNotifications")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "Enable")]
	[CalledBy(Type = typeof(Notifications), Member = "HasNotifications")]
	[Calls(Type = typeof(Notifications), Member = "LoadNotifications")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction")]
	[Calls(Type = typeof(TimeSpan), Member = "FromHours")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public List<Notification> GetValidNotifications(Options opts)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Notifications), Member = "GetValidNotifications")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool HasNotifications(Options opts)
	{
		return default(bool);
	}

	[Calls(Type = typeof(DateTime), Member = "Parse")]
	[CalledBy(Type = typeof(Notifications), Member = "ParseJson")]
	[CalledBy(Type = typeof(Notifications), Member = "GetValidNotifications")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Notification), Member = ".ctor")]
	[Calls(Type = typeof(DateTime), Member = "Parse")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "HasNotificationBeenViewed")]
	[Calls(Type = typeof(DateTime), Member = "Parse")]
	[Calls(Type = typeof(Notification), Member = ".ctor")]
	[Calls(Type = typeof(DateTime), Member = "Parse")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "HasNotificationBeenViewed")]
	[Calls(Type = typeof(Notifications), Member = "Validate")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Notifications), Member = "Validate")]
	private void LoadNotifications(Options opts)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Notifications), Member = "LoadNotifications")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(DateTime), Member = "Parse")]
	[Calls(Type = typeof(DateTime), Member = "Parse")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	private bool Validate(Data d)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Notifications), Member = "LoadNotifications")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DateTime), Member = "Parse")]
	[Calls(Type = typeof(DateTime), Member = "Parse")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 23)]
	private bool Validate(WebNotification wn)
	{
		return default(bool);
	}

	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	[Calls(Type = typeof(Convert), Member = "ToInt64")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "RetrieveNotificationsFromServer")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetWebNotificationUrl()
	{
		return null;
	}

	[Calls(Type = typeof(WWWForm), Member = "AddField")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(WWWForm), Member = "AddField")]
	[Calls(Type = typeof(WWWForm), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public WWWForm GetWebForm()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Notifications), Member = "LoadNotifications")]
	[Calls(Type = typeof(GameManager), Member = "SetServerTime")]
	[CalledBy(Type = typeof(Panel_MainMenu._003C_003Ec__DisplayClass189_0), Member = "<RetrieveNotificationsFromServer>b__0")]
	public void ParseJson(string json)
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Notifications()
	{
	}
}
