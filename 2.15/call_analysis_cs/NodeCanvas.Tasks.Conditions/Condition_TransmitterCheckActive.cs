using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_TransmitterCheckActive : Condition_TransmitterCheckBase
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 2)]
	protected override string GetPropertyInfoString(TransmitterRuntimeState state)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected override bool GetPropertyValue(TransmitterRuntimeState state)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_TransmitterCheckActive()
	{
	}
}
