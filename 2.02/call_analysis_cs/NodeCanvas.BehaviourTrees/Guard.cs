using System;
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Guard), Member = "SetGuards")]
	[CalledBy(Type = typeof(Guard), Member = "SetGuards")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Guard), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Guard), Member = "OnExecute")]
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

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(Guard), Member = "AgentGuards")]
	[Calls(Type = typeof(Guard), Member = "AgentGuards")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Guard), Member = "SetGuards")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Guard), Member = "AgentGuards")]
	[Calls(Type = typeof(Guard), Member = "AgentGuards")]
	[CalledBy(Type = typeof(Guard), Member = "OnGraphStarted")]
	[CalledBy(Type = typeof(Guard), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 15)]
	private void SetGuards(Component guardAgent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	public Guard()
	{
	}
}
