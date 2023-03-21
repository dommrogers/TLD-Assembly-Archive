using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace DataPlatform;

public class StatEventPlugin
{
	[PreserveSig]
	[CalledBy(Type = typeof(StatEvent), Member = "get_EventType")]
	[CalledBy(Type = typeof(StatEvent), Member = "get_LeaderboardResultArgs")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static extern StatEventType StatisticEvent_EventType(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int StatisticEvent_ErrorCode(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr StatisticEvent_ErrorMessage(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void StatisticEvent_Dispose(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int StatisticEvent_User(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr StatisticEvent_EventArgs_AsLeaderboardResultEventArgs(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public StatEventPlugin()
	{
	}
}
