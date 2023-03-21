using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_PostEventToConcurrentGraph : ActionTask<GraphOwner>
{
	public string graphId;

	public BBParameter<string> eventName;

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(string), Member = "Concat")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_PostEventToConcurrentGraph()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
