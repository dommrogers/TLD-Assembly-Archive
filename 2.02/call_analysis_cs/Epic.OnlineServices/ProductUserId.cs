using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

public sealed class ProductUserId : Handle
{
	public const int ProductuseridMaxLength = 128;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ProductUserId()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ProductUserId(IntPtr innerHandle)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	public static ProductUserId FromString(string accountIdString)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public bool IsValid()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result ToString(out string outBuffer)
	{
		outBuffer = null;
		return default(Result);
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern IntPtr EOS_ProductUserId_FromString(IntPtr accountIdString);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern int EOS_ProductUserId_IsValid(IntPtr accountId);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_ProductUserId_ToString(IntPtr accountId, IntPtr outBuffer, ref int inOutBufferLength);
}
