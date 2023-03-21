using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class ActionNode : DTNode, ITaskAssignable<ActionTask>, ITaskAssignable
{
	private sealed class _003CUpdateAction_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActionNode _003C_003E4__this;

		public Component actionAgent;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 28)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CUpdateAction_003Ed__10(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Graph), Member = "Stop")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(DialogueTree), Member = "Continue")]
		[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
		[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private ActionTask _action;

	public ActionTask action
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public Task task
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public override bool requireActorSelection
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(Node), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[IteratorStateMachine(typeof(_003CUpdateAction_003Ed__10))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator UpdateAction(Component actionAgent)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	private void OnActionEnd(bool success)
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "PauseAction")]
	public override void OnGraphPaused()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	public ActionNode()
	{
	}
}
