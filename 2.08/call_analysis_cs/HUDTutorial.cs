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

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "OnTweenComplete")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Array), Member = "Clear")]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void HideDisplay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDTutorial), Member = "Dequeue")]
	public void ManualUpdate()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "OnTweenComplete")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Enqueue")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
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
	[CallsUnknownMethods(Count = 1)]
	public HUDTutorial()
	{
	}
}
