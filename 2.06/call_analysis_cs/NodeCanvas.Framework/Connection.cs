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
		[CallerCount(Count = 98)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 265)]
		protected set
		{
		}
	}

	public Node targetNode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 85)]
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
		[Calls(Type = typeof(Node), Member = "Reset")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Status status
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return default(Status);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Graph), Member = "ConnectNodes")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Connection), Member = "SetTargetNode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Connection), Member = "SetSourceNode")]
	public static Connection Create(Node source, Node target, int sourceIndex = -1, int targetIndex = -1)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Connection), Member = "SetSourceNode")]
	[Calls(Type = typeof(Connection), Member = "SetTargetNode")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
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

	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Connection), Member = "Create")]
	[CalledBy(Type = typeof(Connection), Member = "Duplicate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public int SetSourceNode(Node newSource, int index = -1)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Connection), Member = "Create")]
	[CalledBy(Type = typeof(Connection), Member = "Duplicate")]
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

	[CalledBy(Type = typeof(Iterator), Member = "OnExecute")]
	[CalledBy(Type = typeof(ProbabilitySelector), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.WaitUntil), Member = "OnExecute")]
	[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ConditionalEvaluator), Member = "OnExecute")]
	[CalledBy(Type = typeof(Parallel), Member = "OnExecute")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
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
