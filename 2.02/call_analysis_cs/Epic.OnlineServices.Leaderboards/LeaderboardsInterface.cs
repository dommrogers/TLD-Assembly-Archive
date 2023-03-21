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
	[CallerCount(Count = 7)]
	public LeaderboardsInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LeaderboardsInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardDefinitionByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(LeaderboardsInterface), Member = "EOS_Leaderboards_Definition_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyLeaderboardDefinitionByIndex(CopyLeaderboardDefinitionByIndexOptions options, out Definition outLeaderboardDefinition)
	{
		outLeaderboardDefinition = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(LeaderboardsInterface), Member = "EOS_Leaderboards_Definition_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyLeaderboardDefinitionByLeaderboardId(CopyLeaderboardDefinitionByLeaderboardIdOptions options, out Definition outLeaderboardDefinition)
	{
		outLeaderboardDefinition = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardRecordByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(LeaderboardsInterface), Member = "EOS_Leaderboards_LeaderboardRecord_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyLeaderboardRecordByIndex(CopyLeaderboardRecordByIndexOptions options, out LeaderboardRecord outLeaderboardRecord)
	{
		outLeaderboardRecord = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardRecordByUserIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(LeaderboardsInterface), Member = "EOS_Leaderboards_LeaderboardRecord_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyLeaderboardRecordByUserId(CopyLeaderboardRecordByUserIdOptions options, out LeaderboardRecord outLeaderboardRecord)
	{
		outLeaderboardRecord = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(LeaderboardsInterface), Member = "EOS_Leaderboards_LeaderboardUserScore_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyLeaderboardUserScoreByIndex(CopyLeaderboardUserScoreByIndexOptions options, out LeaderboardUserScore outLeaderboardUserScore)
	{
		outLeaderboardUserScore = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(LeaderboardsInterface), Member = "EOS_Leaderboards_LeaderboardUserScore_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyLeaderboardUserScoreByUserId(CopyLeaderboardUserScoreByUserIdOptions options, out LeaderboardUserScore outLeaderboardUserScore)
	{
		outLeaderboardUserScore = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetLeaderboardDefinitionCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetLeaderboardDefinitionCount(GetLeaderboardDefinitionCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetLeaderboardRecordCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetLeaderboardRecordCount(GetLeaderboardRecordCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetLeaderboardUserScoreCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetLeaderboardUserScoreCount(GetLeaderboardUserScoreCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryLeaderboardDefinitionsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryLeaderboardDefinitions(QueryLeaderboardDefinitionsOptions options, object clientData, OnQueryLeaderboardDefinitionsCompleteCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryLeaderboardRanksOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryLeaderboardRanks(QueryLeaderboardRanksOptions options, object clientData, OnQueryLeaderboardRanksCompleteCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryLeaderboardUserScores(QueryLeaderboardUserScoresOptions options, object clientData, OnQueryLeaderboardUserScoresCompleteCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryLeaderboardRanksCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Leaderboards_GetLeaderboardDefinitionCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardDefinitionByIndex")]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardDefinitionByLeaderboardId")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Leaderboards_Definition_Release(IntPtr leaderboardDefinition);

	[PreserveSig]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardUserScoreByIndex")]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardUserScoreByUserId")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Leaderboards_LeaderboardUserScore_Release(IntPtr leaderboardUserScore);

	[PreserveSig]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardRecordByIndex")]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardRecordByUserId")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Leaderboards_LeaderboardRecord_Release(IntPtr leaderboardRecord);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Leaderboards_LeaderboardDefinition_Release(IntPtr leaderboardDefinition);
}
