using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_PostEventToConcurrentGraph : ActionTask<GraphOwner>
{
	public string graphId;

	public BBParameter<string> eventName;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Tasks_Actions_Action_PostEventToConcurrentGraph_Collision", Member = ".ctor")]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Tasks_Actions_Action_PostEventToConcurrentGraph_Collision2D", Member = ".ctor")]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Tasks_Actions_Action_PostEventToConcurrentGraph_Space", Member = ".ctor")]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Tasks_Actions_Action_PostEventToConcurrentGraph_SpawnLocation", Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Action_PostEventToConcurrentGraph()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
