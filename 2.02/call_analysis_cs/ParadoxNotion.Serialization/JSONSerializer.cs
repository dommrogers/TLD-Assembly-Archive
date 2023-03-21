using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(fsSerializer), Member = ".ctor")]
	[CallsUnknownMethods(Count = 22)]
	static JSONSerializer()
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "SerializeLocalBlackboard")]
	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Clone")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Clone")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	public static string Serialize(Type type, object instance, bool pretyJson = false, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public static T Deserialize<T>(string json, List<UnityEngine.Object> objectReferences = null)
	{
		return (T)null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	public static object Deserialize(Type type, string json, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static T DeserializeOverwrite<T>(T instance, string json, List<UnityEngine.Object> objectReferences = null)
	{
		return (T)null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public static object DeserializeOverwrite(object instance, string json, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(JSONSerializer), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Clone")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Clone")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "DeserializeOverwrite")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "DeserializeOverwrite")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Deserialize")]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsJsonParser), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	public static object Internal_Deserialize(Type type, string json, List<UnityEngine.Object> objectReferences, object instance)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 3)]
	public static T Clone<T>(T original, List<UnityEngine.Object> objectReferences = null)
	{
		return (T)null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public static object Clone(object original, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(Process), Member = "Start")]
	[Calls(Type = typeof(File), Member = "WriteAllText")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Guid), Member = "NewGuid")]
	[Calls(Type = typeof(fsJsonParser), Member = "Parse")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[CallsDeduplicatedMethods(Count = 3)]
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
