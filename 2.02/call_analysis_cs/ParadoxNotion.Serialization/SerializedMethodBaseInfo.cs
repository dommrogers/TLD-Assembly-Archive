using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization;

public abstract class SerializedMethodBaseInfo : ISerializationCallbackReceiver
{
	public abstract MethodBase GetBase();

	public abstract bool HasChanged();

	public abstract string GetMethodString();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override string ToString()
	{
		return null;
	}

	public abstract void OnBeforeSerialize();

	public abstract void OnAfterDeserialize();

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected SerializedMethodBaseInfo()
	{
	}
}
