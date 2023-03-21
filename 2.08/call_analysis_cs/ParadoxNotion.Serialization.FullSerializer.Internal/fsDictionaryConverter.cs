using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsDictionaryConverter : fsConverter
{
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(fsMetaType), Member = "CreateInstance")]
	[Calls(Type = typeof(fsMetaType), Member = "Get")]
	[CallerCount(Count = 0)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(fsData), Member = "CreateDictionary")]
	[Calls(Type = typeof(fsData), Member = "CreateList")]
	[Calls(Type = typeof(fsData), Member = "get_IsString")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsSerializer), Member = "IsReservedKeyword")]
	[Calls(Type = typeof(fsBaseConverter), Member = "FailExpectedType")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
	{
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public fsDictionaryConverter()
	{
	}
}
