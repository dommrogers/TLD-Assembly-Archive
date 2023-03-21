using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public sealed class ActiveSession : Handle
{
	public const int ActivesessionCopyinfoApiLatest = 1;

	public const int ActivesessionGetregisteredplayerbyindexApiLatest = 1;

	public const int ActivesessionGetregisteredplayercountApiLatest = 1;

	public const int ActivesessionInfoApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ActiveSession()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ActiveSession(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveSessionCopyInfoOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public Result CopyInfo(ActiveSessionCopyInfoOptions options, out ActiveSessionInfo outActiveSessionInfo)
	{
		outActiveSessionInfo = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveSessionGetRegisteredPlayerByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public ProductUserId GetRegisteredPlayerByIndex(ActiveSessionGetRegisteredPlayerByIndexOptions options)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveSessionGetRegisteredPlayerCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetRegisteredPlayerCount(ActiveSessionGetRegisteredPlayerCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Release()
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_ActiveSession_CopyInfo(IntPtr handle, IntPtr options, ref IntPtr outActiveSessionInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern IntPtr EOS_ActiveSession_GetRegisteredPlayerByIndex(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_ActiveSession_GetRegisteredPlayerCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_ActiveSession_Release(IntPtr activeSessionHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_ActiveSession_Info_Release(IntPtr activeSessionInfo);
}
