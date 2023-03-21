using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourTitleCards : PlayableBehaviour
{
	private Panel_HUD m_HUD;

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayableBehaviourTitleCards), Member = "OnBehaviourPause")]
	[CalledBy(Type = typeof(PlayableBehaviourTitleCards), Member = "OnBehaviourPlay")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool HasHUD()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PlayableBehaviourTitleCards), Member = "HasHUD")]
	[CallsUnknownMethods(Count = 4)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Calls(Type = typeof(PlayableBehaviourTitleCards), Member = "HasHUD")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PlayableBehaviourTitleCards()
	{
	}
}
