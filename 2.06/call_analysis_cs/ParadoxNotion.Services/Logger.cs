using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

namespace ParadoxNotion.Services;

public static class Logger
{
	public struct Message
	{
		public LogType type;

		public string text;

		public string tag;

		public object context;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		public bool IsSameAs(Message b)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		public bool IsValid()
		{
			return default(bool);
		}
	}

	public delegate bool LogHandler(Message message);

	private static List<LogHandler> subscribers;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void AddListener(LogHandler callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveListener(LogHandler callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsUnknownMethods(Count = 1)]
	public static void Log(object message, Enum tag = null, object context = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	public static void Log(object message, string tag = null, object context = null)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogWarning(object message, Enum tag = null, object context = null)
	{
	}

	[CalledBy(Type = typeof(Node), Member = "Warn")]
	[CalledBy(Type = typeof(FSMState), Member = "CanConnectToTarget")]
	[CalledBy(Type = typeof(FSMState), Member = "CanConnectFromSource")]
	[CalledBy(Type = typeof(BBParameter<>._003C_003Ec__DisplayClass16_0), Member = "<BindSetter>b__1")]
	[CalledBy(Type = typeof(Node), Member = "IsNewConnectionAllowed")]
	[CalledBy(Type = typeof(Node), Member = "IsNewConnectionAllowed")]
	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CalledBy(Type = typeof(Node), Member = "IsNewConnectionAllowed")]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallerCount(Count = 13)]
	public static void LogWarning(object message, string tag = null, object context = null)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void LogError(object message, Enum tag = null, object context = null)
	{
	}

	[CalledBy(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CalledBy(Type = typeof(Task), Member = "Error")]
	[CalledBy(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CalledBy(Type = typeof(Task), Member = "SetOwnerSystem")]
	[CalledBy(Type = typeof(Node), Member = "RegisterEvents")]
	[CalledBy(Type = typeof(Node), Member = "Fail")]
	[CalledBy(Type = typeof(Node), Member = "Error")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	[CalledBy(Type = typeof(Node), Member = "Create")]
	[CalledBy(Type = typeof(Graph), Member = "LoadGraphData")]
	[CalledBy(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CalledBy(Type = typeof(MessageRouter), Member = "Register")]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Node), Member = "Duplicate")]
	public static void LogError(object message, string tag = null, object context = null)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogException(Exception exception, Enum tag = null, object context = null)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "Validate")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "TryResolveGenericType")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
	[CalledBy(Type = typeof(Graph), Member = "DeserializeLocalBlackboard")]
	[CalledBy(Type = typeof(Graph), Member = "Validate")]
	[CalledBy(Type = typeof(Node), Member = "Error")]
	public static void LogException(Exception exception, string tag = null, object context = null)
	{
	}

	[CalledBy(Type = typeof(Logger), Member = "LogError")]
	[CalledBy(Type = typeof(Logger), Member = "LogError")]
	[CalledBy(Type = typeof(Logger), Member = "LogException")]
	[CalledBy(Type = typeof(Logger), Member = "LogWarning")]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Logger), Member = "LogException")]
	[CalledBy(Type = typeof(Logger), Member = "LogWarning")]
	[CalledBy(Type = typeof(Logger), Member = "Log")]
	[Calls(Type = typeof(Logger), Member = "ForwardToUnity")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Logger), Member = "Log")]
	private static void Internal_Log(LogType type, object message, string tag, object context)
	{
	}

	[CalledBy(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private static void ForwardToUnity(LogType type, object message, string tag, object context)
	{
	}
}
