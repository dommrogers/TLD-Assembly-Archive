using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework;

public abstract class Connection : IGraphElement
{
	private Node _sourceNode;

	private Node _targetNode;

	private bool _isDisabled;

	[NonSerialized]
	private Status _status;

	public Node sourceNode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 80)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 279)]
		protected set
		{
		}
	}

	public Node targetNode
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 79)]
		protected set
		{
		}
	}

	public bool isActive
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Node), Member = "Reset")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Status status
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return default(Status);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public Graph graph
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Connection()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Connection), Member = "SetSourceNode")]
	[Calls(Type = typeof(Connection), Member = "SetTargetNode")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Graph), Member = "ConnectNodes")]
	[CallsUnknownMethods(Count = 3)]
	public static Connection Create(Node source, Node target, int sourceIndex = -1, int targetIndex = -1)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Connection), Member = "SetTargetNode")]
	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Connection), Member = "SetSourceNode")]
	[CallsUnknownMethods(Count = 7)]
	public Connection Duplicate(Node newSource, Node newTarget)
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void OnCreate(int sourceIndex, int targetIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnValidate(int sourceIndex, int targetIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Connection), Member = "Duplicate")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Connection), Member = "Create")]
	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CallsUnknownMethods(Count = 2)]
	public int SetSourceNode(Node newSource, int index = -1)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Connection), Member = "Duplicate")]
	[CalledBy(Type = typeof(Connection), Member = "Create")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public int SetTargetNode(Node newTarget, int index = -1)
	{
		return default(int);
	}

	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CallerCount(Count = 0)]
	public sealed override string ToString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.WaitUntil), Member = "OnExecute")]
	[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
	[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ProbabilitySelector), Member = "OnExecute")]
	[CalledBy(Type = typeof(Parallel), Member = "OnExecute")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(ConditionalEvaluator), Member = "OnExecute")]
	public Status Execute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CalledBy(Type = typeof(Node), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	public void Reset(bool recursively = true)
	{
	}

	[CallerCount(Count = 0)]
	public void SetActiveNonRecursive(bool value)
	{
	}
}
