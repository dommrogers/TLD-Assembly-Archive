using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Logging;

public static class LoggingInterface
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Helper), Member = "AddStaticCallback")]
	[CallsUnknownMethods(Count = 9)]
	public static Result SetCallback(LogMessageFunc callback)
	{
		return default(Result);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static Result SetLogLevel(LogCategory logCategory, LogLevel logLevel)
	{
		return default(Result);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void LogMessageFuncInternalImplementation(IntPtr message)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern Result EOS_Logging_SetCallback(LogMessageFuncInternal callback);

	[PreserveSig]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Logging_SetLogLevel(LogCategory logCategory, LogLevel logLevel);
}
