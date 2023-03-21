using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_TutorialPopup : Panel_AutoReferenced
{
	[Serializable]
	public class TutorialPopupRequest
	{
		public string m_DebugPopupName;

		public string m_MessageLocID;

		public string m_TitleLocID;

		public string m_ShortLocID;

		public string m_SummaryLocID;

		public KnowledgeCateogry m_KnowledgeCategory;

		public GameObject m_BackgroundPrefab;

		[CallerCount(Count = 0)]
		public TutorialPopupRequest()
		{
		}
	}

	public ButtonLegendContainer m_ButtonLegendContainer;

	public UILabel m_TitleLabel;

	public UILabel m_MessageLabel;

	public UILabel m_SummaryLabel;

	public GameObject[] m_MouseButtons;

	public GameObject m_PanelElements;

	public GameObject m_BackgroundContainer;

	public bool m_UseHUDPopup;

	public List<TutorialPopupRequest> m_TutorialPopups;

	private PanelReference<Panel_FireStart> m_FireStart;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Subtitles> m_Subtitles;

	private List<TutorialPopupRequest> m_TutorialPopupRequests;

	private GameObject m_BackgroundPane;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowPanelAndPause")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "UpdateButtons")]
	private void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override bool IsEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	public void ShowPanelAndPause()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	public void ClearRequests()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool CanShowTutorialPopup()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void RemoveCurrentTutorialPopup()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShowNextTutorialPopup()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 0)]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowNextTutorialPopup")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "OnCancel")]
	[Calls(Type = typeof(Knowledge), Member = "GetLocalizedKnowledgeCategoryName")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void ShowCurrentTutorialPopup()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void QueueTutorialPopupRequest(TutorialPopupRequest request)
	{
	}

	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "OnCancel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowNextTutorialPopup")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "RemoveCurrentTutorialPopup")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	private TutorialPopupRequest GetCurrentConfirmationRequest()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[Calls(Type = typeof(Utils), Member = "GetTitleString")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	private void ShowTutorialPopupRequest(TutorialPopupRequest tutorialPopupRequest)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Action_TutorialPopup), Member = "OnExecute")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void ShowTutorialPopupRequest(string name)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateButtons()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_TutorialPopup()
	{
	}
}
