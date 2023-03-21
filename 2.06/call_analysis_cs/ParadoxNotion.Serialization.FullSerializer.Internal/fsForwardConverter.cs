using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsForwardConverter : fsConverter
{
	private string _memberName;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public fsForwardConverter(fsForwardAttribute attribute)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "TrySerialize")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(fsMetaType), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	private fsResult GetProperty(object instance, out fsMetaProperty property)
	{
		property = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(fsForwardConverter), Member = "GetProperty")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsForwardConverter), Member = "GetProperty")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
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
}
