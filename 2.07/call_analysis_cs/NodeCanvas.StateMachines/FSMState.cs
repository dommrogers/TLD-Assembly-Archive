using System;
using System.Linq;
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
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		get
		{
			return default(int);
		}
	}

	public override int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		get
		{
			return default(int);
		}
	}

	public sealed override Type outConnectionType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	public sealed override Alignment2x2 commentsAlignment
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(MissionServicesManager), Member = "GetOwner")]
		[CalledBy(Type = typeof(State_InvokeGraphBase), Member = "SetCompletionFlag")]
		[CalledBy(Type = typeof(FSMState), Member = "CheckTransitions")]
		[CalledBy(Type = typeof(AnyState), Member = "Update")]
		[CalledBy(Type = typeof(AnyState), Member = "Update")]
		[CalledBy(Type = typeof(AnyState), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 6)]
	public override void OnGraphStarted()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public override void OnGraphStoped()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnGraphPaused()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 2)]
	protected override bool CanConnectFromSource(Node sourceNode)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected override bool CanConnectToTarget(Node targetNode)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Task), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected sealed override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FSMState), Member = "CheckTransitions")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(FSMState), Member = "Update")]
	[CalledBy(Type = typeof(FSM), Member = "OnGraphUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FSMState), Member = "get_FSM")]
	public bool CheckTransitions()
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	protected sealed override void OnReset()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected virtual void OnInit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnEnter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnExit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
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
