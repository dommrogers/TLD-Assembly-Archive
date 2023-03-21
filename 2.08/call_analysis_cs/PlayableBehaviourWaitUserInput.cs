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

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnBehaviourPause")]
	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnButtonSelected")]
	private bool HasHUD()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourWaitUserInput), Member = "HasHUD")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayableBehaviourWaitUserInput), Member = "HasHUD")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[Calls(Type = typeof(PlayableDirector), Member = "set_time")]
	[CallsUnknownMethods(Count = 5)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[Calls(Type = typeof(PlayableBehaviourWaitUserInput), Member = "HasHUD")]
	[CallerCount(Count = 0)]
	private void OnButtonSelected(int choice)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayableBehaviourWaitUserInput()
	{
	}
}
