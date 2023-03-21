using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourSetAnimControllerState : PlayableBehaviour
{
	public string m_StateName;

	private GameObject m_TrackGameObject;

	private Animator m_TrackAnimator;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourSetAnimControllerState), Member = "SetAnimControllerState")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourSetAnimControllerState), Member = "OnBehaviourPlay")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void SetAnimControllerState()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayableBehaviourSetAnimControllerState()
	{
	}
}
