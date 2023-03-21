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

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(PlayEventMonitor), Member = "OnPlay")]
		public PlayEventInfo(string stateName, int state, Animator animator, StateMachineBehaviour instigator)
		{
		}
	}

	private List<PlayEventInfo> m_PlayEventInfoList;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public void ResetRemainingEventsForInstigator(StateMachineBehaviour instigator)
	{
	}

	[Calls(Type = typeof(PlayEventInfo), Member = ".ctor")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "ClearPlayOnAnimator")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlay")]
	public void OnPlay(string name, int stateId, Animator animator, StateMachineBehaviour instigator)
	{
	}

	[CalledBy(Type = typeof(NPC_Animation), Member = "SynchronizePropAnimation")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "LateSynchronizeAnimators")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LateSynchronizeAnimators")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "SynchronizePropAnimation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsNPC")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	[CallerCount(Count = 6)]
	public bool TryGetPlayingStateId(Animator animator, out int statedId)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref statedId) = null;
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventStop")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	public void OnStop(string name, int hash, Animator animator)
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayEventMonitor), Member = "OnPlay")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ClearPlayOnAnimator(Animator animator)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public PlayEventMonitor()
	{
	}
}
