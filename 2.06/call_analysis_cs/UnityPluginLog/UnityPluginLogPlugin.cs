using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityPluginLog;

public class UnityPluginLogPlugin
{
	public delegate void PluginLogCallback(int channel, string message);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int InitializePlugin(uint creationFlags);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int GetPluginVersion();

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static extern bool AmFullyInitialized();

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern IntPtr UnityPluginLog_ResolveSystemMessage(int hresult);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static extern void UnityPluginLog_SetLogVerbosity(int target, uint verbosity);

	[PreserveSig]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void UnityPluginLog_SetLogChannels(int target, uint channels);

	[PreserveSig]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int UnityPluginLog_GetLogVerbosity(int target);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static extern int UnityPluginLog_GetLogChannels(int target);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static extern void UnityPluginLog_SetLogPath(string path);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern void RegisterLogMessagesCallback(PluginLogCallback callback);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static extern void RemoveLogMessagesCallback(PluginLogCallback callback);

	[PreserveSig]
	[CalledBy(Type = typeof(PluginLogManager), Member = "LogException")]
	[CalledBy(Type = typeof(PluginLogManager), Member = "LogException")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void Log_LogException(string module, uint hresult, string message, string fileAndLine);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PluginLogManager), Member = "LogError")]
	[CalledBy(Type = typeof(PluginLogManager), Member = "LogError")]
	[CallerCount(Count = 2)]
	public static extern void Log_LogError(string module, string message, string fileAndLine);

	[PreserveSig]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PluginLogManager), Member = "Log")]
	[CalledBy(Type = typeof(PluginLogManager), Member = "Log")]
	[CallsUnknownMethods(Count = 1)]
	public static extern void Log_Log(string module, string message, string fileAndLine);

	[PreserveSig]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PluginLogManager), Member = "Trace")]
	[CalledBy(Type = typeof(PluginLogManager), Member = "Trace")]
	[CallsUnknownMethods(Count = 1)]
	public static extern void Log_Trace(string module, string message, string fileAndLine);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public UnityPluginLogPlugin()
	{
	}
}
