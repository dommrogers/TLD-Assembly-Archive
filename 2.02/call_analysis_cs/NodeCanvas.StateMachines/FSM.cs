using System;
using System.Collections.Generic;
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
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetStateNames_003Eb__48_0(Node n)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal string _003CGetStateNames_003Eb__48_1(Node n)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public string name;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass49_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
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
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass50_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CGatherDelegates_003Eb__0(IState m)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CGatherDelegates_003Eb__1(IState m)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 1)]
		private set
		{
		}
	}

	public string currentStateName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string previousStateName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public override Type baseNodeType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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

	public event Action<IState> onStateEnter
	{
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<IState> onStateUpdate
	{
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	public event Action<IState> onStateExit
	{
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event Action<IState> onStateTransition
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected override void OnGraphStarted()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnGraphUnpaused()
	{
	}

	[Calls(Type = typeof(FSMState), Member = "CheckTransitions")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	protected override void OnGraphUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnGraphStoped()
	{
	}

	[CallerCount(Count = 0)]
	protected override void OnGraphPaused()
	{
	}

	[CalledBy(Type = typeof(FSMConnection), Member = "PerformTransition")]
	[CalledBy(Type = typeof(FSMState), Member = "CheckTransitions")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FSM), Member = "TriggerState")]
	[CalledBy(Type = typeof(AnyState), Member = "Update")]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphUnpaused")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(NCUtils), Member = "EnterStateByTag")]
	public bool EnterState(FSMState newState)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(FSMOwner), Member = "TriggerState")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(FSM), Member = "GetStateWithName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public FSMState TriggerState(string stateName)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(FSMOwner), Member = "GetStateNames")]
	[CallsUnknownMethods(Count = 14)]
	public string[] GetStateNames()
	{
		return null;
	}

	[CalledBy(Type = typeof(FSM), Member = "TriggerState")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public FSMState GetStateWithName(string name)
	{
		return null;
	}

	[Calls(Type = typeof(FSM), Member = "add_onStateUpdate")]
	[Calls(Type = typeof(FSM), Member = "add_onStateUpdate")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(FSM), Member = "add_onStateExit")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(FSM), Member = "add_onStateExit")]
	[Calls(Type = typeof(FSM), Member = "add_onStateEnter")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FSM), Member = "add_onStateEnter")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	private void GatherDelegates()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = ".ctor")]
	public FSM()
	{
	}
}
