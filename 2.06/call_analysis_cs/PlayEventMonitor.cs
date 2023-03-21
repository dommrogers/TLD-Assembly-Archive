using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayEventMonitor : MonoBehaviour
{
	public struct PlayEventInfo
	{
		public string m_StateName;

		public int m_StateId;

		public Animator m_Animator;

		public StateMachineBehaviour m_Instigator;

		[CalledBy(Type = typeof(PlayEventMonitor), Member = "OnPlay")]
		[CallerCount(Count = 1)]
		public PlayEventInfo(string stateName, int state, Animator animator, StateMachineBehaviour instigator)
		{
		}
	}

	private List<PlayEventInfo> m_PlayEventInfoList;

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 1)]
	public void ResetRemainingEventsForInstigator(StateMachineBehaviour instigator)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayEventMonitor), Member = "ClearPlayOnAnimator")]
	[Calls(Type = typeof(PlayEventInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlay")]
	[CallsUnknownMethods(Count = 2)]
	public void OnPlay(string name, int stateId, Animator animator, StateMachineBehaviour instigator)
	{
	}

	[CalledBy(Type = typeof(NPC_Animation), Member = "SynchronizePropAnimation")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsNPC")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "LateSynchronizeAnimators")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LateSynchronizeAnimators")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "SynchronizePropAnimation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 6)]
	public bool TryGetPlayingStateId(Animator animator, out int statedId)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref statedId) = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventStop")]
	[CallsUnknownMethods(Count = 2)]
	public void OnStop(string name, int hash, Animator animator)
	{
	}

	[CalledBy(Type = typeof(PlayEventMonitor), Member = "OnPlay")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	private void ClearPlayOnAnimator(Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public PlayEventMonitor()
	{
	}
}
