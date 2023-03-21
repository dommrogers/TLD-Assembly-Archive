using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class Filter : BTDecorator
{
	public enum FilterMode
	{
		LimitNumberOfTimes,
		CoolDown
	}

	public enum Policy
	{
		SuccessOrFailure,
		SuccessOnly,
		FailureOnly
	}

	private sealed class _003CCooldown_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Filter _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCooldown_003Ed__11(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public FilterMode filterMode;

	public BBParameter<int> maxCount;

	public Policy policy;

	public BBParameter<float> coolDownTime;

	public bool inactiveWhenLimited;

	private int executedCount;

	private float currentTime;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override void OnGraphStarted()
	{
	}

	[Calls(Type = typeof(Filter), Member = "Cooldown")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Node), Member = "StartCoroutine")]
	[Calls(Type = typeof(Connection), Member = "Execute")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(Connection), Member = "Execute")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator Cooldown()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public Filter()
	{
	}
}
