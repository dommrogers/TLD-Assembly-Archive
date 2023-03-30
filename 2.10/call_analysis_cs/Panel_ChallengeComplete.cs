using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.AddressableAssets;
using TLD.Gameplay;
using TLD.SaveState;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateLabels")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "EnableLoadList")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "WinChallenge")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DraggingAnimationEnd")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WinHunted2Challenge")]
	[CalledBy(Type = typeof(Action_ShowChallengeComplete), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateLabels")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "UpdateProfileAfterChallengeComplete")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathString")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionMessage")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(Utils), Member = "SendGameOverAnalyticsEvent")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFilesForGameId")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 21)]
	public void ShowPanel(Options panelOptions)
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ReloadSlot")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnSlotClicked")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void DisablePanel()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnFinalScreenShown")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableLoadList(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void DisableReloadCheckpointButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnMainMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnLoadOther()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[Calls(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnTryAgain()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "EnableLoadList")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	public void OnFinalScreenShown()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "EnableLoadList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "AddLineBreak")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	private void ConfigureMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.DateTimeFormat", Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 5)]
	private string GetDescriptionLabelForSlot(SaveSlotInfo slotInfo)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetElapsedTimeInHours")]
	[Calls(Type = typeof(Utils), Member = "GetTimeSurvivedString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetTimeSurvivedLabel(UILabel label)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetElapsedTimeInHours")]
	private static float GetElapsedTimeInHours()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ChallengeConfig), Member = "MaybeUpdateBestTime")]
	[Calls(Type = typeof(Utils), Member = "GetTimeSurvivedString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateProfileAfterChallengeComplete(bool success, UILabel bestTimeLabel)
	{
	}

	[CallerCount(Count = 0)]
	private AssetReferenceTexture2D GetBadgeForCurrentChallenge()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateLabels()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "LoadGame")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	private void ReloadSlot(SaveSlotInfo slotInfo)
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(Utils), Member = "GetTimeSinceText")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void AddSavesOfTypeToMenu(string[] slotPrefixes, string[] displayLocIds = null, int[] limits = null, bool showTimeSinceSave = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(GameManager), Member = "LoadGame")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetEpisodeGenericNameLocId")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[CalledBy(Type = typeof(Action_ShowChallengeComplete), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
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
