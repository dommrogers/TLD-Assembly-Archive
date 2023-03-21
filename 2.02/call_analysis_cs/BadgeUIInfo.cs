using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

public class BadgeUIInfo : ScriptableObject
{
	public BadgeInfoType m_Type;

	public string m_NameLocID;

	public string m_UnlockedSpriteName;

	public string m_UnlockedDescLocId;

	public string m_LockedSpriteName;

	public string m_LockedDescLocId;

	[NonSerialized]
	public bool m_Unlocked;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BadgeUIInfo), Member = "IsUnlocked")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[CallsUnknownMethods(Count = 8)]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BadgeUIInfo), Member = "IsUnlocked")]
	public static void SendBadgeInfoAnalyticsEvent()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "IsUnlocked")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "IsUnlocked")]
	[CallsUnknownMethods(Count = 8)]
	private static int GetNumFourDaysOfNightCompleted()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(BadgeUIInfo), Member = "IsUnlocked")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "IsUnlocked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private static int GetNumFourDaysOfNight2019Completed()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "SendBadgeInfoAnalyticsEvent")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(Condition_IsBadgeUnlocked), Member = "OnCheck")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "GetNumFourDaysOfNightCompleted")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "GetNumFourDaysOfNight2019Completed")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "GetNumFourDaysOfNight2019Completed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BadgeUIInfo), Member = "GetNumFourDaysOfNightCompleted")]
	public static bool IsUnlocked(BadgeInfoType bit)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Action_UnlockBadge), Member = "OnExecute")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void UnlockBadge(BadgeInfoType badge, bool skipProfileSave = false)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public BadgeUIInfo()
	{
	}
}
