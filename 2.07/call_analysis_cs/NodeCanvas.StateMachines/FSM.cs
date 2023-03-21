using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.StateMachines;

public class FSM : Graph
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Node, bool> _003C_003E9__48_0;

		public static Func<Node, string> _003C_003E9__48_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetStateNames_003Eb__48_0(Node n)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal string _003CGetStateNames_003Eb__48_1(Node n)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public string name;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass49_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		internal bool _003CGetStateWithName_003Eb__0(Node n)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public MethodInfo enterMethod;

		public MonoBehaviour mono;

		public MethodInfo stayMethod;

		public MethodInfo exitMethod;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass50_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CGatherDelegates_003Eb__0(IState m)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal void _003CGatherDelegates_003Eb__1(IState m)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CGatherDelegates_003Eb__2(IState m)
		{
		}
	}

	private bool hasInitialized;

	private List<IUpdatable> updatableNodes;

	private List<AnyState> anyStates;

	private List<ConcurrentState> concurentStates;

	private List<ConcurrentSuperState> concurentSuperStates;

	private FSMState _003CcurrentState_003Ek__BackingField;

	private FSMState _003CpreviousState_003Ek__BackingField;

	public FSMState currentState
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	public FSMState previousState
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		private set
		{
		}
	}

	public string currentStateName
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public string previousStateName
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public override Type baseNodeType
	{
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallerCount(Count = 0)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
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
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public event Action<IState> onStateEnter
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
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

	public event Action<IState> onStateUpdate
	{
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public event Action<IState> onStateExit
	{
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 2)]
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

	public event Action<IState> onStateTransition
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(FSM), Member = "GatherDelegates")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	protected override void OnGraphStarted()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	protected override void OnGraphUnpaused()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(FSMState), Member = "CheckTransitions")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	protected override void OnGraphUpdate()
	{
	}

	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnGraphStoped()
	{
	}

	[CallerCount(Count = 0)]
	protected override void OnGraphPaused()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AnyState), Member = "Update")]
	[CalledBy(Type = typeof(FSMState), Member = "CheckTransitions")]
	[CalledBy(Type = typeof(FSMConnection), Member = "PerformTransition")]
	[CalledBy(Type = typeof(FSM), Member = "TriggerState")]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphUnpaused")]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphUnpaused")]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphStarted")]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphStarted")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(NCUtils), Member = "EnterStateByTag")]
	public bool EnterState(FSMState newState)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(FSMOwner), Member = "TriggerState")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public FSMState TriggerState(string stateName)
	{
		return null;
	}

	[CalledBy(Type = typeof(FSMOwner), Member = "GetStateNames")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public string[] GetStateNames()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public FSMState GetStateWithName(string name)
	{
		return null;
	}

	[Calls(Type = typeof(FSM), Member = "add_onStateUpdate")]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphStarted")]
	[Calls(Type = typeof(FSM), Member = "add_onStateExit")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(FSM), Member = "add_onStateUpdate")]
	[Calls(Type = typeof(FSM), Member = "add_onStateEnter")]
	[Calls(Type = typeof(FSM), Member = "add_onStateExit")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FSM), Member = "add_onStateEnter")]
	private void GatherDelegates()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = ".ctor")]
	public FSM()
	{
	}
}
