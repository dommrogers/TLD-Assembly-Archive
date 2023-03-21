using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsReflectedConverter : fsConverter
{
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[Calls(Type = typeof(fsResult), Member = "AddMessages")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsMetaType), Member = "CreateInstance")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[Calls(Type = typeof(fsData), Member = "CreateDictionary")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsMetaType), Member = "Get")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(fsResult), Member = "AddMessages")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsMetaType), Member = "Get")]
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
	public fsReflectedConverter()
	{
	}
}
