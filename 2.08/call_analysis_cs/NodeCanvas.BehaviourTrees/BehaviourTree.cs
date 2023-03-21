using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class BehaviourTree : Graph
{
	[Serializable]
	private struct DerivedSerializationData
	{
		public bool repeat;

		public float updateInterval;
	}

	public bool repeat;

	public float updateInterval;

	private float intervalCounter;

	private Status _rootStatus;

	public Status rootStatus
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Status);
		}
		[CalledBy(Type = typeof(BehaviourTree), Member = "Tick")]
		[CalledBy(Type = typeof(BehaviourTree), Member = "OnGraphUpdate")]
		[CalledBy(Type = typeof(BehaviourTree), Member = "OnGraphStarted")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		private set
		{
		}
	}

	public override Type baseNodeType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	public override bool requiresAgent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public override bool requiresPrimeNode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public override bool isTree
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public override bool useLocalBlackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	public sealed override bool canAcceptVariableDrops
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	public static event Action<BehaviourTree, Status> onRootStatusChanged
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	public override object OnDerivedDataSerialization()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void OnDerivedDataDeserialization(object data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(BehaviourTree), Member = "set_rootStatus")]
	protected override void OnGraphStarted()
	{
	}

	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(BehaviourTree), Member = "set_rootStatus")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[CallsDeduplicatedMethods(Count = 3)]
	protected override void OnGraphUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(BehaviourTree), Member = "set_rootStatus")]
	[CallsUnknownMethods(Count = 1)]
	private Status Tick(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = ".ctor")]
	public BehaviourTree()
	{
	}
}
