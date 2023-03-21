using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Serialization.FullSerializer.Internal;

namespace ParadoxNotion.Serialization.FullSerializer;

public abstract class fsBaseConverter
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<fsDataType, string> _003C_003E9__6_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal string _003CFailExpectedType_003Eb__6_0(fsDataType t)
		{
			return null;
		}
	}

	public fsSerializer Serializer;

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public virtual object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool RequestCycleSupport(Type storageType)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool RequestInheritanceSupport(Type storageType)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);

	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Join")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	protected fsResult FailExpectedType(fsData data, fsDataType[] types)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(fsDirectConverter<>), Member = "TryDeserialize")]
	protected fsResult CheckType(fsData data, fsDataType type)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[CallsUnknownMethods(Count = 1)]
	protected fsResult CheckKey(fsData data, string key, out fsData subitem)
	{
		subitem = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem)
	{
		subitem = null;
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 3)]
	protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, T value)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, out T value)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected fsBaseConverter()
	{
	}
}
