using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace UnityPluginLog;

public class PluginLogManager
{
	public delegate void LogCallback(LogChannels channel, string message);

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public int hresult;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal IntPtr _003CResolveSystemMessage_003Eb__0()
		{
			return default(IntPtr);
		}
	}

	public static event LogCallback OnLog
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void Create(string logPath = "")
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalString")]
	[CallsUnknownMethods(Count = 11)]
	public static string ResolveSystemMessage(int hresult)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLogVerbosity(LogTarget target, uint verbosity)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void SetLogChannels(LogTarget target, LogChannels channels)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetLogVerbosity(LogTarget target)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetLogChannels(LogTarget target)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static void SetLogPath(string path)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_LogException")]
	[Conditional("UNITY_COMPILE_IN_LOGGING")]
	public static void LogException(string module, uint hresult, string message, string fileAndLine = "")
	{
	}

	[Conditional("UNITY_COMPILE_IN_LOGGING")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_LogError")]
	public static void LogError(string module, string message, string fileAndLine = "")
	{
	}

	[Conditional("UNITY_COMPILE_IN_LOGGING")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_Log")]
	public static void Log(string module, string message, string fileAndLine = "")
	{
	}

	[Conditional("UNITY_COMPILE_IN_TRACE_MSGS")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_Trace")]
	public static void Trace(string module, string message, string fileAndLine = "")
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_LogException")]
	[Conditional("UNITY_COMPILE_IN_LOGGING")]
	[Calls(Type = typeof(PluginLogManager), Member = "GetMetadata")]
	public static void LogException(uint hresult, string message)
	{
	}

	[Conditional("UNITY_COMPILE_IN_LOGGING")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PluginLogManager), Member = "GetMetadata")]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_LogError")]
	public static void LogError(string message)
	{
	}

	[Calls(Type = typeof(PluginLogManager), Member = "GetMetadata")]
	[Conditional("UNITY_COMPILE_IN_LOGGING")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_Log")]
	public static void Log(string message)
	{
	}

	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_Trace")]
	[Calls(Type = typeof(PluginLogManager), Member = "GetMetadata")]
	[CallerCount(Count = 0)]
	[Conditional("UNITY_COMPILE_IN_TRACE_MSGS")]
	public static void Trace(string message)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PluginLogManager), Member = "LogException")]
	[CalledBy(Type = typeof(PluginLogManager), Member = "LogError")]
	[CalledBy(Type = typeof(PluginLogManager), Member = "Log")]
	[CalledBy(Type = typeof(PluginLogManager), Member = "Trace")]
	public static void GetMetadata(int stackDepth, out string fileAndLine, out string method, out string module)
	{
		fileAndLine = null;
		method = null;
		module = null;
	}

	[UnityAOT.MonoPInvokeCallback(typeof(UnityPluginLogPlugin.PluginLogCallback))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void PluginLogThunk(int channel, string message)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PluginLogManager()
	{
	}
}
