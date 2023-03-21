using System;
using System.Collections.Generic;
using System.Linq;
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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		internal string _003CFailExpectedType_003Eb__6_0(fsDataType t)
		{
			return null;
		}
	}

	public fsSerializer Serializer;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 30)]
	public virtual object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	public virtual bool RequestCycleSupport(Type storageType)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public virtual bool RequestInheritanceSupport(Type storageType)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);

	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CallsUnknownMethods(Count = 40)]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "JoinCore")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	protected fsResult FailExpectedType(fsData data, fsDataType[] types)
	{
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsListConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDirectConverter<>), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	protected fsResult CheckType(fsData data, fsDataType type)
	{
		return default(fsResult);
	}

	[Calls(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected fsResult CheckKey(fsData data, string key, out fsData subitem)
	{
		subitem = null;
		return default(fsResult);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 21)]
	protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem)
	{
		subitem = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, T value)
	{
		return default(fsResult);
	}

	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, out T value)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
		return default(fsResult);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected fsBaseConverter()
	{
	}
}
