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

		[CallerCount(Count = 2)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void Create(string logPath = "")
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalString")]
	[CallsUnknownMethods(Count = 15)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLogChannels(LogTarget target, LogChannels channels)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static int GetLogVerbosity(LogTarget target)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static int GetLogChannels(LogTarget target)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLogPath(string path)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_LogException")]
	public static void LogException(string module, uint hresult, string message, string fileAndLine = "")
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_LogError")]
	public static void LogError(string module, string message, string fileAndLine = "")
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_Log")]
	public static void Log(string module, string message, string fileAndLine = "")
	{
	}

	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_Trace")]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void Trace(string module, string message, string fileAndLine = "")
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PluginLogManager), Member = "GetMetadata")]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_LogException")]
	public static void LogException(uint hresult, string message)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PluginLogManager), Member = "GetMetadata")]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_LogError")]
	public static void LogError(string message)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PluginLogManager), Member = "GetMetadata")]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_Log")]
	public static void Log(string message)
	{
	}

	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_Trace")]
	[Calls(Type = typeof(PluginLogManager), Member = "GetMetadata")]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void Trace(string message)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void PluginLogThunk(int channel, string message)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PluginLogManager()
	{
	}
}
