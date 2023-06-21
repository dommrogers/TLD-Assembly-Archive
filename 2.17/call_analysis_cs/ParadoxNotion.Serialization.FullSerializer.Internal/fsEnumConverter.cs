using System;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsEnumConverter : fsConverter
{
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
	[Calls(Type = typeof(Enum), Member = "ToObject")]
	[CallsUnknownMethods(Count = 2)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTIsDefined")]
	[Calls(Type = typeof(Convert), Member = "ToInt64")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 26)]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(Enum), Member = "ToObject")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static bool ArrayContains<T>(T[] values, T value)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public fsEnumConverter()
	{
	}
}
