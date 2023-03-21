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
		[CallerCount(Count = 7)]
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
	[Calls(Type = typeof(Notifications), Member = "GetValidNotifications")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetCount(Options opts)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Notifications), Member = "GetCount")]
	[CalledBy(Type = typeof(Notifications), Member = "HasNotifications")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "HasNotifications")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(TimeSpan), Member = "FromHours")]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Notifications), Member = "LoadNotifications")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public List<Notification> GetValidNotifications(Options opts)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Notifications), Member = "GetValidNotifications")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasNotifications(Options opts)
	{
		return false;
	}

	[CalledBy(Type = typeof(Notifications), Member = "GetValidNotifications")]
	[CalledBy(Type = typeof(Notifications), Member = "ParseJson")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Notifications), Member = "Validate")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "HasNotificationBeenViewed")]
	[Calls(Type = typeof(DateTime), Member = "Parse")]
	[Calls(Type = typeof(Notification), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Notifications), Member = "Validate")]
	[Calls(Type = typeof(Notification), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 44)]
	private void LoadNotifications(Options opts)
	{
	}

	[CalledBy(Type = typeof(Notifications), Member = "LoadNotifications")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(DateTime), Member = "Parse")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private bool Validate(Data d)
	{
		return false;
	}

	[CalledBy(Type = typeof(Notifications), Member = "LoadNotifications")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "Parse")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	private bool Validate(WebNotification wn)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "RetrieveNotificationsFromServer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(Convert), Member = "ToInt64")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetWebNotificationUrl()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WWWForm), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(WWWForm), Member = "AddField")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public WWWForm GetWebForm()
	{
		return null;
	}

	[CalledBy(TypeFullName = "Panel_MainMenu.<>c__DisplayClass189_0", Member = "<RetrieveNotificationsFromServer>b__0")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Notifications), Member = "LoadNotifications")]
	[Calls(Type = typeof(GameManager), Member = "SetServerTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void ParseJson(string json)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public Notifications()
	{
	}
}
