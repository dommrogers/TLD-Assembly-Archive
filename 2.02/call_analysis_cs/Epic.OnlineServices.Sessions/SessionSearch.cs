using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public sealed class SessionSearch : Handle
{
	public const int SessionsearchCopysearchresultbyindexApiLatest = 1;

	public const int SessionsearchFindApiLatest = 2;

	public const int SessionsearchGetsearchresultcountApiLatest = 1;

	public const int SessionsearchRemoveparameterApiLatest = 1;

	public const int SessionsearchSetmaxsearchresultsApiLatest = 1;

	public const int SessionsearchSetparameterApiLatest = 1;

	public const int SessionsearchSetsessionidApiLatest = 1;

	public const int SessionsearchSettargetuseridApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SessionSearch()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SessionSearch(IntPtr innerHandle)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(SessionSearchCopySearchResultByIndexOptionsInternal), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopySearchResultByIndex(SessionSearchCopySearchResultByIndexOptions options, out SessionDetails outSessionHandle)
	{
		outSessionHandle = null;
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(SessionSearchFindOptionsInternal), Member = "Set")]
	public void Find(SessionSearchFindOptions options, object clientData, SessionSearchOnFindCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SessionSearchGetSearchResultCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public uint GetSearchResultCount(SessionSearchGetSearchResultCountOptions options)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Release()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SessionSearchRemoveParameterOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public Result RemoveParameter(SessionSearchRemoveParameterOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SessionSearchSetMaxResultsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result SetMaxResults(SessionSearchSetMaxResultsOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SessionSearchSetParameterOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result SetParameter(SessionSearchSetParameterOptions options)
	{
		return default(Result);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SessionSearchSetSessionIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public Result SetSessionId(SessionSearchSetSessionIdOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SessionSearchSetTargetUserIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result SetTargetUserId(SessionSearchSetTargetUserIdOptions options)
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
	internal static extern Result EOS_SessionSearch_CopySearchResultByIndex(IntPtr handle, IntPtr options, ref IntPtr outSessionHandle);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_SessionSearch_Find(IntPtr handle, IntPtr options, IntPtr clientData, SessionSearchOnFindCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_SessionSearch_GetSearchResultCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_SessionSearch_Release(IntPtr sessionSearchHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionSearch_RemoveParameter(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionSearch_SetMaxResults(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionSearch_SetParameter(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_SessionSearch_SetSessionId(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_SessionSearch_SetTargetUserId(IntPtr handle, IntPtr options);
}
