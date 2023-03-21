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
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
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
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowPanelAndPause")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "UpdateButtons")]
	private void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override bool IsEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void ShowPanelAndPause()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearRequests()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsUnknownMethods(Count = 2)]
	private bool CanShowTutorialPopup()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveCurrentTutorialPopup()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool ShowNextTutorialPopup()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallerCount(Count = 0)]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowNextTutorialPopup")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	[Calls(Type = typeof(Knowledge), Member = "GetLocalizedKnowledgeCategoryName")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	private void ShowCurrentTutorialPopup()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void QueueTutorialPopupRequest(TutorialPopupRequest request)
	{
	}

	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowNextTutorialPopup")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "RemoveCurrentTutorialPopup")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	private TutorialPopupRequest GetCurrentConfirmationRequest()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetTitleString")]
	private void ShowTutorialPopupRequest(TutorialPopupRequest tutorialPopupRequest)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Action_TutorialPopup), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	public void ShowTutorialPopupRequest(string name)
	{
	}

	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
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

	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Panel_TutorialPopup()
	{
	}
}
