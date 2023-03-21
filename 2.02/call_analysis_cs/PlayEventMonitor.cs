using System;
using System.Collections.Generic;
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void ResetRemainingEventsForInstigator(StateMachineBehaviour instigator)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayEventMonitor), Member = "ClearPlayOnAnimator")]
	[Calls(Type = typeof(PlayEventInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void OnPlay(string name, int stateId, Animator animator, StateMachineBehaviour instigator)
	{
	}

	[CalledBy(Type = typeof(CinematicAssets), Member = "SynchronizePropAnimation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LateSynchronizeAnimators")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "LateSynchronizeAnimators")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "SynchronizePropAnimation")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsNPC")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public bool TryGetPlayingStateId(Animator animator, out int statedId)
	{
		statedId = default(int);
		return false;
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "EventStop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void OnStop(string name, int hash, Animator animator)
	{
	}

	[CalledBy(Type = typeof(PlayEventMonitor), Member = "OnPlay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void ClearPlayOnAnimator(Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public PlayEventMonitor()
	{
	}
}
