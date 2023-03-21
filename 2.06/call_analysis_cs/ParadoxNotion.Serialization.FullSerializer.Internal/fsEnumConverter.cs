using System;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsEnumConverter : fsConverter
{
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToObject")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[Calls(Type = typeof(Convert), Member = "ToInt64")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Convert), Member = "ToInt64")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Convert), Member = "ToInt64")]
	[Calls(Type = typeof(Enum), Member = "GetName")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(Enum), Member = "ToObject")]
	[Calls(Type = typeof(Enum), Member = "ToObject")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static bool ArrayContains<T>(T[] values, T value)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public fsEnumConverter()
	{
	}
}
