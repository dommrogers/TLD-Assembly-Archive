using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourSetAnimControllerState : PlayableBehaviour
{
	public string m_StateName;

	private GameObject m_TrackGameObject;

	private Animator m_TrackAnimator;

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Calls(Type = typeof(PlayableBehaviourSetAnimControllerState), Member = "SetAnimControllerState")]
	[CallerCount(Count = 0)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CalledBy(Type = typeof(PlayableBehaviourSetAnimControllerState), Member = "OnBehaviourPlay")]
	[CallsUnknownMethods(Count = 4)]
	private void SetAnimControllerState()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayableBehaviourSetAnimControllerState()
	{
	}
}
