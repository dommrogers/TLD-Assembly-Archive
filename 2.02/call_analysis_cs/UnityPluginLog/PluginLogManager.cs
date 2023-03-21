using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityPlugin;

namespace UnityPluginLog;

public class PluginLogManager
{
	public delegate void LogCallback(LogChannels channel, string message);

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public int hresult;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal IntPtr _003CResolveSystemMessage_003Eb__0()
		{
			return (IntPtr)0;
		}
	}

	public static event LogCallback OnLog
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public static void Create(string logPath = "")
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalString")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetLogVerbosity(LogTarget target)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetLogChannels(LogTarget target)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLogPath(string path)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_LogException")]
	public static void LogException(string module, uint hresult, string message, string fileAndLine = "")
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_LogError")]
	public static void LogError(string module, string message, string fileAndLine = "")
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_Log")]
	public static void Log(string module, string message, string fileAndLine = "")
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_Trace")]
	public static void Trace(string module, string message, string fileAndLine = "")
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PluginLogManager), Member = "GetMetadata")]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_LogException")]
	public static void LogException(uint hresult, string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PluginLogManager), Member = "GetMetadata")]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_LogError")]
	public static void LogError(string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PluginLogManager), Member = "GetMetadata")]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_Log")]
	public static void Log(string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PluginLogManager), Member = "GetMetadata")]
	[Calls(Type = typeof(UnityPluginLogPlugin), Member = "Log_Trace")]
	public static void Trace(string message)
	{
	}

	[CalledBy(Type = typeof(PluginLogManager), Member = "LogException")]
	[CalledBy(Type = typeof(PluginLogManager), Member = "LogError")]
	[CalledBy(Type = typeof(PluginLogManager), Member = "Log")]
	[CalledBy(Type = typeof(PluginLogManager), Member = "Trace")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void GetMetadata(int stackDepth, out string fileAndLine, out string method, out string module)
	{
		fileAndLine = null;
		method = null;
		module = null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void PluginLogThunk(int channel, string message)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PluginLogManager()
	{
	}
}
