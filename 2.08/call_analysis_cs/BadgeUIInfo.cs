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
	[CallsUnknownMethods(Count = 1)]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	public static void SendBadgeInfoAnalyticsEvent()
	{
	}

	[CalledBy(Type = typeof(WintersEmbrace), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_UnlockBadge), Member = "OnExecute")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	public static void UnlockBadge(BadgeInfoType badge, bool skipProfileSave = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public BadgeUIInfo()
	{
	}
}
