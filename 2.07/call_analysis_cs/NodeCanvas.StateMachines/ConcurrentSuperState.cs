using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class ConcurrentSuperState : FSMState, IUpdatable
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
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public ActionList onUpdateList
	{
		[CallerCount(Count = 59)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		set
		{
		}
	}

	public override int maxInConnections
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	public override string name
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Node), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[Calls(Type = typeof(Task), Member = "Create")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "Create")]
	public override void OnValidate(Graph assignedGraph)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public new void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
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
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	public ConcurrentSuperState()
	{
	}
}
