using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsListConverter : fsConverter
{
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[Calls(Type = typeof(fsMetaType), Member = "Get")]
	[Calls(Type = typeof(fsMetaType), Member = "CreateInstance")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[Calls(Type = typeof(fsResult), Member = "AddMessages")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(fsData), Member = "CreateList")]
	[CallerCount(Count = 0)]
	public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public fsListConverter()
	{
	}
}
