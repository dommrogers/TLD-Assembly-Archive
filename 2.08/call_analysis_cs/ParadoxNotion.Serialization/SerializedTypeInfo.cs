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

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SerializedTypeInfo()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 79)]
	public SerializedTypeInfo(Type info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 28)]
	public Type Get()
	{
		return null;
	}
}
