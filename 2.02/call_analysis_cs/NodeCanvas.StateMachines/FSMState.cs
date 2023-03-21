using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Services;
using UnityEngine;

namespace NodeCanvas.StateMachines;

public abstract class FSMState : Node, IState
{
	public enum TransitionEvaluationMode
	{
		CheckContinuously,
		CheckAfterStateFinished,
		CheckManually
	}

	private TransitionEvaluationMode _transitionEvaluation;

	private float _elapsedTime;

	private bool _hasInit;

	public override bool allowAsPrime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public override int maxInConnections
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	public override int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public sealed override Type outConnectionType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	public sealed override Alignment2x2 commentsAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Alignment2x2);
		}
	}

	public sealed override Alignment2x2 iconAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Alignment2x2);
		}
	}

	public TransitionEvaluationMode transitionEvaluation
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(TransitionEvaluationMode);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float elapsedTime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public FSM FSM
	{
		[CalledBy(Type = typeof(AnyState), Member = "Update")]
		[CalledBy(Type = typeof(AnyState), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(FSMState), Member = "CheckTransitions")]
		[CalledBy(Type = typeof(AnyState), Member = "Update")]
		[CalledBy(Type = typeof(MissionServicesManager), Member = "GetOwner")]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(State_InvokeGraphBase), Member = "SetCompletionFlag")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public FSMConnection[] GetTransitions()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Finish()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Finish(bool inSuccess)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public override void OnGraphStarted()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public override void OnGraphStoped()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnGraphPaused()
	{
	}

	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[Calls(Type = typeof(Node), Member = "IsChildOf")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override bool CanConnectFromSource(Node sourceNode)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "IsParentOf")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	protected override bool CanConnectToTarget(Node targetNode)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Task), Member = "Set")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	protected sealed override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FSMState), Member = "CheckTransitions")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(FSMState), Member = "get_FSM")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphUpdate")]
	[CalledBy(Type = typeof(FSMState), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	public bool CheckTransitions()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	protected sealed override void OnReset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnInit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnEnter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnExit()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected virtual void OnPause()
	{
	}

	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected FSMState()
	{
	}
}
