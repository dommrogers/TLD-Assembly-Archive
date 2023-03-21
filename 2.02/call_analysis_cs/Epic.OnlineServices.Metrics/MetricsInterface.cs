using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Metrics;

public sealed class MetricsInterface : Handle
{
	public const int BeginplayersessionApiLatest = 1;

	public const int EndplayersessionApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MetricsInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MetricsInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result BeginPlayerSession(BeginPlayerSessionOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EndPlayerSessionOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
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
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Metrics_EndPlayerSession(IntPtr handle, IntPtr options);
}
