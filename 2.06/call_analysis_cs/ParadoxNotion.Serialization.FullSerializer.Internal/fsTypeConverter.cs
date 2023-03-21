using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsTypeConverter : fsConverter
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool RequestCycleSupport(Type type)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool RequestInheritanceSupport(Type type)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CallsUnknownMethods(Count = 3)]
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
	public fsTypeConverter()
	{
	}
}
