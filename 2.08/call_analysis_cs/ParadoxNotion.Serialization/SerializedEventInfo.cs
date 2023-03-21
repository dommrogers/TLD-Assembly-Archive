using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization;

[Serializable]
public class SerializedEventInfo : ISerializationCallbackReceiver
{
	private string _baseInfo;

	[NonSerialized]
	private EventInfo _event;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetEvent")]
	[CallsUnknownMethods(Count = 2)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SerializedEventInfo()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 79)]
	public SerializedEventInfo(EventInfo info)
	{
	}

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public EventInfo Get()
	{
		return null;
	}
}
