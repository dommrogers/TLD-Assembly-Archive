using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.BehaviourTrees;

public abstract class BTDecorator : BTNode
{
	public sealed override int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public sealed override Alignment2x2 commentsAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Alignment2x2);
		}
	}

	protected Connection decoratedConnection
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallerCount(Count = 39)]
		get
		{
			return null;
		}
	}

	protected Node decoratedNode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	protected BTDecorator()
	{
	}
}
