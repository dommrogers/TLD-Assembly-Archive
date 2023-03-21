using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

public sealed class PresenceModification : Handle
{
	public const int PresencemodificationDatarecordidApiLatest = 1;

	public const int PresencemodificationDeletedataApiLatest = 1;

	public const int PresencemodificationJoininfoMaxLength = 255;

	public const int PresencemodificationSetdataApiLatest = 1;

	public const int PresencemodificationSetjoininfoApiLatest = 1;

	public const int PresencemodificationSetrawrichtextApiLatest = 1;

	public const int PresencemodificationSetstatusApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PresenceModification()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PresenceModification(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationDeleteDataOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result DeleteData(PresenceModificationDeleteDataOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Release()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationSetDataOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SetData(PresenceModificationSetDataOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationSetJoinInfoOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SetJoinInfo(PresenceModificationSetJoinInfoOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationSetRawRichTextOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SetRawRichText(PresenceModificationSetRawRichTextOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationSetStatusOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SetStatus(PresenceModificationSetStatusOptions options)
	{
		return default(Result);
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_PresenceModification_DeleteData(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_PresenceModification_Release(IntPtr presenceModificationHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_PresenceModification_SetData(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_PresenceModification_SetJoinInfo(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_PresenceModification_SetRawRichText(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_PresenceModification_SetStatus(IntPtr handle, IntPtr options);
}
