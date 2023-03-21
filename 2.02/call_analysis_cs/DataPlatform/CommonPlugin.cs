using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace DataPlatform;

public class CommonPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool GetLeaderboardAsync(int userId, string serviceConfigurationId, string leaderboardName, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool GetLeaderboardAsyncWithSkipToRank(int userId, string serviceConfigurationId, string leaderboardName, uint skipToRank, uint maxItems, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool GetLeaderboardForSocialGroupAsyncWithSortOrder(int userId, string xboxUserId, string serviceConfigurationId, string statisticName, string socialGroup, string sortOrder, uint maxItems, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool GetLeaderboardForSocialGroupAsync(int userId, string xboxUserId, string serviceConfigurationId, string statisticName, string socialGroup, uint maxItems, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool GetLeaderboardForSocialGroupWithSkipToRankAsync(int userId, string xboxUserId, string serviceConfigurationId, string statisticName, string socialGroup, uint skipToRank, string sortOrder, uint maxItems, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool GetLeaderboardForSocialGroupWithSkipToUserAsync(int userId, string xboxUserId, string serviceConfigurationId, string statisticName, string socialGroup, string skipToXboxUserId, string sortOrder, uint maxItems, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool GetLeaderboardWithSkipToUserAsync(int userId, string serviceConfigurationId, string leaderboardName, string skipToXboxUserId, uint maxItems, ObjectResultCallback callback, IntPtr userData);

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CommonPlugin()
	{
	}
}
