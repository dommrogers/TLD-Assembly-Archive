using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
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

	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NCUtils), Member = "ProcessCommandBlockLines")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GlobalBlackboard), Member = "set_name")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_InvokeConcurrentGraph()
	{
	}
}
