using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization;

public abstract class SerializedMethodBaseInfo : ISerializationCallbackReceiver
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract MethodBase GetBase();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract bool HasChanged();

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	public abstract string GetMethodString();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override string ToString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract void OnBeforeSerialize();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract void OnAfterDeserialize();

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected SerializedMethodBaseInfo()
	{
	}
}
