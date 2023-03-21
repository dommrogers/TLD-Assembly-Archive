using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourJumpToTime : PlayableBehaviour
{
	public bool m_CanSkip;

	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetNewTime")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCurrentTimelineTime")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public PlayableBehaviourJumpToTime()
	{
	}
}
