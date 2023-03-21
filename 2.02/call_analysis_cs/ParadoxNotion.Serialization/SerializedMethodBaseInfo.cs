using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization;

public abstract class SerializedMethodBaseInfo : ISerializationCallbackReceiver
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract MethodBase GetBase();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract bool HasChanged();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract string GetMethodString();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract void OnBeforeSerialize();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract void OnAfterDeserialize();

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected SerializedMethodBaseInfo()
	{
	}
}
