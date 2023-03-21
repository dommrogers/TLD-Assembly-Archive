using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using ParadoxNotion;
using ParadoxNotion.Serialization;
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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		protected set
		{
		}
	}

	public Node targetNode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
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
			return false;
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

	[CalledBy(Type = typeof(Graph), Member = "ConnectNodes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Connection), Member = "SetSourceNode")]
	[Calls(Type = typeof(Connection), Member = "SetTargetNode")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public static Connection Create(Node source, Node target, int sourceIndex = -1, int targetIndex = -1)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JSONSerializer), Member = "Clone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Connection), Member = "SetSourceNode")]
	[Calls(Type = typeof(Connection), Member = "SetTargetNode")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public Connection Duplicate(Node newSource, Node newTarget)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void OnCreate(int sourceIndex, int targetIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void OnValidate(int sourceIndex, int targetIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Connection), Member = "Create")]
	[CalledBy(Type = typeof(Connection), Member = "Duplicate")]
	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public int SetSourceNode(Node newSource, int index = -1)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Connection), Member = "Create")]
	[CalledBy(Type = typeof(Connection), Member = "Duplicate")]
	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public int SetTargetNode(Node newTarget, int index = -1)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CallsDeduplicatedMethods(Count = 1)]
	public sealed override string ToString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Parallel), Member = "OnExecute")]
	[CalledBy(Type = typeof(ProbabilitySelector), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConditionalEvaluator), Member = "OnExecute")]
	[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
	[CalledBy(Type = typeof(Iterator), Member = "OnExecute")]
	[CalledBy(Type = typeof(WaitUntil), Member = "OnExecute")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Status Execute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CalledBy(Type = typeof(Node), Member = "Reset")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	public void Reset(bool recursively = true)
	{
	}

	[CallerCount(Count = 0)]
	public void SetActiveNonRecursive(bool value)
	{
	}
}
