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

	[CalledBy(Type = typeof(Guard), Member = "SetGuards")]
	[CalledBy(Type = typeof(Guard), Member = "SetGuards")]
	[CalledBy(Type = typeof(Guard), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
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

	[Calls(Type = typeof(Guard), Member = "AgentGuards")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Guard), Member = "AgentGuards")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guard), Member = "SetGuards")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Guard), Member = "OnExecute")]
	[CalledBy(Type = typeof(Guard), Member = "OnGraphStarted")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Guard), Member = "AgentGuards")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Guard), Member = "AgentGuards")]
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
