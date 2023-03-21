using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using Parlay;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class ParlayChooseResponseNode : DTNode, ISubTasksContainer
{
	[Serializable]
	public class Choice
	{
		public bool isUnfolded;

		public PlayerResponseType responseType;

		public Statement statement;

		public ConditionTask condition;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public Choice()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		public Choice(Statement statement)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Choice, ConditionTask> _003C_003E9__1_0;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCountDown_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
		[Calls(Type = typeof(ParlayChooseResponseNode), Member = "OnOptionSelected")]
		[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 14)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
		[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
		[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
		[Calls(Type = typeof(Time), Member = "get_deltaTime")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
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

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public ParlayChooseResponseNode _003C_003E4__this;

		public int index;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(DialogueTree), Member = "Continue")]
		[CallsUnknownMethods(Count = 1)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Statement), Member = ".ctor")]
	[CallsUnknownMethods(Count = 17)]
	public override void OnChildConnected(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public override void OnChildDisconnected(int index)
	{
	}

	[Calls(Type = typeof(DialogueTree), Member = "RequestMultipleChoices")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MultipleChoiceRequestInfo), Member = ".ctor")]
	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
	[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(Node), Member = "StartCoroutine")]
	[Calls(Type = typeof(ParlayChooseResponseNode), Member = "CountDown")]
	[Calls(Type = typeof(Statement), Member = "BlackboardReplace")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IEnumerator CountDown()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(_003CCountDown_003Ed__13), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Statement), Member = "BlackboardReplace")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Variable), Member = "OnValueChanged")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	private void OnOptionSelected(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public ParlayChooseResponseNode()
	{
	}
}
