using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using SpecialEvents;
using TLD.AddressableAssets;
using TLD.SaveState;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class BadgeUIInfo : ScriptableObject
{
	public BadgeInfoType m_Type;

	private AssetReferenceTexture2D m_UnlockedSprite;

	private AssetReferenceTexture2D m_LockedSprite;

	private LocalizedString m_BadgeName;

	private LocalizedString m_Description;

	private LocalizedString m_LockedDescription;

	[NonSerialized]
	public bool m_Unlocked;

	private static IList<BadgeUIInfo> s_BadgeUIInfos;

	public AssetReferenceTexture2D UnlockedSprite
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public static void SendBadgeInfoAnalyticsEvent()
	{
	}

	[CalledBy(Type = typeof(WintersEmbrace), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	[CalledBy(Type = typeof(Action_UnlockBadge), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "GetBadgeUIInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void UnlockBadge(BadgeInfoType badge, bool skipProfileSave = false)
	{
	}

	[CalledBy(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private static BadgeUIInfo GetBadgeUIInfo(BadgeInfoType badge)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public BadgeUIInfo()
	{
	}
}
