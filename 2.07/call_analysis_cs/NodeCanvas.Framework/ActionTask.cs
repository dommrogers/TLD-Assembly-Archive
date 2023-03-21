using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using NodeCanvas.StateMachines;
using NodeCanvas.Tasks.Actions;
using ParadoxNotion.Services;
using UnityEngine;

namespace NodeCanvas.Framework;

public abstract class ActionTask<T> : ActionTask where T : class
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
	protected ActionTask()
	{
	}
}
public abstract class ActionTask : Task
{
	private sealed class _003CActionUpdater_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActionTask _003C_003E4__this;

		public Component agent;

		public IBlackboard blackboard;

		public Action<bool> callback;

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
		public _003CActionUpdater_003Ed__20(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[NonSerialized]
	private Status status;

	[NonSerialized]
	private float startedTime;

	[NonSerialized]
	private float pausedTime;

	[NonSerialized]
	private bool latch;

	[NonSerialized]
	private bool _isPaused;

	[NonSerialized]
	protected bool _ignoreSaveCheck;

	public float elapsedTime
	{
		[CallerCount(Count = 25)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public float deltaTime
	{
		[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
		[CalledBy(Type = typeof(Action_FaceTarget), Member = "GetTurnSpeed")]
		[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
		[CalledBy(Type = typeof(Action_LerpToSyncBone), Member = "MaybeBlendToSyncBone")]
		[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateStruggle")]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0f;
		}
	}

	public bool isRunning
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool isResting
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool ignoreSaveCheck
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool isPaused
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(ActionTask), Member = "ActionUpdater")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	public void ExecuteAction(Component agent, IBlackboard blackboard, Action<bool> callback)
	{
	}

	[IteratorStateMachine(typeof(_003CActionUpdater_003Ed__20))]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
	[CalledBy(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator ActionUpdater(Component agent, IBlackboard blackboard, Action<bool> callback)
	{
		return null;
	}

	[CalledBy(Type = typeof(ActionListPlayer), Member = "ExecuteAction")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "ExecuteAction")]
	[CalledBy(Type = typeof(Monitor), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ActionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ActionList), Member = "OnUpdate")]
	[CalledBy(Type = typeof(_003CActionUpdater_003Ed__20), Member = "MoveNext")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnUpdate")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnEnter")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnUpdate")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnExit")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnUpdate")]
	[CalledBy(Type = typeof(ActionState), Member = "OnUpdate")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnEnter")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "Update")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnUpdate")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnExit")]
	[CalledBy(TypeFullName = "NodeCanvas.DialogueTrees.ActionListNode.<UpdateAction>d__2", Member = "MoveNext")]
	[CalledBy(TypeFullName = "NodeCanvas.DialogueTrees.ActionNode.<UpdateAction>d__10", Member = "MoveNext")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Task), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public Status ExecuteAction(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	public void EndAction()
	{
	}

	[CallerCount(Count = 381)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EndAction(bool success)
	{
	}

	[CalledBy(Type = typeof(Monitor), Member = "OnReset")]
	[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ActionNode), Member = "OnReset")]
	[CalledBy(Type = typeof(ActionList), Member = "OnStop")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnExit")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnExit")]
	[CalledBy(Type = typeof(ActionState), Member = "OnExit")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnExit")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnExit")]
	[CalledBy(Type = typeof(ActionListNode), Member = "OnReset")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnReset")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EndAction(bool? success)
	{
	}

	[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ActionNode), Member = "OnGraphPaused")]
	[CalledBy(Type = typeof(ActionList), Member = "OnPause")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnPause")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnPause")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnPause")]
	[CalledBy(Type = typeof(ActionState), Member = "OnPause")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnPause")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnPause")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnGraphPaused")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void PauseAction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnStop(bool interrupted)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnStop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnPause()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected ActionTask()
	{
	}
}
