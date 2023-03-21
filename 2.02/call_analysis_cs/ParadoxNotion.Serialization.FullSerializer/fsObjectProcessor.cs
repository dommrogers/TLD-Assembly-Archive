using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public abstract class fsObjectProcessor
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool CanProcess(Type type)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void OnBeforeSerialize(Type storageType, object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnAfterSerialize(Type storageType, object instance, ref fsData data)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnBeforeDeserialize(Type storageType, ref fsData data)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnAfterDeserialize(Type storageType, object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected fsObjectProcessor()
	{
	}
}
