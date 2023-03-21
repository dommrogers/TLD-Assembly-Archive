using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourUpdatePlacementDecalReveal : PlayableBehaviour
{
	public bool m_IsErasing;

	public Vector2 m_ValueRange;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayableBehaviourUpdatePlacementDecalReveal()
	{
	}
}
