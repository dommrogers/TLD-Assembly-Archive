using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization;

[Serializable]
public class SerializedTypeInfo : ISerializationCallbackReceiver
{
	private string _baseInfo;

	[NonSerialized]
	private Type _type;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SerializedTypeInfo()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 77)]
	public SerializedTypeInfo(Type info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 35)]
	public Type Get()
	{
		return null;
	}
}
