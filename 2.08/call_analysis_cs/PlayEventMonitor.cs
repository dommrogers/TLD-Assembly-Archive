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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CallsUnknownMethods(Count = 3)]
	public void ResetRemainingEventsForInstigator(StateMachineBehaviour instigator)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayEventInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayEventMonitor), Member = "ClearPlayOnAnimator")]
	public void OnPlay(string name, int stateId, Animator animator, StateMachineBehaviour instigator)
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(CinematicAssets), Member = "SynchronizePropAnimation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LateSynchronizeAnimators")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "LateSynchronizeAnimators")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "SynchronizePropAnimation")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsNPC")]
	[CallsUnknownMethods(Count = 4)]
	public bool TryGetPlayingStateId(Animator animator, out int statedId)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref statedId) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventStop")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	public void OnStop(string name, int hash, Animator animator)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PlayEventMonitor), Member = "OnPlay")]
	[CallsUnknownMethods(Count = 3)]
	private void ClearPlayOnAnimator(Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public PlayEventMonitor()
	{
	}
}
