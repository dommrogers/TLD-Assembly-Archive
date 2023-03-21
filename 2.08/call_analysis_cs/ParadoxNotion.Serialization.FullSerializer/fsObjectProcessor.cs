using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public abstract class fsObjectProcessor
{
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public virtual bool CanProcess(Type type)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnBeforeSerialize(Type storageType, object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnAfterSerialize(Type storageType, object instance, ref fsData data)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnBeforeDeserialize(Type storageType, ref fsData data)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnAfterDeserialize(Type storageType, object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected fsObjectProcessor()
	{
	}
}
