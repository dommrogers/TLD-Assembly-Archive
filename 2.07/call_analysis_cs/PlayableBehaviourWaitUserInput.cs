using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourWaitUserInput : PlayableBehaviour
{
	public double m_StartTime;

	public LocalizedString m_LocalizationId;

	private bool m_IsWaiting;

	private bool m_HasInteracted;

	private Panel_HUD m_HUD;

	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnButtonSelected")]
	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnBehaviourPause")]
	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnBehaviourPlay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private bool HasHUD()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourWaitUserInput), Member = "HasHUD")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[CallsUnknownMethods(Count = 2)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayableDirector), Member = "set_time")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourWaitUserInput), Member = "HasHUD")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourWaitUserInput), Member = "HasHUD")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[CallsUnknownMethods(Count = 1)]
	private void OnButtonSelected(int choice)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayableBehaviourWaitUserInput()
	{
	}
}
