using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace DataPlatform;

public class LeaderboardResultEventArgsPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr LeaderboardResultEventArgs_Result(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void LeaderboardResultEventArgs_Dispose(IntPtr self);

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LeaderboardResultEventArgsPlugin()
	{
	}
}
