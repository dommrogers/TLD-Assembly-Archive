using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourWaitUserInput : PlayableBehaviour
{
	public double m_StartTime;

	public LocalizedString m_LocalizationId;

	private bool m_IsWaiting;

	private bool m_HasInteracted;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[CallsUnknownMethods(Count = 10)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayableDirector), Member = "set_time")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetGraph")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetGraph")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[CallsUnknownMethods(Count = 2)]
	private void OnButtonSelected(int choice)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PlayableBehaviourWaitUserInput()
	{
	}
}
