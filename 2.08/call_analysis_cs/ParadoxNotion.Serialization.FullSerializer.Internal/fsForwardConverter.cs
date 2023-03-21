using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsForwardConverter : fsConverter
{
	private string _memberName;

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public fsForwardConverter(fsForwardAttribute attribute)
	{
	}

	[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(fsForwardConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "TrySerialize")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(fsMetaType), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private fsResult GetProperty(object instance, out fsMetaProperty property)
	{
		property = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsForwardConverter), Member = "GetProperty")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsForwardConverter), Member = "GetProperty")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[CallsUnknownMethods(Count = 1)]
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(fsMetaType), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsMetaType), Member = "CreateInstance")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}
}
