using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourActivateSpawnedObject : PlayableBehaviour
{
	public TLD_SpawnedAnimationTrack m_SpawnedAnimationTrack;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "Activate")]
	[CallsUnknownMethods(Count = 1)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "Activate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "Activate")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PlayableBehaviourActivateSpawnedObject()
	{
	}
}
