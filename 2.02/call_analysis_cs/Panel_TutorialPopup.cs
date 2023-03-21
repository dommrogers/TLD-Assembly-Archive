using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class Panel_TutorialPopup : Panel_Base
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

	private List<TutorialPopupRequest> m_TutorialPopupRequests;

	private GameObject m_BackgroundPane;

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_TutorialPopup), Member = "OnCancel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowPanelAndPause")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsUnknownMethods(Count = 12)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_TutorialPopup), Member = "UpdateButtons")]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 7)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool IsEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	public void ShowPanelAndPause()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 3)]
	private bool CanShowTutorialPopup()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	private void RemoveCurrentTutorialPopup()
	{
	}

	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool ShowNextTutorialPopup()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowNextTutorialPopup")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Knowledge), Member = "GetLocalizedKnowledgeCategoryName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void ShowCurrentTutorialPopup()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void QueueTutorialPopupRequest(TutorialPopupRequest request)
	{
	}

	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "RemoveCurrentTutorialPopup")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowNextTutorialPopup")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	private TutorialPopupRequest GetCurrentConfirmationRequest()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[Calls(Type = typeof(Utils), Member = "GetTitleString")]
	[Calls(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private void ShowTutorialPopupRequest(TutorialPopupRequest tutorialPopupRequest)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_TutorialPopup), Member = "OnExecute")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CallsUnknownMethods(Count = 4)]
	public void ShowTutorialPopupRequest(string name)
	{
	}

	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Update")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateButtons()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Panel_TutorialPopup()
	{
	}
}
