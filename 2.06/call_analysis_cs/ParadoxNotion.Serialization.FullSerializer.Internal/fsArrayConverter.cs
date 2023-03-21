using System;
using System.Collections;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsArrayConverter : fsConverter
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 1)]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(fsResult), Member = "AddMessages")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(fsData), Member = "CreateList")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(fsResult), Member = "AddMessages")]
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsMetaType), Member = "Get")]
	[Calls(Type = typeof(fsMetaType), Member = "CreateInstance")]
	[CallsUnknownMethods(Count = 1)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public fsArrayConverter()
	{
	}
}
