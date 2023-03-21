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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsUnknownMethods(Count = 2)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[CallsUnknownMethods(Count = 10)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SerializedFieldInfo()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 71)]
	public SerializedFieldInfo(FieldInfo info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
	public FieldInfo Get()
	{
		return null;
	}
}
