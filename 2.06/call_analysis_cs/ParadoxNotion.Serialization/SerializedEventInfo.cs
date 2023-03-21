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
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 85)]
	[DeduplicatedMethod]
	public SerializedEventInfo(EventInfo info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 44)]
	public EventInfo Get()
	{
		return null;
	}
}
