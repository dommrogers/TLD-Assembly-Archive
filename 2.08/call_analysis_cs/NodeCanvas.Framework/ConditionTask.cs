using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
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
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(Task), Member = "get_agent")]
		[DeduplicatedMethod]
		[CallerCount(Count = 222)]
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
	private sealed class _003CFlip_003Ed__13 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ConditionTask _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CFlip_003Ed__13(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoManager), Member = "get_current")]
		[Calls(Type = typeof(MonoManager), Member = "StaggeredUpdatedEnabled")]
		[Calls(Type = typeof(MonoManager), Member = "get_current")]
		[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
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
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
	[CallerCount(Count = 23)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool CheckCondition(Component agent, IBlackboard blackboard)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[CallerCount(Count = 61)]
	protected void YieldReturn(bool value)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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
		return default(bool);
	}

	[IteratorStateMachine(typeof(_003CFlip_003Ed__13))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator Flip()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected ConditionTask()
	{
	}
}
