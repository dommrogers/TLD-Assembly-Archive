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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 231)]
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
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			[DebuggerHidden]
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

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
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
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateStruggle")]
		[CalledBy(Type = typeof(Action_LerpToSyncBone), Member = "MaybeBlendToSyncBone")]
		[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
		[CalledBy(Type = typeof(Action_FaceTarget), Member = "GetTurnSpeed")]
		[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
		[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
		[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
		[CallerCount(Count = 7)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool isPaused
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

	[CalledBy(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
	[CallsUnknownMethods(Count = 6)]
	[IteratorStateMachine(typeof(_003CActionUpdater_003Ed__20))]
	[CallerCount(Count = 2)]
	private IEnumerator ActionUpdater(Component agent, IBlackboard blackboard, Action<bool> callback)
	{
		return null;
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Task), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	public Status ExecuteAction(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	public void EndAction()
	{
	}

	[CallAnalysisFailed]
	[DeduplicatedMethod]
	[CallerCount(Count = 22)]
	public void EndAction(bool success)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 376)]
	public void EndAction(bool? success)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnGraphPaused")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnPause")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnPause")]
	[CalledBy(Type = typeof(ActionState), Member = "OnPause")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnPause")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnPause")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnPause")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnPause")]
	[CalledBy(Type = typeof(ActionList), Member = "OnPause")]
	[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ActionNode), Member = "OnGraphPaused")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnPause")]
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
