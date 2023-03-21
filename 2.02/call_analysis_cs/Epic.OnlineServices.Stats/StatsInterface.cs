using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Stats;

public sealed class StatsInterface : Handle
{
	public const int CopystatbyindexApiLatest = 1;

	public const int CopystatbynameApiLatest = 1;

	public const int GetstatcountApiLatest = 1;

	public const int GetstatscountApiLatest = 1;

	public const int IngestdataApiLatest = 1;

	public const int IngeststatApiLatest = 2;

	public const int MaxIngestStats = 3000;

	public const int MaxQueryStats = 1000;

	public const int QuerystatsApiLatest = 2;

	public const int StatApiLatest = 1;

	public const int TimeUndefined = -1;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public StatsInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StatsInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyStatByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(StatsInterface), Member = "EOS_Stats_Stat_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyStatByIndex(CopyStatByIndexOptions options, out Stat outStat)
	{
		outStat = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyStatByNameOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(StatsInterface), Member = "EOS_Stats_Stat_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyStatByName(CopyStatByNameOptions options, out Stat outStat)
	{
		outStat = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetStatCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetStatsCount(GetStatCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IngestStatOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void IngestStat(IngestStatOptions options, object clientData, OnIngestStatCompleteCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryStats(QueryStatsOptions options, object clientData, OnQueryStatsCompleteCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnIngestStatCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryStatsCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Stats_CopyStatByIndex(IntPtr handle, IntPtr options, ref IntPtr outStat);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Stats_CopyStatByName(IntPtr handle, IntPtr options, ref IntPtr outStat);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Stats_GetStatsCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Stats_IngestStat(IntPtr handle, IntPtr options, IntPtr clientData, OnIngestStatCompleteCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Stats_QueryStats(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryStatsCompleteCallbackInternal completionDelegate);

	[PreserveSig]
	[CalledBy(Type = typeof(StatsInterface), Member = "CopyStatByIndex")]
	[CalledBy(Type = typeof(StatsInterface), Member = "CopyStatByName")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Stats_Stat_Release(IntPtr stat);
}
