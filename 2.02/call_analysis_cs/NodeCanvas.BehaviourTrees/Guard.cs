using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class Guard : BTDecorator
{
	public enum GuardMode
	{
		ReturnFailure,
		WaitUntilReleased
	}

	public BBParameter<string> token;

	public GuardMode ifGuarded;

	private bool isGuarding;

	private static readonly Dictionary<GameObject, List<Guard>> guards;

	[CalledBy(Type = typeof(Guard), Member = "OnExecute")]
	[CalledBy(Type = typeof(Guard), Member = "SetGuards")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static List<Guard> AgentGuards(Component agent)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Guard), Member = "SetGuards")]
	public override void OnGraphStarted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Guard), Member = "SetGuards")]
	[Calls(Type = typeof(Guard), Member = "AgentGuards")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[CalledBy(Type = typeof(Guard), Member = "OnGraphStarted")]
	[CalledBy(Type = typeof(Guard), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Guard), Member = "AgentGuards")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	private void SetGuards(Component guardAgent)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public Guard()
	{
	}
}
