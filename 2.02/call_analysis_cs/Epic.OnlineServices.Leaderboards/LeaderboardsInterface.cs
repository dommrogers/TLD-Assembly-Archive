using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

public sealed class LeaderboardsInterface : Handle
{
	public const int CopyleaderboarddefinitionbyindexApiLatest = 1;

	public const int CopyleaderboarddefinitionbyleaderboardidApiLatest = 1;

	public const int CopyleaderboardrecordbyindexApiLatest = 2;

	public const int CopyleaderboardrecordbyuseridApiLatest = 2;

	public const int CopyleaderboarduserscorebyindexApiLatest = 1;

	public const int CopyleaderboarduserscorebyuseridApiLatest = 1;

	public const int DefinitionApiLatest = 1;

	public const int GetleaderboarddefinitioncountApiLatest = 1;

	public const int GetleaderboardrecordcountApiLatest = 1;

	public const int GetleaderboarduserscorecountApiLatest = 1;

	public const int LeaderboardrecordApiLatest = 2;

	public const int LeaderboarduserscoreApiLatest = 1;

	public const int QueryleaderboarddefinitionsApiLatest = 1;

	public const int QueryleaderboardranksApiLatest = 1;

	public const int QueryleaderboarduserscoresApiLatest = 1;

	public const int TimeUndefined = -1;

	public const int UserscoresquerystatinfoApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LeaderboardsInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LeaderboardsInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopyLeaderboardDefinitionByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(LeaderboardsInterface), Member = "EOS_Leaderboards_Definition_Release")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyLeaderboardDefinitionByIndex(CopyLeaderboardDefinitionByIndexOptions options, out Definition outLeaderboardDefinition)
	{
		outLeaderboardDefinition = null;
		return default(Result);
	}

	[Calls(Type = typeof(LeaderboardsInterface), Member = "EOS_Leaderboards_Definition_Release")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal), Member = "Set")]
	[CallerCount(Count = 0)]
	public Result CopyLeaderboardDefinitionByLeaderboardId(CopyLeaderboardDefinitionByLeaderboardIdOptions options, out Definition outLeaderboardDefinition)
	{
		outLeaderboardDefinition = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopyLeaderboardRecordByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(LeaderboardsInterface), Member = "EOS_Leaderboards_LeaderboardRecord_Release")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyLeaderboardRecordByIndex(CopyLeaderboardRecordByIndexOptions options, out LeaderboardRecord outLeaderboardRecord)
	{
		outLeaderboardRecord = null;
		return default(Result);
	}

	[Calls(Type = typeof(LeaderboardsInterface), Member = "EOS_Leaderboards_LeaderboardRecord_Release")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardRecordByUserIdOptionsInternal), Member = "Set")]
	public Result CopyLeaderboardRecordByUserId(CopyLeaderboardRecordByUserIdOptions options, out LeaderboardRecord outLeaderboardRecord)
	{
		outLeaderboardRecord = null;
		return default(Result);
	}

	[Calls(Type = typeof(LeaderboardsInterface), Member = "EOS_Leaderboards_LeaderboardUserScore_Release")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByIndexOptionsInternal), Member = "Set")]
	public Result CopyLeaderboardUserScoreByIndex(CopyLeaderboardUserScoreByIndexOptions options, out LeaderboardUserScore outLeaderboardUserScore)
	{
		outLeaderboardUserScore = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(LeaderboardsInterface), Member = "EOS_Leaderboards_LeaderboardUserScore_Release")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyLeaderboardUserScoreByUserId(CopyLeaderboardUserScoreByUserIdOptions options, out LeaderboardUserScore outLeaderboardUserScore)
	{
		outLeaderboardUserScore = null;
		return default(Result);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetLeaderboardDefinitionCountOptionsInternal), Member = "Set")]
	public uint GetLeaderboardDefinitionCount(GetLeaderboardDefinitionCountOptions options)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GetLeaderboardRecordCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public uint GetLeaderboardRecordCount(GetLeaderboardRecordCountOptions options)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GetLeaderboardUserScoreCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	public uint GetLeaderboardUserScoreCount(GetLeaderboardUserScoreCountOptions options)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(QueryLeaderboardDefinitionsOptionsInternal), Member = "Set")]
	public void QueryLeaderboardDefinitions(QueryLeaderboardDefinitionsOptions options, object clientData, OnQueryLeaderboardDefinitionsCompleteCallback completionDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(QueryLeaderboardRanksOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	public void QueryLeaderboardRanks(QueryLeaderboardRanksOptions options, object clientData, OnQueryLeaderboardRanksCompleteCallback completionDelegate)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
	public void QueryLeaderboardUserScores(QueryLeaderboardUserScoresOptions options, object clientData, OnQueryLeaderboardUserScoresCompleteCallback completionDelegate)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryLeaderboardRanksCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_Leaderboards_CopyLeaderboardDefinitionByIndex(IntPtr handle, IntPtr options, ref IntPtr outLeaderboardDefinition);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Leaderboards_CopyLeaderboardDefinitionByLeaderboardId(IntPtr handle, IntPtr options, ref IntPtr outLeaderboardDefinition);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Leaderboards_CopyLeaderboardRecordByIndex(IntPtr handle, IntPtr options, ref IntPtr outLeaderboardRecord);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_Leaderboards_CopyLeaderboardRecordByUserId(IntPtr handle, IntPtr options, ref IntPtr outLeaderboardRecord);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Leaderboards_CopyLeaderboardUserScoreByIndex(IntPtr handle, IntPtr options, ref IntPtr outLeaderboardUserScore);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Leaderboards_CopyLeaderboardUserScoreByUserId(IntPtr handle, IntPtr options, ref IntPtr outLeaderboardUserScore);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern uint EOS_Leaderboards_GetLeaderboardDefinitionCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern uint EOS_Leaderboards_GetLeaderboardRecordCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Leaderboards_GetLeaderboardUserScoreCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Leaderboards_QueryLeaderboardDefinitions(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryLeaderboardDefinitionsCompleteCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Leaderboards_QueryLeaderboardRanks(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryLeaderboardRanksCompleteCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Leaderboards_QueryLeaderboardUserScores(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryLeaderboardUserScoresCompleteCallbackInternal completionDelegate);

	[PreserveSig]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardDefinitionByLeaderboardId")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardDefinitionByIndex")]
	internal static extern void EOS_Leaderboards_Definition_Release(IntPtr leaderboardDefinition);

	[PreserveSig]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardUserScoreByIndex")]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardUserScoreByUserId")]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Leaderboards_LeaderboardUserScore_Release(IntPtr leaderboardUserScore);

	[PreserveSig]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardRecordByIndex")]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardRecordByUserId")]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Leaderboards_LeaderboardRecord_Release(IntPtr leaderboardRecord);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Leaderboards_LeaderboardDefinition_Release(IntPtr leaderboardDefinition);
}
