using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gameplay;
using TLD.SaveState;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;

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

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateLabels")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "EnableLoadList")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateProfileAfterChallengeComplete")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionMessage")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFilesForGameId")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "WinChallenge")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DraggingAnimationEnd")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WinHunted2Challenge")]
	[CalledBy(Type = typeof(Action_ShowChallengeComplete), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SendGameOverAnalyticsEvent")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathString")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateLabels")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateProfileAfterChallengeComplete")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateProfileAfterChallengeComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public void ShowPanel(Options panelOptions)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ReloadSlot")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public void DisablePanel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnFinalScreenShown")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Update")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void EnableLoadList(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void DisableReloadCheckpointButton()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	public void OnMainMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnLoadOther()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallerCount(Count = 0)]
	public void OnTryAgain()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "EnableLoadList")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	public void OnFinalScreenShown()
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "EnableLoadList")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddLineBreak")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	private void ConfigureMenu()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.DateTimeFormat), Member = "Format")]
	[Calls(Type = typeof(System.DateTimeFormat), Member = "Format")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetDescriptionLabelForSlot(SaveSlotInfo slotInfo)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[Calls(Type = typeof(Utils), Member = "GetTimeSurvivedString")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetElapsedTimeInHours")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void SetTimeSurvivedLabel(UILabel label)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetElapsedTimeInHours")]
	private static float GetElapsedTimeInHours()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(Utils), Member = "GetTimeSurvivedString")]
	[Calls(Type = typeof(ChallengeConfig), Member = "MaybeUpdateBestTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateProfileAfterChallengeComplete(bool success, UILabel bestTimeLabel)
	{
	}

	[CallerCount(Count = 0)]
	private AssetReferenceTexture2D GetBadgeForCurrentChallenge()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateLabels()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "LoadGame")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	private void ReloadSlot(SaveSlotInfo slotInfo)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Utils), Member = "GetTimeSinceText")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void AddSavesOfTypeToMenu(string[] slotPrefixes, string[] displayLocIds = null, int[] limits = null, bool showTimeSinceSave = false)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(GameManager), Member = "LoadGame")]
	[CallerCount(Count = 0)]
	private void OnSlotClicked()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetEpisodeGenericNameLocId")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CalledBy(Type = typeof(Action_ShowChallengeComplete), Member = "OnExecute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public void SetStatInfoText(string locId, string stat1MarkerValue, int stat1ValueValue, string stat2MarkerValue, int stat2ValueValue)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public Panel_ChallengeComplete()
	{
	}
}
