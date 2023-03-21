using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_PostEventToConcurrentGraph : ActionTask<GraphOwner>
{
	public string graphId;

	public BBParameter<string> eventName;

	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_PostEventToConcurrentGraph()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
