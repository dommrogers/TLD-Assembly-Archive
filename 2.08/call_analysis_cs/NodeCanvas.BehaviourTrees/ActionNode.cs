using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class ActionNode : BTNode, ITaskAssignable<ActionTask>, ITaskAssignable
{
	private ActionTask _action;

	public Task task
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public ActionTask action
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public override string name
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(Node), Member = "get_name")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnReset()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "PauseAction")]
	[CallerCount(Count = 0)]
	public override void OnGraphPaused()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	public ActionNode()
	{
	}
}
