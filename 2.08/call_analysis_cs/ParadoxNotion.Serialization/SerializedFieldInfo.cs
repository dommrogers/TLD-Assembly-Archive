using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization;

[Serializable]
public class SerializedFieldInfo : ISerializationCallbackReceiver
{
	private string _baseInfo;

	[NonSerialized]
	private FieldInfo _field;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 1)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SerializedFieldInfo()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 79)]
	public SerializedFieldInfo(FieldInfo info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 28)]
	public FieldInfo Get()
	{
		return null;
	}
}
