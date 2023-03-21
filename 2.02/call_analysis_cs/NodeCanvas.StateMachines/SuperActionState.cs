using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class SuperActionState : FSMState, ISubTasksContainer
{
	private ActionList _onEnterList;

	private ActionList _onUpdateList;

	private ActionList _onExitList;

	private bool enterListFinished;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[Calls(Type = typeof(Task), Member = "Create")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 6)]
	public override void OnValidate(Graph assignedGraph)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	protected override void OnExit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "PauseAction")]
	[Calls(Type = typeof(ActionTask), Member = "PauseAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public SuperActionState()
	{
	}
}
