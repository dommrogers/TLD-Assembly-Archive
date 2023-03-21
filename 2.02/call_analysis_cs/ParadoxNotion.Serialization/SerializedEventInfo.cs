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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetEvent")]
	[CallsUnknownMethods(Count = 10)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SerializedEventInfo()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 71)]
	public SerializedEventInfo(EventInfo info)
	{
	}

	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	public EventInfo Get()
	{
		return null;
	}
}
