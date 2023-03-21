using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HUDTutorial : MonoBehaviour
{
	public delegate void OnCompleteDelegate();

	public UILabel m_MessageLabel;

	public UILabel m_InfoLabel;

	public bool m_RestoreDisplay;

	public OnCompleteDelegate m_OnComplete;

	public Panel_TutorialPopup.TutorialPopupRequest m_Current;

	private Queue<Panel_TutorialPopup.TutorialPopupRequest> m_Queue;

	private List<UITweener> m_Tweens;

	private int m_ActiveTweens;

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "OnTweenComplete")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	public void Disable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Enqueue(Panel_TutorialPopup.TutorialPopupRequest request)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void HideDisplay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDTutorial), Member = "Dequeue")]
	public void ManualUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void RestoreDisplay()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool WantsUpdates()
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(HUDTutorial), Member = "Enqueue")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "OnTweenComplete")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	private void Dequeue()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(HUDTutorial), Member = "Disable")]
	private void OnTweenComplete()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HUDTutorial()
	{
	}
}
