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
			[CallerCount(Count = 44)]
			[DeduplicatedMethod]
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
			[CallerCount(Count = 44)]
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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
		[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(Graph), Member = "Stop")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(DialogueTree), Member = "Continue")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private ActionTask _action;

	public ActionTask action
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(Node), Member = "StartCoroutine")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(ActionNode), Member = "UpdateAction")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[IteratorStateMachine(typeof(_003CUpdateAction_003Ed__10))]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ActionNode), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator UpdateAction(Component actionAgent)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	private void OnActionEnd(bool success)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "PauseAction")]
	public override void OnGraphPaused()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	public ActionNode()
	{
	}
}
