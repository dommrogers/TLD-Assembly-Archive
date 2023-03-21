using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
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

		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogWarning(object message, Enum tag = null, object context = null)
	{
	}

	[CalledBy(Type = typeof(FSMState), Member = "CanConnectToTarget")]
	[CalledBy(Type = typeof(FSMState), Member = "CanConnectFromSource")]
	[CalledBy(Type = typeof(BBParameter<>._003C_003Ec__DisplayClass16_0), Member = "<BindSetter>b__1")]
	[CalledBy(Type = typeof(Node), Member = "IsNewConnectionAllowed")]
	[CalledBy(Type = typeof(Node), Member = "IsNewConnectionAllowed")]
	[CalledBy(Type = typeof(Node), Member = "Warn")]
	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CalledBy(Type = typeof(Node), Member = "IsNewConnectionAllowed")]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
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

	[CalledBy(Type = typeof(Node), Member = "Fail")]
	[CalledBy(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CalledBy(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CalledBy(Type = typeof(Task), Member = "Error")]
	[CalledBy(Type = typeof(Task), Member = "SetOwnerSystem")]
	[CalledBy(Type = typeof(Node), Member = "RegisterEvents")]
	[CalledBy(Type = typeof(Node), Member = "Error")]
	[CalledBy(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CalledBy(Type = typeof(Node), Member = "Create")]
	[CalledBy(Type = typeof(Node), Member = "Duplicate")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CalledBy(Type = typeof(MessageRouter), Member = "Register")]
	[CalledBy(Type = typeof(Graph), Member = "LoadGraphData")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	public static void LogError(object message, string tag = null, object context = null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsUnknownMethods(Count = 1)]
	public static void LogException(Exception exception, Enum tag = null, object context = null)
	{
	}

	[CalledBy(Type = typeof(Node), Member = "Error")]
	[CalledBy(Type = typeof(Graph), Member = "Validate")]
	[CalledBy(Type = typeof(Graph), Member = "Validate")]
	[CalledBy(Type = typeof(Graph), Member = "DeserializeLocalBlackboard")]
	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "TryResolveGenericType")]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	public static void LogException(Exception exception, string tag = null, object context = null)
	{
	}

	[CalledBy(Type = typeof(Logger), Member = "LogError")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(Graph), Member = "SendTaskOwnerDefaults")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "SendTaskOwnerDefaults")]
	[CalledBy(Type = typeof(Logger), Member = "LogException")]
	[CalledBy(Type = typeof(Logger), Member = "LogException")]
	[CalledBy(Type = typeof(Logger), Member = "LogError")]
	[CalledBy(Type = typeof(Logger), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Logger), Member = "Log")]
	[CalledBy(Type = typeof(Logger), Member = "Log")]
	[Calls(Type = typeof(Logger), Member = "ForwardToUnity")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Logger), Member = "LogWarning")]
	private static void Internal_Log(LogType type, object message, string tag, object context)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsUnknownMethods(Count = 6)]
	private static void ForwardToUnity(LogType type, object message, string tag, object context)
	{
	}
}
