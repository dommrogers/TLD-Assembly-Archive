using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.BehaviourTrees;

public abstract class BTNode : Node
{
	public sealed override Type outConnectionType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	public override bool allowAsPrime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public override Alignment2x2 commentsAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Alignment2x2);
		}
	}

	public override Alignment2x2 iconAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Alignment2x2);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Graph), Member = "ConnectNodes")]
	[CallsUnknownMethods(Count = 4)]
	public T AddChild<T>(int childIndex) where T : BTNode
	{
		return null;
	}

	[Calls(Type = typeof(Graph), Member = "ConnectNodes")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public T AddChild<T>() where T : BTNode
	{
		return null;
	}

	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected BTNode()
	{
	}
}
