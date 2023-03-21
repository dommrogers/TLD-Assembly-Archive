using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public sealed class LobbySearch : Handle
{
	public const int LobbysearchCopysearchresultbyindexApiLatest = 1;

	public const int LobbysearchFindApiLatest = 1;

	public const int LobbysearchGetsearchresultcountApiLatest = 1;

	public const int LobbysearchRemoveparameterApiLatest = 1;

	public const int LobbysearchSetlobbyidApiLatest = 1;

	public const int LobbysearchSetmaxresultsApiLatest = 1;

	public const int LobbysearchSetparameterApiLatest = 1;

	public const int LobbysearchSettargetuseridApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LobbySearch()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LobbySearch(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(LobbySearchCopySearchResultByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopySearchResultByIndex(LobbySearchCopySearchResultByIndexOptions options, out LobbyDetails outLobbyDetailsHandle)
	{
		outLobbyDetailsHandle = null;
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(LobbySearchFindOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public void Find(LobbySearchFindOptions options, object clientData, LobbySearchOnFindCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(LobbySearchGetSearchResultCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public uint GetSearchResultCount(LobbySearchGetSearchResultCountOptions options)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Release()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(LobbySearchRemoveParameterOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public Result RemoveParameter(LobbySearchRemoveParameterOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(LobbySearchSetLobbyIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result SetLobbyId(LobbySearchSetLobbyIdOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(LobbySearchSetMaxResultsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result SetMaxResults(LobbySearchSetMaxResultsOptions options)
	{
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(LobbySearchSetParameterOptionsInternal), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public Result SetParameter(LobbySearchSetParameterOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(LobbySearchSetTargetUserIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result SetTargetUserId(LobbySearchSetTargetUserIdOptions options)
	{
		return default(Result);
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnFindCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbySearch_CopySearchResultByIndex(IntPtr handle, IntPtr options, ref IntPtr outLobbyDetailsHandle);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_LobbySearch_Find(IntPtr handle, IntPtr options, IntPtr clientData, LobbySearchOnFindCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_LobbySearch_GetSearchResultCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_LobbySearch_Release(IntPtr lobbySearchHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbySearch_RemoveParameter(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbySearch_SetLobbyId(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbySearch_SetMaxResults(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbySearch_SetParameter(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_LobbySearch_SetTargetUserId(IntPtr handle, IntPtr options);
}
