using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization;

public abstract class SerializedMethodBaseInfo : ISerializationCallbackReceiver
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract MethodBase GetBase();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract bool HasChanged();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract string GetMethodString();

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override string ToString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract void OnBeforeSerialize();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract void OnAfterDeserialize();

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected SerializedMethodBaseInfo()
	{
	}
}
