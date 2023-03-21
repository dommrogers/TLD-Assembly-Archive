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
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[DebuggerHidden]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
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
			return default(float);
		}
	}

	public float deltaTime
	{
		[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
		[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
		[CalledBy(Type = typeof(Action_FaceTarget), Member = "GetTurnSpeed")]
		[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
		[CalledBy(Type = typeof(Action_LerpToSyncBone), Member = "MaybeBlendToSyncBone")]
		[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateStruggle")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(float);
		}
	}

	public bool isRunning
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool isResting
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool ignoreSaveCheck
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public bool isPaused
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
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
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
	[CalledBy(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator ActionUpdater(Component agent, IBlackboard blackboard, Action<bool> callback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "Set")]
	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CalledBy(Type = typeof(ActionState), Member = "OnExit")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnReset")]
	[CalledBy(Type = typeof(ActionListNode), Member = "OnReset")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnExit")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnExit")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnExit")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnExit")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnExit")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnExit")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CalledBy(Type = typeof(ActionList), Member = "OnStop")]
	[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ActionNode), Member = "OnReset")]
	[CalledBy(Type = typeof(Monitor), Member = "OnReset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnExit")]
	public void EndAction(bool? success)
	{
	}

	[CalledBy(Type = typeof(ActionState), Member = "OnPause")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnGraphPaused")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnPause")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnPause")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnPause")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnPause")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnPause")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnPause")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnPause")]
	[CalledBy(Type = typeof(ActionList), Member = "OnPause")]
	[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ActionNode), Member = "OnGraphPaused")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 11)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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
