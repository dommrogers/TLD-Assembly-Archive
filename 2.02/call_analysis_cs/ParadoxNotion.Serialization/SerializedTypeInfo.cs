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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[CallerCount(Count = 0)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SerializedTypeInfo()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 71)]
	public SerializedTypeInfo(Type info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
	public Type Get()
	{
		return null;
	}
}
