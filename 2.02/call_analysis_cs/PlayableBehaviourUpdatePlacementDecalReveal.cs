using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourUpdatePlacementDecalReveal : PlayableBehaviour
{
	public bool m_IsErasing;

	public Vector2 m_ValueRange;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDecalReveal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PlayableBehaviourUpdatePlacementDecalReveal()
	{
	}
}
