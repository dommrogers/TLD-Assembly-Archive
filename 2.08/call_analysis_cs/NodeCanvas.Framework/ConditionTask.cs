using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using NodeCanvas.StateMachines;
using ParadoxNotion.Services;
using UnityEngine;

namespace NodeCanvas.Framework;

public abstract class ConditionTask<T> : ConditionTask where T : class
{
	public sealed override Type agentType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	public new T agent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 222)]
		[Calls(Type = typeof(Task), Member = "get_agent")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected ConditionTask()
	{
	}
}
public abstract class ConditionTask : Task
{
	private sealed class _003CFlip_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ConditionTask _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CFlip_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoManager), Member = "get_current")]
		[Calls(Type = typeof(MonoManager), Member = "StaggeredUpdatedEnabled")]
		[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private bool _invert;

	[NonSerialized]
	private int yieldReturn;

	private int yields;

	public bool invert
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Enable(Component agent, IBlackboard bb)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Disable()
	{
	}

	[CalledBy(Type = typeof(BinarySelector), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConditionalEvaluator), Member = "OnExecute")]
	[CalledBy(Type = typeof(Interruptor), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.WaitUntil), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ConditionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConditionList), Member = "OnCheck")]
	[CalledBy(Type = typeof(FSMState), Member = "CheckTransitions")]
	[CalledBy(Type = typeof(AnyState), Member = "Update")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnEnter")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "Update")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(TypeFullName = "NodeCanvas.DialogueTrees.ParlayChooseResponseNode.<CountDown>d__13", Member = "MoveNext")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ConditionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleConditionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ProbabilitySelector), Member = "OnExecute")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(Task), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool CheckCondition(Component agent, IBlackboard blackboard)
	{
		return false;
	}

	[CallerCount(Count = 61)]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	protected void YieldReturn(bool value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual bool OnCheck()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CFlip_003Ed__13))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator Flip()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected ConditionTask()
	{
	}
}
