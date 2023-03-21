using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsListConverter : fsConverter
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsMetaType), Member = "Get")]
	[Calls(Type = typeof(fsMetaType), Member = "CreateInstance")]
	[CallsUnknownMethods(Count = 1)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Calls(Type = typeof(fsResult), Member = "AddMessages")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(fsData), Member = "CreateList")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 19)]
	public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
	{
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public fsListConverter()
	{
	}
}
