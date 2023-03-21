using System;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class ObjectLog
{
	private int pos;

	private string[] logMessages;

	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(ObjectLog), Member = "Log")]
	[CalledBy(Type = typeof(ObjectLog), Member = "Error")]
	[CalledBy(Type = typeof(ObjectLog), Member = "Warn")]
	[CalledBy(Type = typeof(ObjectLog), Member = "Info")]
	[CalledBy(Type = typeof(ObjectLog), Member = "LogDebug")]
	[CalledBy(Type = typeof(ObjectLog), Member = "Trace")]
	[CallsUnknownMethods(Count = 5)]
	private void _CacheLogMessage(string msg)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public ObjectLog(short bufferSize)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB2_Log), Member = "Log")]
	[Calls(Type = typeof(ObjectLog), Member = "_CacheLogMessage")]
	public void Log(MB2_LogLevel l, string msg, MB2_LogLevel currentThreshold)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ObjectLog), Member = "_CacheLogMessage")]
	[CallsUnknownMethods(Count = 1)]
	public void Error(string msg, object[] args)
	{
	}

	[Calls(Type = typeof(ObjectLog), Member = "_CacheLogMessage")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Warn(string msg, object[] args)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ObjectLog), Member = "_CacheLogMessage")]
	[CallsUnknownMethods(Count = 1)]
	public void Info(string msg, object[] args)
	{
	}

	[Calls(Type = typeof(ObjectLog), Member = "_CacheLogMessage")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[CallerCount(Count = 0)]
	public void LogDebug(string msg, object[] args)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ObjectLog), Member = "_CacheLogMessage")]
	[CallsUnknownMethods(Count = 1)]
	public void Trace(string msg, object[] args)
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	public string Dump()
	{
		return null;
	}
}
