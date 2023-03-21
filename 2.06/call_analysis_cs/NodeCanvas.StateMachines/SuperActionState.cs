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
	[CallsUnknownMethods(Count = 13)]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[Calls(Type = typeof(Task), Member = "Create")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public override void OnValidate(Graph assignedGraph)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnEnter()
	{
	}

	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExit()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "PauseAction")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ActionTask), Member = "PauseAction")]
	protected override void OnPause()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public SuperActionState()
	{
	}
}
