using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsDictionaryConverter : fsConverter
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[Calls(Type = typeof(fsMetaType), Member = "CreateInstance")]
	[Calls(Type = typeof(fsMetaType), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 60)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "CreateDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(fsData), Member = "get_IsString")]
	[Calls(Type = typeof(fsData), Member = "CreateList")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsSerializer), Member = "IsReservedKeyword")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsBaseConverter), Member = "FailExpectedType")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
	{
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public fsDictionaryConverter()
	{
	}
}
