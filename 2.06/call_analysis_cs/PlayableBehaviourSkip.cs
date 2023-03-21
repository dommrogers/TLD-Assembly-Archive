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

	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetNewTime")]
	[Calls(Type = typeof(PlayableBehaviourSkip), Member = "GetNextEndOrStartTime")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCurrentTimelineTime")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Calls(Type = typeof(PlayableBehaviourSkip), Member = "GetNextEndOrStartTime")]
	[CallerCount(Count = 0)]
	private float GetNextSkipTime(float currentTimeSeconds)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayableBehaviourSkip), Member = "CanOverrideValue")]
	[Calls(Type = typeof(PlayableBehaviourSkip), Member = "CanOverrideValue")]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "GetNextSkipTime")]
	[CallsUnknownMethods(Count = 5)]
	public float GetNextEndOrStartTime(float currentTimeSeconds)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "GetNextEndOrStartTime")]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "GetNextEndOrStartTime")]
	[CallsUnknownMethods(Count = 3)]
	private bool CanOverrideValue(TimelineClip clip, SkipInfo skipInfo, float time)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public PlayableBehaviourSkip()
	{
	}
}
