using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Serialization.FullSerializer.Internal;
using ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;
using ParadoxNotion.Services;

namespace ParadoxNotion.Serialization.FullSerializer;

public class fsSerializer
{
	internal class fsLazyCycleDefinitionWriter
	{
		private Dictionary<int, fsData> _pendingDefinitions;

		private HashSet<int> _references;

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
		[Calls(Type = typeof(int), Member = "ToString")]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
		[CallsUnknownMethods(Count = 3)]
		public void WriteDefinition(int id, fsData data)
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
		[Calls(Type = typeof(int), Member = "ToString")]
		[Calls(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(int), Member = "ToString")]
		public void WriteReference(int id, Dictionary<string, fsData> dict)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		public fsLazyCycleDefinitionWriter()
		{
		}
	}

	public const string KEY_OBJECT_REFERENCE = "$ref";

	public const string KEY_OBJECT_DEFINITION = "$id";

	public const string KEY_INSTANCE_TYPE = "$type";

	public const string KEY_VERSION = "$version";

	public const string KEY_CONTENT = "$content";

	private Dictionary<Type, fsBaseConverter> _cachedOverrideConverterInstances;

	private Dictionary<Type, fsBaseConverter> _cachedConverters;

	private readonly List<fsConverter> _availableConverters;

	private readonly Dictionary<Type, fsDirectConverter> _availableDirectConverters;

	private static readonly Type[] _directConverterTypes;

	private readonly List<fsObjectProcessor> _processors;

	private Dictionary<Type, List<fsObjectProcessor>> _cachedProcessors;

	private readonly fsCyclicReferenceManager _references;

	private readonly fsLazyCycleDefinitionWriter _lazyReferenceWriter;

	public fsContext Context;

	public fsConfig Config;

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	public static bool IsReservedKeyword(string key)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool IsObjectReference(fsData data)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsObjectDefinition(fsData data)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsVersioned(fsData data)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool IsTypeSpecified(fsData data)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsWrappedData(fsData data)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 2)]
	private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[CalledBy(Type = typeof(fsLazyCycleDefinitionWriter), Member = "WriteDefinition")]
	[CalledBy(Type = typeof(fsLazyCycleDefinitionWriter), Member = "WriteReference")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CallsUnknownMethods(Count = 2)]
	private static void EnsureDictionary(fsData data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetImplementationsOf")]
	static fsSerializer()
	{
	}

	[CalledBy(Type = typeof(fsBBParameterProcessor), Member = "OnBeforeDeserializeAfterInstanceCreation")]
	[CalledBy(Type = typeof(JSONSerializer), Member = ".cctor")]
	[Calls(Type = typeof(fsSerializer), Member = "AddConverter")]
	[Calls(Type = typeof(fsSerializer), Member = "AddConverter")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(fsConfig), Member = ".ctor")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	public fsSerializer()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private List<fsObjectProcessor> GetProcessors(Type type)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(fsSerializer), Member = ".ctor")]
	[CalledBy(Type = typeof(fsSerializer), Member = ".ctor")]
	[CallsUnknownMethods(Count = 21)]
	public void AddConverter(fsBaseConverter converter)
	{
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 3)]
	private fsBaseConverter GetConverter(Type type, Type overrideConverterType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	public fsResult TrySerialize<T>(T instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	public fsResult TrySerialize(Type storageType, object instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsArrayConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GUIStyleState_DirectConverter), Member = "DoSerialize")]
	[CalledBy(Type = typeof(GUIStyle_DirectConverter), Member = "DoSerialize")]
	[CalledBy(Type = typeof(fsBBParameterProcessor), Member = "OnBeforeDeserializeAfterInstanceCreation")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnAfterSerialize")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnAfterSerialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "Exit")]
	[Calls(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnBeforeSerialize")]
	[Calls(Type = typeof(fsSerializer), Member = "GetProcessors")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "SerializeMember")]
	[CallerCount(Count = 13)]
	public fsResult TrySerialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsData), Member = "CreateDictionary")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(fsResult), Member = "Warn")]
	[Calls(Type = typeof(fsLazyCycleDefinitionWriter), Member = "WriteDefinition")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	[Calls(Type = typeof(fsLazyCycleDefinitionWriter), Member = "WriteReference")]
	[Calls(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(fsSerializer), Member = "GetConverter")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	[Calls(Type = typeof(fsSerializer), Member = "GetConverter")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	private fsResult Internal_Serialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 6)]
	public fsResult TryDeserialize<T>(fsData data, ref T instance)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	public fsResult TryDeserialize(fsData data, Type storageType, ref object result)
	{
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(fsListConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsBBParameterProcessor), Member = "OnBeforeDeserializeAfterInstanceCreation")]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "Exit")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "DeserializeMember")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "Exit")]
	[Calls(Type = typeof(Logger), Member = "LogException")]
	[Calls(Type = typeof(fsSerializer), Member = "GetProcessors")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnBeforeDeserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	public fsResult TryDeserialize(fsData data, Type storageType, Type overrideConverterType, ref object result)
	{
		return default(fsResult);
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(int), Member = "Parse")]
	[Calls(Type = typeof(fsResult), Member = "Warn")]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnBeforeDeserialize")]
	[Calls(Type = typeof(fsSerializer), Member = "GetConverter")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsSerializer), Member = "GetProcessors")]
	[Calls(Type = typeof(int), Member = "Parse")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(fsSerializer), Member = "GetProcessors")]
	private fsResult Internal_Deserialize(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
	{
		processors = null;
		return default(fsResult);
	}
}
