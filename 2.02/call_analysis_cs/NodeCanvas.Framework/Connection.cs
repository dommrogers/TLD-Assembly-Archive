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
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		protected set
		{
		}
	}

	public Node targetNode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Node), Member = "Reset")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Status status
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Graph), Member = "ConnectNodes")]
	[Calls(Type = typeof(Connection), Member = "SetTargetNode")]
	[Calls(Type = typeof(Connection), Member = "SetSourceNode")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public static Connection Create(Node source, Node target, int sourceIndex = -1, int targetIndex = -1)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Connection), Member = "SetSourceNode")]
	[Calls(Type = typeof(Connection), Member = "SetTargetNode")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CallsUnknownMethods(Count = 10)]
	public Connection Duplicate(Node newSource, Node newTarget)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void OnCreate(int sourceIndex, int targetIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnValidate(int sourceIndex, int targetIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnDestroy()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Connection), Member = "Create")]
	[CalledBy(Type = typeof(Connection), Member = "Duplicate")]
	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CallsUnknownMethods(Count = 11)]
	public int SetSourceNode(Node newSource, int index = -1)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Connection), Member = "Duplicate")]
	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CalledBy(Type = typeof(Connection), Member = "Create")]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public int SetTargetNode(Node newTarget, int index = -1)
	{
		return default(int);
	}

	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public sealed override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Parallel), Member = "OnExecute")]
	[CalledBy(Type = typeof(ProbabilitySelector), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConditionalEvaluator), Member = "OnExecute")]
	[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
	[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
	[CalledBy(Type = typeof(Iterator), Member = "OnExecute")]
	[CalledBy(Type = typeof(WaitUntil), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	public Status Execute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Node), Member = "Reset")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	public void Reset(bool recursively = true)
	{
	}

	[CallerCount(Count = 0)]
	public void SetActiveNonRecursive(bool value)
	{
	}
}
