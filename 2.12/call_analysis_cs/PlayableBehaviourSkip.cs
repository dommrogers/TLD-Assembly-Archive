using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class PlayableBehaviourSkip : PlayableBehaviour
{
	private struct SkipInfo
	{
		public float m_SkipTime;

		public TimelineClip m_Clip;

		public bool m_HasFoundValue;
	}

	public List<TimelineClip> m_SkipableClips;

	public bool m_CanSkip;

	public static bool s_ForceSkipEnabled;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCurrentTimelineTime")]
	[Calls(Type = typeof(PlayableBehaviourSkip), Member = "GetNextEndOrStartTime")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetNewTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourSkip), Member = "GetNextEndOrStartTime")]
	private float GetNextSkipTime(float currentTimeSeconds)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "GetNextSkipTime")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PlayableBehaviourSkip), Member = "CanOverrideValue")]
	[CallsUnknownMethods(Count = 3)]
	public float GetNextEndOrStartTime(float currentTimeSeconds)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "GetNextEndOrStartTime")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool CanOverrideValue(TimelineClip clip, SkipInfo skipInfo, float time)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public PlayableBehaviourSkip()
	{
	}
}
