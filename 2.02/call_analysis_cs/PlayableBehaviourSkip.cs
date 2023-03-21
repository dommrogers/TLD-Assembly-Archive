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

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetNewTime")]
	[Calls(Type = typeof(PlayableBehaviourSkip), Member = "GetNextEndOrStartTime")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCurrentTimelineTime")]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourSkip), Member = "GetNextEndOrStartTime")]
	private float GetNextSkipTime(float currentTimeSeconds)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayableBehaviourSkip), Member = "CanOverrideValue")]
	[Calls(Type = typeof(PlayableBehaviourSkip), Member = "CanOverrideValue")]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "GetNextSkipTime")]
	[CallsUnknownMethods(Count = 4)]
	public float GetNextEndOrStartTime(float currentTimeSeconds)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "GetNextEndOrStartTime")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "GetNextEndOrStartTime")]
	private bool CanOverrideValue(TimelineClip clip, SkipInfo skipInfo, float time)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public PlayableBehaviourSkip()
	{
	}
}
