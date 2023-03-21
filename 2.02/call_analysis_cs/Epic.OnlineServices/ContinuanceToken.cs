using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

public sealed class ContinuanceToken : Handle
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ContinuanceToken()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ContinuanceToken(IntPtr innerHandle)
	{
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
	internal static extern Result EOS_ContinuanceToken_ToString(IntPtr continuanceToken, IntPtr outBuffer, ref int inOutBufferLength);
}
