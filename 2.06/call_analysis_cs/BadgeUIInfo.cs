using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using SpecialEvents;
using TLD.SaveState;
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[CallsUnknownMethods(Count = 6)]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public static void SendBadgeInfoAnalyticsEvent()
	{
	}

	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "UpdateDaysSurvived")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Action_UnlockBadge), Member = "OnExecute")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
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
