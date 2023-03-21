using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class ConcurrentSuperState : FSMState, IUpdatable, ISubTasksContainer
{
	private ActionList _onEnterList;

	private ActionList _onUpdateList;

	private ActionList _onExitList;

	public ActionList onEnterList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public ActionList onUpdateList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		set
		{
		}
	}

	public ActionList onExitList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public override int maxInConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public override int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public override bool allowAsPrime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public override string name
	{
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[Calls(Type = typeof(Node), Member = "get_name")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[CallsUnknownMethods(Count = 6)]
	public override void OnValidate(Graph assignedGraph)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public new void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public ConcurrentSuperState()
	{
	}
}
