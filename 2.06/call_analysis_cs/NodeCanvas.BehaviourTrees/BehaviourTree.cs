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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Status);
		}
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(BehaviourTree), Member = "OnGraphStarted")]
		[CalledBy(Type = typeof(BehaviourTree), Member = "OnGraphUpdate")]
		[CalledBy(Type = typeof(BehaviourTree), Member = "Tick")]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public sealed override bool canAcceptVariableDrops
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public static event Action<BehaviourTree, Status> onRootStatusChanged
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(BehaviourTree), Member = "set_rootStatus")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnGraphStarted()
	{
	}

	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(BehaviourTree), Member = "set_rootStatus")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Graph), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public BehaviourTree()
	{
	}
}
