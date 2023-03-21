using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_InvokeConcurrentGraph : ActionTask
{
	public string graphId;

	public FSM graphAsset;

	public bool useParentBlackboard;

	public string customGlobalBlackboardId;

	public string varAssignments;

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NCUtils), Member = "ProcessCommandBlockLines")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "set_name")]
	[Calls(Type = typeof(Variable), Member = "OnValueChanged")]
	[Calls(Type = typeof(Blackboard), Member = "AddVariable")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 36)]
	protected override void OnExecute()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Action_InvokeConcurrentGraph()
	{
	}
}
