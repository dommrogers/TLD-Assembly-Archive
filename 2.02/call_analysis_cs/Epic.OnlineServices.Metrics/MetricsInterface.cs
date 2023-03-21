using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Metrics;

public sealed class MetricsInterface : Handle
{
	public const int BeginplayersessionApiLatest = 1;

	public const int EndplayersessionApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MetricsInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MetricsInterface(IntPtr innerHandle)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "Set")]
	public Result BeginPlayerSession(BeginPlayerSessionOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(EndPlayerSessionOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result EndPlayerSession(EndPlayerSessionOptions options)
	{
		return default(Result);
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Metrics_BeginPlayerSession(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_Metrics_EndPlayerSession(IntPtr handle, IntPtr options);
}
