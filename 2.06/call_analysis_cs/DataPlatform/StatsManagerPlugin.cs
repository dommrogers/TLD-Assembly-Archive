using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace DataPlatform;

public class StatsManagerPlugin
{
	[PreserveSig]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void StatsManager_AddLocalUser(int userId);

	[PreserveSig]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void StatsManager_RemoveLocalUser(int userId);

	[PreserveSig]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void StatsManager_SetStatAsInteger(int userId, string statName, long statValue);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static extern void StatsManager_SetStatAsNumber(int userId, string statName, double statValue);

	[PreserveSig]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(StatsManager), Member = "SetStatAsString")]
	[CallsUnknownMethods(Count = 5)]
	public static extern void StatsManager_SetStatAsString(int userId, string statName, string statValue);

	[PreserveSig]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void StatsManager_RequestFlushToService(int userId, bool isHighPriority);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr StatsManager_GetStatNames(int userId);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern void StatsManager_GetStatNames_Dispose(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint StatsManager_GetStatNames_Length(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr StatsManager_GetStatNames_GetAt(IntPtr self, uint idx);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr StatsManager_GetStat(int userId, string statName);

	[PreserveSig]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void StatsManager_DeleteStat(int userId, string statName);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void StatsManager_GetLeaderboard(int userId, string statName, IntPtr query);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern void StatsManager_GetSocialLeaderboard(int userId, string statName, string socialGroup, IntPtr query);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr StatsManager_DoWork();

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void StatsManager_DoWork_Dispose(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint StatsManager_DoWork_Length(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(StatEventList), Member = "CreateIthElement")]
	[CalledBy(Type = typeof(StatEventList), Member = "CreateIthElement")]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr StatsManager_DoWork_GetAt(IntPtr self, uint idx);

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public StatsManagerPlugin()
	{
	}
}
