using System;
using System.Collections.Generic;
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

	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BadgeUIInfo), Member = "IsUnlocked")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "IsUnlocked")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public static void SendBadgeInfoAnalyticsEvent()
	{
	}

	[CalledBy(Type = typeof(BadgeUIInfo), Member = "IsUnlocked")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private static int GetNumFourDaysOfNightCompleted()
	{
		return 0;
	}

	[CalledBy(Type = typeof(BadgeUIInfo), Member = "IsUnlocked")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private static int GetNumFourDaysOfNight2019Completed()
	{
		return 0;
	}

	[CalledBy(Type = typeof(BadgeUIInfo), Member = "CreateBadgeInfo")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "SendBadgeInfoAnalyticsEvent")]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CalledBy(Type = typeof(Condition_IsBadgeUnlocked), Member = "OnCheck")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BadgeUIInfo), Member = "GetNumFourDaysOfNight2019Completed")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "GetNumFourDaysOfNightCompleted")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 36)]
	public static bool IsUnlocked(BadgeInfoType bit)
	{
		return false;
	}

	[CalledBy(Type = typeof(Action_UnlockBadge), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void UnlockBadge(BadgeInfoType badge, bool skipProfileSave = false)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public BadgeUIInfo()
	{
	}
}
