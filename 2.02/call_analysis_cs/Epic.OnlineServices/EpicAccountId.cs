using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

public sealed class EpicAccountId : Handle
{
	public const int EpicaccountidMaxLength = 32;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public EpicAccountId()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EpicAccountId(IntPtr innerHandle)
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
	public static EpicAccountId FromString(string accountIdString)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsValid()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsUnknownMethods(Count = 1)]
	public Result ToString(out string outBuffer)
	{
		outBuffer = null;
		return default(Result);
	}

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern IntPtr EOS_EpicAccountId_FromString(IntPtr accountIdString);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern int EOS_EpicAccountId_IsValid(IntPtr accountId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_EpicAccountId_ToString(IntPtr accountId, IntPtr outBuffer, ref int inOutBufferLength);
}
