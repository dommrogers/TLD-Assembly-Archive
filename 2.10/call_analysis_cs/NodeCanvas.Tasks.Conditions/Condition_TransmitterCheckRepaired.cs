using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_TransmitterCheckRepaired : Condition_TransmitterCheckBase
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 1)]
	protected override string GetPropertyInfoString(TransmitterRuntimeState state)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override bool GetPropertyValue(TransmitterRuntimeState state)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_TransmitterCheckRepaired()
	{
	}
}
