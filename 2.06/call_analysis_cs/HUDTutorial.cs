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
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "OnTweenComplete")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Disable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 2)]
	public void Enqueue(Panel_TutorialPopup.TutorialPopupRequest request)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void HideDisplay()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDTutorial), Member = "Dequeue")]
	public void ManualUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void RestoreDisplay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool WantsUpdates()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "OnTweenComplete")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Enqueue")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	private void Dequeue()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDTutorial), Member = "Disable")]
	private void OnTweenComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public HUDTutorial()
	{
	}
}
