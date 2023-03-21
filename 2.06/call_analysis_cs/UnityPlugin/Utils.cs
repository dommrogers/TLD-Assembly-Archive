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

	[CalledBy(Type = typeof(AchievementUnlockedEventArgs), Member = "get_XboxUserId")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Utils), Member = "MarshalCachedString")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PluginLogManager), Member = "ResolveSystemMessage")]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Uri), Member = ".ctor")]
	[CalledBy(Type = typeof(Utils), Member = "MarshalCachedUri")]
	[CallsUnknownMethods(Count = 8)]
	public static Uri MarshalUri(GetStringDelegate getString)
	{
		return null;
	}

	[CalledBy(Type = typeof(InventoryItem), Member = "get_Url")]
	[CalledBy(Type = typeof(InventoryItem), Member = "get_ConsumableUrl")]
	[CalledBy(Type = typeof(ConsumeInventoryItemResult), Member = "get_ConsumableUrl")]
	[CalledBy(Type = typeof(CatalogItemImage), Member = "get_ResizeUrl")]
	[Calls(Type = typeof(Utils), Member = "MarshalUri")]
	[CalledBy(Type = typeof(XboxUserProfile), Member = "get_GameDisplayPictureResizeUri")]
	[CalledBy(Type = typeof(XboxUserProfile), Member = "get_ApplicationDisplayPictureResizeUri")]
	[CalledBy(Type = typeof(AchievementUnlockedEventArgs), Member = "get_ExtendedInfoUrl")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(XboxUserProfile), Member = "GetGameDisplayPictureResizeUriForSize")]
	public static Uri MarshalCachedUri(ref Uri res, GetStringDelegate getString)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime")]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DateTime MarshalDateTime(GetUInt64Delegate getValue)
	{
		return default(DateTime);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AchievementUnlockedEventArgs), Member = "get_UnlockTime")]
	[CalledBy(Type = typeof(AchievementTimeWindow), Member = "get_StartDate")]
	[CalledBy(Type = typeof(AchievementTimeWindow), Member = "get_EndDate")]
	[CalledBy(Type = typeof(AchievementProgression), Member = "get_TimeUnlocked")]
	[CalledBy(Type = typeof(InventoryItem), Member = "get_RightsObtainedDate")]
	[CalledBy(Type = typeof(InventoryItem), Member = "get_StartDate")]
	[CalledBy(Type = typeof(CatalogItemDetails), Member = "get_ReleaseDate")]
	[CalledBy(Type = typeof(CatalogItem), Member = "get_ReleaseDate")]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime")]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(InventoryItem), Member = "get_EndDate")]
	public static DateTime MarshalCachedDateTime(ref DateTime res, GetUInt64Delegate getValue)
	{
		return default(DateTime);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeSpan), Member = "Interval")]
	[CallsUnknownMethods(Count = 1)]
	public static TimeSpan MarshalTimeSpan(GetInt64Delegate getValue)
	{
		return default(TimeSpan);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 23)]
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
