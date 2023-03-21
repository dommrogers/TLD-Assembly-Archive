using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using SpecialEvents;
using UnityEngine;

public class Panel_ChallengeComplete : Panel_Base
{
	public enum Options
	{
		None = 0,
		Succeeded = 1,
		ToBeContinued = 2,
		ShowFailTimeSurvived = 4,
		ShowFailStatInfo = 8
	}

	private static string[] SPECIAL_SLOT_PREFIXES;

	private static string[] SPECIAL_SLOT_LOCIDS;

	private static int[] SPECIAL_SLOT_LIMITS;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public float m_SecondsBeforeShowMenuSuccess;

	public float m_SecondsBeforeShowMenuFail;

	public float m_SecondsBeforeShowMenuToBeContinued;

	public int m_MaxSavesToDisplay;

	public GameObject[] m_ButtonObjects;

	public Animator m_SuccessAnimator;

	public Animator m_FailAnimator;

	public UITexture m_BadgeTexture;

	public UILabel m_ChallengeNameLabel;

	public UILabel m_SurvivedTimeLabel;

	public UILabel m_BestTimeLabel;

	public GameObject m_TryAgainButtonParent;

	public UILabel m_FailReasonLabel;

	public GameObject m_BasicMenuRoot;

	public UtilsPanelChoose.DetailsObjets m_DetailObjects;

	public UILabel m_EpisodeValue;

	public UILabel m_ProgressValue;

	public UILabel m_MostRecentSavesLabel;

	public GameObject m_FailInfoGroup;

	public UILabel m_FailSurvivedTimeLabel;

	public GameObject m_FailSurvivedTimeHeader;

	public UILabel m_FailStatLabel;

	public GameObject m_NowhereToHideRoot;

	public UILabel m_SurvivedTimeLabelN2H;

	public UILabel m_BestTimeLabelN2H;

	public UILabel m_CollectibleCountLabelN2H;

	public Animator m_GameOverAnimatorN2H;

	public Animator m_BadgeAnimatorN2H;

	public GameObject m_FailInfoGroupN2H;

	public string m_NowhereToHideAudioEvent;

	public UILabel m_DeathDescriptionN2H;

	public LocalizedString m_DevouredTextN2H;

	public Animator m_SuccessAnimatorN2H;

	public UILabel m_SuccessSurvivedTimeLabelN2H;

	public UILabel m_SuccessBestTimeLabelN2H;

	private BasicMenu m_BasicMenu;

	private SaveSlotInfo m_LastSaveSlotInfo;

	private SaveSlotInfo m_LastCheckpointSlotInfo;

	private Dictionary<string, int> m_SaveSlotMapping;

	private UILabel m_TryAgainButtonLabel;

	private float m_FinalScreenCountdownSeconds;

	private int m_AnimParameter_ShowFailScreen;

	private int m_AnimParameter_ShowSuccessScreen;

	private int m_AnimParameter_ShowToBeContinued;

	private bool m_ShowTimeSurvived;

	private bool m_ShowStatInfo;

	private bool m_N2HAudioTriggered;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 14)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "OnFinalScreenShown")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateLabels")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetBadgeIcon")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionMessage")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateBestTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(Utils), Member = "SendGameOverAnalyticsEvent")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFilesForGameId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "WinChallenge")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WinHunted2Challenge")]
	[CalledBy(Type = typeof(Action_ShowChallengeComplete), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 79)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathString")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Show")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateLabels")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateBestTime")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateBestTime")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public void ShowPanel(Options panelOptions)
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ReloadSlot")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Show")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public void DisablePanel()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnFinalScreenShown")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "OnClickBack")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "BackWithouSFX")]
	[CallsUnknownMethods(Count = 2)]
	public void EnableLoadList(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void DisableReloadCheckpointButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallsUnknownMethods(Count = 2)]
	public void OnMainMenu()
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnLoadOther()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	public void OnTryAgain()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Update")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "EnableLoadList")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	public void OnFinalScreenShown()
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "GetItemCount")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "EnableLoadList")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemCount")]
	[CallsUnknownMethods(Count = 51)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemCount")]
	[Calls(Type = typeof(BasicMenu), Member = "AddLineBreak")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void ConfigureMenu()
	{
	}

	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(DateTime), Member = "ToShortTimeString")]
	[Calls(Type = typeof(DateTime), Member = "ToShortDateString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetDescriptionLabelForSlot(SaveSlotInfo slotInfo)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void SetTimeSurvivedLabel(UILabel label)
	{
	}

	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateBestTime(UILabel label)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private string GetBadgeNameForCurrentChallenge()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Update")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateLabels()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "LoadGame")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	private void ReloadSlot(SaveSlotInfo slotInfo)
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetTimeSinceText")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 28)]
	private void AddSavesOfTypeToMenu(string[] slotPrefixes, string[] displayLocIds = null, int[] limits = null, bool showTimeSinceSave = false)
	{
	}

	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "LoadGame")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "GetSaveSlotInfo")]
	[CallerCount(Count = 0)]
	private void OnSlotClicked()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnSlotClicked")]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetEpisodeGenericNameLocId")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CalledBy(Type = typeof(Action_ShowChallengeComplete), Member = "OnExecute")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public void SetStatInfoText(string locId, string stat1MarkerValue, int stat1ValueValue, string stat2MarkerValue, int stat2ValueValue)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 18)]
	public Panel_ChallengeComplete()
	{
	}
}
