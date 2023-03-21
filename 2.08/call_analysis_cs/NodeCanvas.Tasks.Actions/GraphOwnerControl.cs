using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

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
			[CallerCount(Count = 28)]
			[DebuggerHidden]
			[DeduplicatedMethod]
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

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CYieldDo_003Ed__6(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(GraphOwnerControl), Member = "Do")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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

	public Control control;

	public bool waitActionFinish;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[IteratorStateMachine(typeof(_003CYieldDo_003Ed__6))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator YieldDo()
	{
		return null;
	}

	[Calls(Type = typeof(GraphOwner), Member = "PauseBehaviour")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(_003CYieldDo_003Ed__6), Member = "MoveNext")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	private void Do()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	public GraphOwnerControl()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
