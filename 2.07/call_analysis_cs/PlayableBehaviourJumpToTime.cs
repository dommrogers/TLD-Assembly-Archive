using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourJumpToTime : PlayableBehaviour
{
	public bool m_CanSkip;

	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetNewTime")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCurrentTimelineTime")]
	[CallsUnknownMethods(Count = 5)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PlayableBehaviourJumpToTime()
	{
	}
}
