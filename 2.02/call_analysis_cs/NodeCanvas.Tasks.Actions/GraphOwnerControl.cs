using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class GraphOwnerControl : ActionTask<GraphOwner>
{
	public enum Control
	{
		StartBehaviour,
		StopBehaviour,
		PauseBehaviour
	}

	private sealed class _003CYieldDo_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GraphOwnerControl _003C_003E4__this;

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
		public _003CYieldDo_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphOwnerControl), Member = "Do")]
		[CallsUnknownMethods(Count = 1)]
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

	public Control control;

	public bool waitActionFinish;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Task), Member = "get_agentInfo")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(GraphOwnerControl), Member = "Do")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Task), Member = "get_ownerAgent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwnerControl), Member = "YieldDo")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "OnExecute")]
	private IEnumerator YieldDo()
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CYieldDo_003Ed__6), Member = "MoveNext")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GraphOwner), Member = "PauseBehaviour")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	private void Do()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GraphOwnerControl()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
