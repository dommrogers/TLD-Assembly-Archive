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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Alignment2x2);
		}
	}

	public sealed override Alignment2x2 iconAlignment
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CalledBy(Type = typeof(State_InvokeGraphBase), Member = "SetCompletionFlag")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(AnyState), Member = "Update")]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(FSMState), Member = "CheckTransitions")]
		[CalledBy(Type = typeof(MissionServicesManager), Member = "GetOwner")]
		[CalledBy(Type = typeof(AnyState), Member = "Update")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 10)]
	public FSMConnection[] GetTransitions()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public override void OnGraphStoped()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 2)]
	protected override bool CanConnectToTarget(Node targetNode)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Task), Member = "Set")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	protected sealed override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Calls(Type = typeof(FSMState), Member = "CheckTransitions")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(FSM), Member = "OnGraphUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(FSMState), Member = "Update")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(FSMState), Member = "get_FSM")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[CallerCount(Count = 2)]
	public bool CheckTransitions()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected virtual void OnPause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	protected FSMState()
	{
	}
}
