using System;
using System.Collections.Generic;
using System.Linq;
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
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		public bool IsSameAs(Message b)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		public bool IsValid()
		{
			return false;
		}
	}

	public delegate bool LogHandler(Message message);

	private static List<LogHandler> subscribers;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void AddListener(LogHandler callback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveListener(LogHandler callback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Log(object message, Enum tag = null, object context = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Log(object message, string tag = null, object context = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void LogWarning(object message, Enum tag = null, object context = null)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CalledBy(Type = typeof(Node), Member = "Warn")]
	[CalledBy(Type = typeof(Node), Member = "IsNewConnectionAllowed")]
	[CalledBy(TypeFullName = "NodeCanvas.Framework.BBParameter`1.<>c__DisplayClass16_0", Member = "<BindSetter>b__1")]
	[CalledBy(Type = typeof(FSMState), Member = "CanConnectFromSource")]
	[CalledBy(Type = typeof(FSMState), Member = "CanConnectToTarget")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogWarning(object message, string tag = null, object context = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void LogError(object message, Enum tag = null, object context = null)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "LoadGraphData")]
	[CalledBy(Type = typeof(Node), Member = "Create")]
	[CalledBy(Type = typeof(Node), Member = "Duplicate")]
	[CalledBy(Type = typeof(Node), Member = "Error")]
	[CalledBy(Type = typeof(Node), Member = "Fail")]
	[CalledBy(Type = typeof(Node), Member = "RegisterEvents")]
	[CalledBy(Type = typeof(Task), Member = "SetOwnerSystem")]
	[CalledBy(Type = typeof(Task), Member = "Error")]
	[CalledBy(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	[CalledBy(Type = typeof(MessageRouter), Member = "Register")]
	[CalledBy(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogError(object message, string tag = null, object context = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void LogException(Exception exception, Enum tag = null, object context = null)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
	[CalledBy(Type = typeof(Graph), Member = "DeserializeLocalBlackboard")]
	[CalledBy(Type = typeof(Graph), Member = "Validate")]
	[CalledBy(Type = typeof(Node), Member = "Error")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "TryResolveGenericType")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Logger), Member = "Internal_Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogException(Exception exception, string tag = null, object context = null)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(Logger), Member = "Log")]
	[CalledBy(Type = typeof(Logger), Member = "Log")]
	[CalledBy(Type = typeof(Logger), Member = "LogWarning")]
	[CalledBy(Type = typeof(Logger), Member = "LogWarning")]
	[CalledBy(Type = typeof(Logger), Member = "LogError")]
	[CalledBy(Type = typeof(Logger), Member = "LogError")]
	[CalledBy(Type = typeof(Logger), Member = "LogException")]
	[CalledBy(Type = typeof(Logger), Member = "LogException")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(LogHandler), Member = "Invoke")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Logger), Member = "ForwardToUnity")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private static void Internal_Log(LogType type, object message, string tag, object context)
	{
	}

	[CalledBy(Type = typeof(Logger), Member = "Internal_Log")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static void ForwardToUnity(LogType type, object message, string tag, object context)
	{
	}
}
