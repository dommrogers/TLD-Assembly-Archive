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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Guard), Member = "SetGuards")]
	[CalledBy(Type = typeof(Guard), Member = "OnExecute")]
	[CalledBy(Type = typeof(Guard), Member = "SetGuards")]
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
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Guard), Member = "AgentGuards")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(Guard), Member = "SetGuards")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Guard), Member = "OnExecute")]
	[Calls(Type = typeof(Guard), Member = "AgentGuards")]
	[CalledBy(Type = typeof(Guard), Member = "OnGraphStarted")]
	[CallsDeduplicatedMethods(Count = 7)]
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
