using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public abstract class Condition_TransmitterCheckBase : ConditionTask<GraphOwner>
{
	public BBParameter<TransmitterData> transmitterSite;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(TransmitterManager), Member = "GetTransmitterState")]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	protected abstract string GetPropertyInfoString(TransmitterRuntimeState state);

	protected abstract bool GetPropertyValue(TransmitterRuntimeState state);

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(TransmitterManager), Member = "GetTransmitterState")]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(TransmitterManager), Member = "GetTransmitterState")]
	[CallsUnknownMethods(Count = 1)]
	private TransmitterRuntimeState GetState()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected Condition_TransmitterCheckBase()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
