using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion.Services;
using Parlay;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class ParlayChooseResponseNode : DTNode
{
	[Serializable]
	public class Choice
	{
		public bool isUnfolded;

		public PlayerResponseType responseType;

		public Statement statement;

		public ConditionTask condition;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public Choice()
		{
		}

		[CallerCount(Count = 79)]
		[DeduplicatedMethod]
		public Choice(Statement statement)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Choice, ConditionTask> _003C_003E9__1_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal ConditionTask _003CGetSubTasks_003Eb__1_0(Choice c)
		{
			return null;
		}
	}

	private sealed class _003CCountDown_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ParlayChooseResponseNode _003C_003E4__this;

		private float _003Ctimer_003E5__2;

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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		public _003CCountDown_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
		[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(ParlayChooseResponseNode), Member = "OnOptionSelected")]
		[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
		[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
		[Calls(Type = typeof(Time), Member = "get_deltaTime")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public ParlayChooseResponseNode _003C_003E4__this;

		public int index;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Calls(Type = typeof(DialogueTree), Member = "Continue")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal void _003COnOptionSelected_003Eb__0()
		{
		}
	}

	public bool timedBasedOnNPCState;

	public float availableTime;

	public bool saySelection;

	public List<Choice> availableChoices;

	private bool isWaitingChoice;

	private IBlackboard blackboard;

	public override int maxOutConnections
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Statement), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public override void OnChildConnected(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public override void OnChildDisconnected(int index)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(DialogueTree), Member = "RequestMultipleChoices")]
	[Calls(Type = typeof(MultipleChoiceRequestInfo), Member = ".ctor")]
	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(Statement), Member = "BlackboardReplace")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__13))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator CountDown()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(_003CCountDown_003Ed__13), Member = "MoveNext")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Statement), Member = "BlackboardReplace")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	private void OnOptionSelected(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public ParlayChooseResponseNode()
	{
	}
}
