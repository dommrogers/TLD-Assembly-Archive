using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace DataPlatform;

public class LeaderboardResultPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void LeaderboardResult_Dispose(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint LeaderboardResult_TotalRowCount(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr LeaderboardResult_DisplayName(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr LeaderboardResult_GetNextQuery(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static extern bool LeaderboardResult_HasNext(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint LeaderboardResult_NumColumns(IntPtr self);

	[PreserveSig]
	[CalledBy(TypeFullName = "DataPlatform.LeaderboardResultColumns.<GetEnumerator>d__1", Member = "MoveNext")]
	[CalledBy(Type = typeof(LeaderboardResultColumns), Member = "get_Item")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr LeaderboardResult_GetColumn(IntPtr self, int i);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr LeaderboardResult_LeaderboardColumn_DisplayName(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr LeaderboardResult_LeaderboardColumn_StatisticName(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint LeaderboardResult_LeaderboardColumn_StatisticType(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint LeaderboardResult_NumRows(IntPtr self);

	[PreserveSig]
	[CalledBy(TypeFullName = "DataPlatform.LeaderboardResultRows.<GetEnumerator>d__1", Member = "MoveNext")]
	[CalledBy(Type = typeof(LeaderboardResultRows), Member = "get_Item")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr LeaderboardResult_GetRow(IntPtr self, int i);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr LeaderboardResult_LeaderboardRow_Gamertag(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr LeaderboardResult_LeaderboardRow_XboxUserId(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern double LeaderboardResult_LeaderboardRow_Percentile(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint LeaderboardResult_LeaderboardRow_Rank(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint LeaderboardResult_LeaderboardRow_NumValues(IntPtr self);

	[PreserveSig]
	[CalledBy(TypeFullName = "DataPlatform.LeaderboardResultRow.<>c__DisplayClass6_0", Member = "<get_Item>b__0")]
	[CalledBy(TypeFullName = "DataPlatform.LeaderboardResultRow.<>c__DisplayClass7_0", Member = "<GetEnumerator>b__0")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr LeaderboardResult_LeaderboardRow_Value(IntPtr self, int i);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LeaderboardResultPlugin()
	{
	}
}
