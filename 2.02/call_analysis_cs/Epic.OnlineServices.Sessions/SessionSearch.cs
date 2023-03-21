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
	[CallerCount(Count = 7)]
	public SessionSearch()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SessionSearch(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionSearchCopySearchResultByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopySearchResultByIndex(SessionSearchCopySearchResultByIndexOptions options, out SessionDetails outSessionHandle)
	{
		outSessionHandle = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionSearchFindOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void Find(SessionSearchFindOptions options, object clientData, SessionSearchOnFindCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionSearchGetSearchResultCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetSearchResultCount(SessionSearchGetSearchResultCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Release()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionSearchRemoveParameterOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result RemoveParameter(SessionSearchRemoveParameterOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionSearchSetMaxResultsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SetMaxResults(SessionSearchSetMaxResultsOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionSearchSetParameterOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SetParameter(SessionSearchSetParameterOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionSearchSetSessionIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SetSessionId(SessionSearchSetSessionIdOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionSearchSetTargetUserIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SetTargetUserId(SessionSearchSetTargetUserIdOptions options)
	{
		return default(Result);
	}

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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionSearch_SetSessionId(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionSearch_SetTargetUserId(IntPtr handle, IntPtr options);
}
