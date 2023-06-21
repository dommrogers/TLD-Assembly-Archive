using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

namespace ParadoxNotion.Serialization;

public static class JSONSerializer
{
	private static bool _003CapplicationPlaying_003Ek__BackingField;

	private static Dictionary<string, fsData> cache;

	private static object serializerLock;

	private static fsSerializer serializer;

	public static bool applicationPlaying
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsSerializer), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	static JSONSerializer()
	{
	}

	[CalledBy(Type = typeof(JSONSerializer), Member = "Clone")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Clone")]
	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	[CalledBy(Type = typeof(Graph), Member = "SerializeLocalBlackboard")]
	[CalledBy(Type = typeof(Graph), Member = "CopySerialized")]
	[CalledBy(Type = typeof(Blackboard), Member = "Serialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "Serialize")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	public static string Serialize(Type type, object instance, bool pretyJson = false, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
	[CalledBy(Type = typeof(Graph), Member = "DeserializeLocalBlackboard")]
	[CalledBy(Type = typeof(Blackboard), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	public static T Deserialize<T>(string json, List<UnityEngine.Object> objectReferences = null)
	{
		return default(T);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	public static object Deserialize(Type type, string json, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	public static T DeserializeOverwrite<T>(T instance, string json, List<UnityEngine.Object> objectReferences = null)
	{
		return default(T);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public static object DeserializeOverwrite(object instance, string json, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(JSONSerializer), Member = "Deserialize")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Deserialize")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "DeserializeOverwrite")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "DeserializeOverwrite")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Clone")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Clone")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(fsJsonParser), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	public static object Internal_Deserialize(Type type, string json, List<UnityEngine.Object> objectReferences, object instance)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Connection), Member = "Duplicate")]
	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CalledBy(Type = typeof(Node), Member = "Duplicate")]
	[CalledBy(Type = typeof(Task), Member = "Duplicate")]
	[CalledBy(Type = typeof(Statement), Member = "BlackboardReplace")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	public static T Clone<T>(T original, List<UnityEngine.Object> objectReferences = null)
	{
		return default(T);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public static object Clone(object original, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsJsonParser), Member = "Parse")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[Calls(Type = typeof(Path), Member = "GetTempPath")]
	[Calls(TypeFullName = "Interop", Member = "GetRandomBytes")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "WriteAllText")]
	[Calls(Type = typeof(Process), Member = "Start")]
	public static void ShowData(string json, string fileName = "")
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsJsonParser), Member = "Parse")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	public static string PrettifyJson(string json)
	{
		return null;
	}
}
