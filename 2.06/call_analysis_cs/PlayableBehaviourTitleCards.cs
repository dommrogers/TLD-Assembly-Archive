using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourTitleCards : PlayableBehaviour
{
	private Panel_HUD m_HUD;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(PlayableBehaviourTitleCards), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourTitleCards), Member = "OnBehaviourPause")]
	private bool HasHUD()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayableBehaviourTitleCards), Member = "HasHUD")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourTitleCards), Member = "HasHUD")]
	[CallsUnknownMethods(Count = 2)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayableBehaviourTitleCards()
	{
	}
}
