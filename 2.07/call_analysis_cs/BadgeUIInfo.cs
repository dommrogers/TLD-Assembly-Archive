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

	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public static void SendBadgeInfoAnalyticsEvent()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Action_UnlockBadge), Member = "OnExecute")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "UpdateDaysSurvived")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Replace")]
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
