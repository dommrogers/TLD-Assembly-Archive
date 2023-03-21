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

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "OnTweenComplete")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void HideDisplay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(HUDTutorial), Member = "ManualUpdate")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "OnTweenComplete")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Enqueue")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void Dequeue()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[Calls(Type = typeof(HUDTutorial), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnTweenComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public HUDTutorial()
	{
	}
}
