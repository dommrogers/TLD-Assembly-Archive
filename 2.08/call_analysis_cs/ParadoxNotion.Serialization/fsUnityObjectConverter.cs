using System;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Serialization.FullSerializer;

namespace ParadoxNotion.Serialization;

public class fsUnityObjectConverter : fsConverter
{
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool RequestCycleSupport(Type storageType)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool RequestInheritanceSupport(Type storageType)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(fsResult), Member = "Warn")]
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public fsUnityObjectConverter()
	{
	}
}
