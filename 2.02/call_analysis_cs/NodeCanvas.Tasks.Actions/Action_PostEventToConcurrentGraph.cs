using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_PostEventToConcurrentGraph : ActionTask<GraphOwner>
{
	public string graphId;

	public BBParameter<string> eventName;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Action_PostEventToConcurrentGraph()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
public class Action_PostEventToConcurrentGraph<T> : ActionTask<GraphOwner>
{
	public string graphId;

	public BBParameter<string> eventName;

	public BBParameter<T> eventValue;

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(string), Member = "Concat")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Action_PostEventToConcurrentGraph()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
