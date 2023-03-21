using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Conditions;
using ParadoxNotion.Services;
using UnityEngine;

namespace NodeCanvas.Framework;

public abstract class ConditionTask<T> : ConditionTask where T : class
{
	public sealed override Type agentType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	public new T agent
	{
		[Calls(Type = typeof(Task), Member = "get_agent")]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		[CallerCount(Count = 228)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected ConditionTask()
	{
	}
}
public abstract class ConditionTask : Task
{
	private sealed class _003CFlip_003Ed__13 : IDisposable, IEnumerator<object>, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ConditionTask _003C_003E4__this;

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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
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

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(MonoManager), Member = "get_current")]
		[Calls(Type = typeof(MonoManager), Member = "GetYeldReturnFrameCount")]
		[Calls(Type = typeof(MonoManager), Member = "get_current")]
		[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
		[CallsUnknownMethods(Count = 5)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
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
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "Set")]
	public void Enable(Component agent, IBlackboard bb)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Disable()
	{
	}

	[Calls(Type = typeof(Task), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 23)]
	public bool CheckCondition(Component agent, IBlackboard blackboard)
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(Condition_HasPlacedItem), Member = "OnCustomEvent")]
	[CalledBy(Type = typeof(Condition_ItemCookingState), Member = "OnCustomEvent")]
	[CalledBy(Type = typeof(Condition_WaterCookingState), Member = "OnCustomEvent")]
	[CalledBy(Type = typeof(Condition_ItemCookingStateWarning), Member = "OnCustomEvent")]
	[CalledBy(Type = typeof(Condition_WaterCookingStateWarning), Member = "OnCustomEvent")]
	[CalledBy(Type = typeof(Condition_CaughtFish), Member = "OnCustomEvent")]
	protected void YieldReturn(bool value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnEnable()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected virtual void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual bool OnCheck()
	{
		return default(bool);
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 56)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
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
