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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsSerializer), Member = ".ctor")]
	[CallsUnknownMethods(Count = 16)]
	static JSONSerializer()
	{
	}

	[CalledBy(Type = typeof(JSONSerializer), Member = "Clone")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Clone")]
	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(Blackboard), Member = "Serialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "Serialize")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[CalledBy(Type = typeof(Graph), Member = "SerializeLocalBlackboard")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	public static T Deserialize<T>(string json, List<UnityEngine.Object> objectReferences = null)
	{
		return (T)null;
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
		return (T)null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	public static object DeserializeOverwrite(object instance, string json, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Clone")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "DeserializeOverwrite")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "DeserializeOverwrite")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Deserialize")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Deserialize")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsJsonParser), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Clone")]
	[CallsUnknownMethods(Count = 22)]
	public static object Internal_Deserialize(Type type, string json, List<UnityEngine.Object> objectReferences, object instance)
	{
		return null;
	}

	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static T Clone<T>(T original, List<UnityEngine.Object> objectReferences = null)
	{
		return (T)null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[Calls(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public static object Clone(object original, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[Calls(Type = typeof(Process), Member = "Start")]
	[Calls(Type = typeof(File), Member = "WriteAllText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(Path), Member = "GetTempPath")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[Calls(Type = typeof(fsJsonParser), Member = "Parse")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
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
