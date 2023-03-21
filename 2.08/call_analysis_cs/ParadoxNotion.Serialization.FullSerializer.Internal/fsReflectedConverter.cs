using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsReflectedConverter : fsConverter
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[Calls(Type = typeof(fsResult), Member = "AddMessages")]
	[Calls(Type = typeof(fsMetaType), Member = "CreateInstance")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "CreateDictionary")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsMetaType), Member = "Get")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsMetaType), Member = "Get")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "AddMessages")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[CallsUnknownMethods(Count = 4)]
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(fsMetaType), Member = "CreateInstance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsMetaType), Member = "Get")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public fsReflectedConverter()
	{
	}
}
