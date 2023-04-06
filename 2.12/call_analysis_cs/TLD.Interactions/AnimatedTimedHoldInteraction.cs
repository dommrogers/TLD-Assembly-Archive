using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;

namespace TLD.Interactions;

public class AnimatedTimedHoldInteraction : TimedHoldInteraction
{
	[Serializable]
	private class DirectionalAnimationInfo
	{
		public DirectionalInfluence m_DirectionalInfluence;

		public TimelinePlayback.TimelineInfo m_TimelineInfo;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public DirectionalAnimationInfo()
		{
		}
	}

	private TimelinePlayback m_TimelinePlayback;

	private TimelinePlayback.TimelineInfo m_TimelineInfo;

	private bool m_EnableDirectionalAnimations;

	private bool m_UseDefaultIfNoDirectional;

	private DirectionalAnimationInfo[] m_DirectionalInfo;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DirectionalInfluence), Member = "GetNormalizedInfluenceFromPosition")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	public override bool PerformInteraction()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnAnimatedInteractionBegin()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnAnimatedInteractionEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AnimatedTimedHoldInteraction()
	{
	}
}
