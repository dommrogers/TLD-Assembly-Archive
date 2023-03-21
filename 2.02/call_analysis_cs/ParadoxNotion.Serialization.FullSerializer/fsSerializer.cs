using System;
using System.Collections.Generic;
using System.Globalization;
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
		[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
		[CallsUnknownMethods(Count = 23)]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
		[Calls(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 1)]
		public void WriteDefinition(int id, fsData data)
		{
		}

		[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
		[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
		[CallsUnknownMethods(Count = 21)]
		[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
		[Calls(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		public void WriteReference(int id, Dictionary<string, fsData> dict)
		{
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		public void Clear()
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CalledBy(Type = typeof(fsSerializer), Member = ".ctor")]
		[CallsUnknownMethods(Count = 16)]
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
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static bool IsReservedKeyword(string key)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsObjectReference(fsData data)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private static bool IsObjectDefinition(fsData data)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsVersioned(fsData data)
	{
		return default(bool);
	}

	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static bool IsTypeSpecified(fsData data)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsWrappedData(fsData data)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 9)]
	private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance)
	{
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
	{
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "Clone")]
	[Calls(Type = typeof(fsData), Member = "BecomeDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CalledBy(Type = typeof(fsLazyCycleDefinitionWriter), Member = "WriteDefinition")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(fsLazyCycleDefinitionWriter), Member = "WriteReference")]
	private static void EnsureDictionary(fsData data)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetImplementationsOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	static fsSerializer()
	{
	}

	[CallsUnknownMethods(Count = 146)]
	[CalledBy(Type = typeof(fsBBParameterProcessor), Member = "OnBeforeDeserializeAfterInstanceCreation")]
	[Calls(Type = typeof(fsSerializer), Member = "AddConverter")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(fsConfig), Member = ".ctor")]
	[CalledBy(Type = typeof(JSONSerializer), Member = ".cctor")]
	[Calls(Type = typeof(fsLazyCycleDefinitionWriter), Member = ".ctor")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(fsContext), Member = ".ctor")]
	public fsSerializer()
	{
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CallsUnknownMethods(Count = 24)]
	private List<fsObjectProcessor> GetProcessors(Type type)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(fsSerializer), Member = ".ctor")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	public void AddConverter(fsBaseConverter converter)
	{
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 3)]
	private fsBaseConverter GetConverter(Type type, Type overrideConverterType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 1)]
	public fsResult TrySerialize<T>(T instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallerCount(Count = 0)]
	public fsResult TrySerialize(Type storageType, object instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(GUIStyle_DirectConverter), Member = "DoSerialize")]
	[CalledBy(Type = typeof(GUIStyleState_DirectConverter), Member = "DoSerialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "SerializeMember")]
	[CalledBy(Type = typeof(fsBBParameterProcessor), Member = "OnBeforeDeserializeAfterInstanceCreation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnAfterSerialize")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnAfterSerialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "Exit")]
	[Calls(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnBeforeSerialize")]
	[Calls(Type = typeof(fsSerializer), Member = "GetProcessors")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CallerCount(Count = 13)]
	public fsResult TrySerialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(fsLazyCycleDefinitionWriter), Member = "WriteDefinition")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(fsLazyCycleDefinitionWriter), Member = "WriteReference")]
	[Calls(Type = typeof(fsResult), Member = "Warn")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	[Calls(Type = typeof(fsData), Member = "CreateDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsSerializer), Member = "EnsureDictionary")]
	[Calls(Type = typeof(fsSerializer), Member = "GetConverter")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	[Calls(Type = typeof(fsSerializer), Member = "GetConverter")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	private fsResult Internal_Serialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "DeserializeMember")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CalledBy(Type = typeof(fsBBParameterProcessor), Member = "OnBeforeDeserializeAfterInstanceCreation")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[Calls(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnAfterDeserialize")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "Exit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "Exit")]
	[Calls(Type = typeof(fsSerializer), Member = "GetProcessors")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnBeforeDeserialize")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnAfterDeserialize")]
	[Calls(Type = typeof(Logger), Member = "LogException")]
	public fsResult TryDeserialize(fsData data, Type storageType, Type overrideConverterType, ref object result)
	{
		return default(fsResult);
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(fsSerializer), Member = "GetConverter")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(System.Number), Member = "ParseInt32")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(fsResult), Member = "Warn")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "ParseInt32")]
	[Calls(Type = typeof(fsSerializer), Member = "GetProcessors")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsSerializer), Member = "Invoke_OnBeforeDeserialize")]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(fsData), Member = "get_IsString")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(fsSerializer), Member = "GetProcessors")]
	private fsResult Internal_Deserialize(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
	{
		processors = null;
		return default(fsResult);
	}
}
