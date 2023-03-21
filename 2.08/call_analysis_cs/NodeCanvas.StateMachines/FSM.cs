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

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
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

		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void _003CGatherDelegates_003Eb__0(IState m)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallsUnknownMethods(Count = 1)]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		private set
		{
		}
	}

	public FSMState previousState
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	public event Action<IState> onStateEnter
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

	public event Action<IState> onStateUpdate
	{
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
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

	public event Action<IState> onStateExit
	{
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		remove
		{
		}
	}

	public event Action<IState> onStateTransition
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(FSM), Member = "GatherDelegates")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	protected override void OnGraphStarted()
	{
	}

	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnGraphUnpaused()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(FSMState), Member = "CheckTransitions")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	protected override void OnGraphUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnGraphStoped()
	{
	}

	[CallerCount(Count = 0)]
	protected override void OnGraphPaused()
	{
	}

	[CalledBy(Type = typeof(AnyState), Member = "Update")]
	[CalledBy(Type = typeof(FSMState), Member = "CheckTransitions")]
	[CalledBy(Type = typeof(FSMConnection), Member = "PerformTransition")]
	[CalledBy(Type = typeof(FSM), Member = "TriggerState")]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphUnpaused")]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphUnpaused")]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphStarted")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NCUtils), Member = "EnterStateByTag")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphStarted")]
	public bool EnterState(FSMState newState)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(FSMOwner), Member = "TriggerState")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public FSMState TriggerState(string stateName)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CalledBy(Type = typeof(FSMOwner), Member = "GetStateNames")]
	[CallsUnknownMethods(Count = 8)]
	public string[] GetStateNames()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public FSMState GetStateWithName(string name)
	{
		return null;
	}

	[Calls(Type = typeof(FSM), Member = "add_onStateUpdate")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphStarted")]
	[Calls(Type = typeof(FSM), Member = "add_onStateExit")]
	[Calls(Type = typeof(FSM), Member = "add_onStateExit")]
	[Calls(Type = typeof(FSM), Member = "add_onStateUpdate")]
	[Calls(Type = typeof(FSM), Member = "add_onStateEnter")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(FSM), Member = "add_onStateEnter")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void GatherDelegates()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = ".ctor")]
	public FSM()
	{
	}
}
