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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass49_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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

		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CGatherDelegates_003Eb__1(IState m)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
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
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public event Action<IState> onStateEnter
	{
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	public event Action<IState> onStateUpdate
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 2)]
		remove
		{
		}
	}

	public event Action<IState> onStateExit
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<IState> onStateTransition
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 2)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	protected override void OnGraphStarted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnGraphUnpaused()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(FSMState), Member = "CheckTransitions")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
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

	[CalledBy(Type = typeof(FSM), Member = "TriggerState")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AnyState), Member = "Update")]
	[CalledBy(Type = typeof(FSMState), Member = "CheckTransitions")]
	[CalledBy(Type = typeof(FSMConnection), Member = "PerformTransition")]
	[CalledBy(Type = typeof(NCUtils), Member = "EnterStateByTag")]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphUnpaused")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public bool EnterState(FSMState newState)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(FSMOwner), Member = "TriggerState")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(FSM), Member = "GetStateWithName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public FSMState TriggerState(string stateName)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(FSMOwner), Member = "GetStateNames")]
	[CallsUnknownMethods(Count = 14)]
	public string[] GetStateNames()
	{
		return null;
	}

	[CalledBy(Type = typeof(FSM), Member = "TriggerState")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public FSMState GetStateWithName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void GatherDelegates()
	{
	}

	[Calls(Type = typeof(Graph), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public FSM()
	{
	}
}
