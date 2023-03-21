using System;
using Cpp2ILInjected.CallAnalysis;
using DataPlatform;
using Marketplace;
using UnityPluginLog;
using Users;

namespace UnityPlugin;

public class Utils
{
	public delegate IntPtr GetStringDelegate();

	public delegate ulong GetUInt64Delegate();

	public delegate long GetInt64Delegate();

	[CalledBy(Type = typeof(PluginLogManager), Member = "ResolveSystemMessage")]
	[CalledBy(Type = typeof(Utils), Member = "MarshalCachedString")]
	[CalledBy(Type = typeof(AchievementUnlockedEventArgs), Member = "get_XboxUserId")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static string MarshalString(GetStringDelegate getString)
	{
		return null;
	}

	[CallerCount(Count = 100)]
	[Calls(Type = typeof(Utils), Member = "MarshalString")]
	public static string MarshalCachedString(ref string res, GetStringDelegate getString)
	{
		return null;
	}

	[CalledBy(Type = typeof(Utils), Member = "MarshalCachedUri")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static Uri MarshalUri(GetStringDelegate getString)
	{
		return null;
	}

	[CalledBy(Type = typeof(XboxUserProfile), Member = "get_ApplicationDisplayPictureResizeUri")]
	[CalledBy(Type = typeof(XboxUserProfile), Member = "get_GameDisplayPictureResizeUri")]
	[CalledBy(Type = typeof(XboxUserProfile), Member = "GetGameDisplayPictureResizeUriForSize")]
	[CalledBy(Type = typeof(CatalogItemImage), Member = "get_ResizeUrl")]
	[CalledBy(Type = typeof(ConsumeInventoryItemResult), Member = "get_ConsumableUrl")]
	[CalledBy(Type = typeof(InventoryItem), Member = "get_ConsumableUrl")]
	[CalledBy(Type = typeof(InventoryItem), Member = "get_Url")]
	[CalledBy(Type = typeof(AchievementUnlockedEventArgs), Member = "get_ExtendedInfoUrl")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "MarshalUri")]
	public static Uri MarshalCachedUri(ref Uri res, GetStringDelegate getString)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static DateTime MarshalDateTime(GetUInt64Delegate getValue)
	{
		return default(DateTime);
	}

	[CalledBy(Type = typeof(CatalogItem), Member = "get_ReleaseDate")]
	[CalledBy(Type = typeof(CatalogItemDetails), Member = "get_ReleaseDate")]
	[CalledBy(Type = typeof(InventoryItem), Member = "get_EndDate")]
	[CalledBy(Type = typeof(InventoryItem), Member = "get_RightsObtainedDate")]
	[CalledBy(Type = typeof(InventoryItem), Member = "get_StartDate")]
	[CalledBy(Type = typeof(AchievementProgression), Member = "get_TimeUnlocked")]
	[CalledBy(Type = typeof(AchievementTimeWindow), Member = "get_EndDate")]
	[CalledBy(Type = typeof(AchievementTimeWindow), Member = "get_StartDate")]
	[CalledBy(Type = typeof(AchievementUnlockedEventArgs), Member = "get_UnlockTime")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static DateTime MarshalCachedDateTime(ref DateTime res, GetUInt64Delegate getValue)
	{
		return default(DateTime);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpan), Member = "Interval")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static TimeSpan MarshalTimeSpan(GetInt64Delegate getValue)
	{
		return default(TimeSpan);
	}

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string FormatException(Exception e)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Utils()
	{
	}
}
