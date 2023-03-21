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

		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(HashSet<>), Member = "Contains")]
		[Calls(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
		[Calls(Type = typeof(fsData), Member = "Cast")]
		[Calls(Type = typeof(int), Member = "ToString")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public void WriteDefinition(int id, fsData data)
		{
		}

		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
		[Calls(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
		[Calls(Type = typeof(fsData), Member = "Cast")]
		[Calls(Type = typeof(int), Member = "ToString")]
		[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		public void WriteReference(int id, Dictionary<string, fsData> dict)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	public static bool IsReservedKeyword(string key)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsObjectReference(fsData data)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsObjectDefinition(fsData data)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsVersioned(fsData data)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsTypeSpecified(fsData data)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsWrappedData(fsData data)
	{
		return false;
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance)
	{
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
	{
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance)
	{
	}

	[CalledBy(Type = typeof(fsLazyCycleDefinitionWriter), Member = "WriteDefinition")]
	[CalledBy(Type = typeof(fsLazyCycleDefinitionWriter), Member = "WriteReference")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void EnsureDictionary(fsData data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetImplementationsOf")]
	static fsSerializer()
	{
	}

	[CalledBy(Type = typeof(JSONSerializer), Member = ".cctor")]
	[CalledBy(Type = typeof(fsBBParameterProcessor), Member = "OnBeforeDeserializeAfterInstanceCreation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = ".ctor")]
	[Calls(Type = typeof(fsConfig), Member = ".ctor")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(fsSerializer), Member = "AddConverter")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	public fsSerializer()
	{
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private List<fsObjectProcessor> GetProcessors(Type type)
	{
		return null;
	}

	[CalledBy(Type = typeof(fsSerializer), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 20)]
	public void AddConverter(fsBaseConverter converter)
	{
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
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

	[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "SerializeMember")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(GUIStyleState_DirectConverter), Member = "DoSerialize")]
	[CalledBy(Type = typeof(GUIStyle_DirectConverter), Member = "DoSerialize")]
	[CalledBy(Type = typeof(fsBBParameterProcessor), Member = "OnBeforeDeserializeAfterInstanceCreation")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(fsSerializer), Member = "GetProcessors")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnBeforeSerialize")]
	[Calls(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "Exit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnAfterSerialize")]
	[CallsUnknownMethods(Count = 1)]
	public fsResult TrySerialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsSerializer), Member = "GetConverter")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	[Calls(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsLazyCycleDefinitionWriter), Member = "WriteDefinition")]
	[Calls(Type = typeof(fsData), Member = "CreateDictionary")]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[Calls(Type = typeof(fsLazyCycleDefinitionWriter), Member = "WriteReference")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(fsResult), Member = "Warn")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
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

	[CalledBy(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "DeserializeMember")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsBBParameterProcessor), Member = "OnBeforeDeserializeAfterInstanceCreation")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "Exit")]
	[Calls(Type = typeof(Logger), Member = "LogException")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(fsSerializer), Member = "GetProcessors")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnBeforeDeserialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	public fsResult TryDeserialize(fsData data, Type storageType, Type overrideConverterType, ref object result)
	{
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(int), Member = "Parse")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(fsSerializer), Member = "GetProcessors")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnBeforeDeserialize")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(fsSerializer), Member = "GetConverter")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(fsResult), Member = "Warn")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	private fsResult Internal_Deserialize(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
	{
		processors = null;
		return default(fsResult);
	}
}
