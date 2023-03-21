using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourTitleCards : PlayableBehaviour
{
	private Panel_HUD m_HUD;

	[CalledBy(Type = typeof(PlayableBehaviourTitleCards), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourTitleCards), Member = "OnBehaviourPause")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private bool HasHUD()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourTitleCards), Member = "HasHUD")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
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
