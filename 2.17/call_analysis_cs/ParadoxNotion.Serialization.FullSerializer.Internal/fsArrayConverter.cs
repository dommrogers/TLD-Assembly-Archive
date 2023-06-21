using System;
using System.Collections;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsArrayConverter : fsConverter
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override bool CanProcess(Type type)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool RequestCycleSupport(Type storageType)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool RequestInheritanceSupport(Type storageType)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsData), Member = "CreateList")]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[Calls(Type = typeof(fsResult), Member = "AddMessages")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "AddMessages")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public fsArrayConverter()
	{
	}
}
