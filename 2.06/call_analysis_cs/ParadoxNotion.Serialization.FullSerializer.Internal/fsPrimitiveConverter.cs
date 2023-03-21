using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsPrimitiveConverter : fsConverter
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool RequestCycleSupport(Type storageType)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool RequestInheritanceSupport(Type storageType)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static bool UseBool(Type type)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static bool UseInt64(Type type)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	private static bool UseDouble(Type type)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static bool UseString(Type type)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[Calls(Type = typeof(decimal), Member = "op_Explicit")]
	[Calls(Type = typeof(decimal.DecCalc), Member = "VarDecFromR4")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsPrimitiveConverter), Member = "UseInt64")]
	[Calls(Type = typeof(fsPrimitiveConverter), Member = "UseDouble")]
	[Calls(Type = typeof(fsPrimitiveConverter), Member = "UseString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsPrimitiveConverter), Member = "UseBool")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(fsData), Member = "get_IsString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(fsData), Member = "get_AsInt64")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(fsPrimitiveConverter), Member = "UseBool")]
	[Calls(Type = typeof(fsPrimitiveConverter), Member = "UseDouble")]
	[Calls(Type = typeof(fsPrimitiveConverter), Member = "UseInt64")]
	[Calls(Type = typeof(fsPrimitiveConverter), Member = "UseString")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public fsPrimitiveConverter()
	{
	}
}
