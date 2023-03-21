using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Confirmation : Panel_AutoReferenced
{
	public delegate void CallbackDelegate();

	public delegate void EnableDelegate(bool enable);

	[Serializable]
	public class Group
	{
		public GameObject m_Parent;

		public ButtonLegendContainer m_ButtonLegendContainer;

		public UILabel m_MessageLabel;

		public UILabel m_MessageLabel_InputFieldTitle;

		public UILabel m_MessageLabel_InputFieldText;

		public GameObject m_2ButtonLayout;

		public GameObject m_1ButtonLayout;

		public UILabel m_1ButtonLayout_LabelConfirm;

		public UIButton m_2ButtonLayout_ButtonConfirm;

		public UILabel m_2ButtonLayout_LabelConfirm;

		public UILabel m_2ButtonLayout_LabelCancel;

		public GameObject m_FadeOverlayTransparent;

		public GameObject m_FadeOverlayOpaque;

		public GameObject[] m_MouseButtons;

		public TextInputField m_InputField;

		[CalledBy(Type = typeof(Panel_Confirmation), Member = "Initialize")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
		[CallsUnknownMethods(Count = 2)]
		public void Initialize(GameObject obj)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public Group()
		{
		}
	}

	public enum ConfirmationType
	{
		ControllerDisconnect,
		SaveFailed,
		SaveFailedSlots,
		UserSignedOut,
		QuitGame,
		DeleteSaveSlot,
		ResetAllTimeStats,
		DeleteJournal,
		OverwriteJournalNotification,
		OverwriteJournalConfirmation,
		Rename,
		QuitWithoutSavingJournal,
		ResetBindings,
		BurnResearch,
		OverwriteSaveConfirmation,
		SettingsNeedRestart,
		Waiting,
		MailingListResult,
		MailingListPanel,
		ErrorMessage,
		CloudSyncCloudNewerConfirm,
		CloudSyncLocalNewerConfirm,
		CloudRetryAuthentication,
		Confirm
	}

	public class ConfirmationRequest
	{
		public CallbackDelegate m_ConfirmCallback;

		public EnableDelegate m_EnableCallback;

		public ConfirmationType m_ConfirmationType;

		public string m_TitleLocID;

		public string m_MessageLocID;

		public ButtonLayout m_ButtonLayout;

		public Background m_Background;

		public string m_RenameCurrentName;

		public string m_ButtonPromptLocId1;

		public string m_ButtonPromptLocId2;

		[CallerCount(Count = 0)]
		public bool IsInputType()
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ConfirmationRequest()
		{
		}
	}

	public enum ButtonLayout
	{
		Button_0,
		Button_1,
		Button_2
	}

	public enum Background
	{
		None,
		Opaque,
		Transperent
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ConfirmationRequest> _003C_003E9__29_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "CompareTo")]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CQueueConfirmation_003Eb__29_0(ConfirmationRequest a, ConfirmationRequest b)
		{
			return 0;
		}
	}

	public Group m_GenericMessageGroup;

	public Group m_EmailSubmissionGroup;

	private Group m_CurrentGroup;

	private List<ConfirmationRequest> m_ConfirmationRequests;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Group), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetActiveButtons")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "GetPauseMenuTogglePressed")]
	[Calls(Type = typeof(InputManager), Member = "CheckForActiveController")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "OnConfirm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "UpdateButtons")]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetActiveButtons")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsControllerDisconnectedPanel()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void CancelConfirmation(ConfirmationType confirmationType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ForceQuit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallsUnknownMethods(Count = 1)]
	public string GetInputFieldText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetMaxInputLength()
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string GetVirtualKeyboardDescription()
	{
		return null;
	}

	[CalledBy(Type = typeof(RockCache), Member = "OnLabel")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupConfirmed")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupCancelled")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	public void SetupInputField(string virtualKeyboardDescriptionLocId, uint maxLength, bool capsLock)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveConfirmation(ConfirmationRequest confirmation)
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "OnConfirm")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShowNextConfirmation(ConfirmationRequest currentConfirmation)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	private void SetCurrentGroup(Group group)
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "MaybeUpdateDisconnectedGamepadConfirmButton")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "SetActiveButtons")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "UpdateButtons")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(InputManager), Member = "HasReconnectedJoystick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private bool IsControllerSchemeEnabled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeUpdateDisconnectedGamepadConfirmButton()
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void SetActiveButtons(ConfirmationRequest confirmationRequest)
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowNextConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetCurrentGroup")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetActiveButtons")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[Calls(Type = typeof(InputManager), Member = "PauseGame")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 19)]
	private void ShowCurrentConfirmation()
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void QueueConfirmation(ConfirmationRequest request)
	{
	}

	[CallerCount(Count = 44)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	private void AddConfirmation(ConfirmationType type, string messageLocID, ButtonLayout buttonLayout, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowMailingListResultPanel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	private void AddConfirmation(ConfirmationType type, string titleLocID, string messageLocID, ButtonLayout buttonLayout, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(RockCache), Member = "OnLabel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	private void AddConfirmation(ConfirmationType type, string titleLocID, string currentName, ButtonLayout buttonLayout, string buttonLocID1, string buttonLocID2, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnClickedDeleteAll")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteItemRequested")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowConfirmPanel")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	private void AddConfirmation(ConfirmationType type, string titleLocID, ButtonLayout buttonLayout, string buttonLocID1, string buttonLocID2, Background background, CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowMailingListPanel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCloudRetryAuthenticationConfirmationPanel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCloudSyncCloudNewerConfirm")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCloudSyncLocalNewer")]
	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.AuthenticateOperation", Member = "ShowRetryDialog")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "RequestUserConfirmation")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	private void AddConfirmation(ConfirmationType type, string titleLocID, string messageLocID, string currentName, ButtonLayout buttonLayout, string buttonLocID1, string buttonLocID2, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowWaitingPanel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	private void AddConfirmation(ConfirmationType type, string messageLocID, ButtonLayout buttonLayout, Background background, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "IsControllerDisconnectedPanel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "CancelConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "OnConfirm")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "IsConfirmationEnabled")]
	[CalledBy(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[CallerCount(Count = 9)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private ConfirmationRequest GetCurrentConfirmationRequest()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowErrorMessage(string text, CallbackDelegate confirmCallback = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowControllerDisconnectedPanel(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowSignoutConfirmationPanel(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowQuitConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnDelete")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowDeleteConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowResetAllTimeStatsConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowDeleteJounalPanel(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowOverwriteJournalPanelConfirmation(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowOverwriteSaveConfirmation(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowOverwriteJournalPanelNotification(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRename")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRename")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[CalledBy(TypeFullName = "Panel_SaveStory.<OnOverwriteConfirmedCoroutine>d__56", Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRename")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[CallsUnknownMethods(Count = 1)]
	public void ShowRenamePanel(string locID, string currentName, string buttonPromptLocId1, string buttonPromptLocId2, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "OnSprayPaintMarkerRemove")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowConfirmPanel(string locID, string buttonPromptLocId1, string buttonPromptLocId2, CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowMailingListPanel(string titleLocID, string messageLocID, string currentName, string buttonPromptLocId1, string buttonPromptLocId2, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowMailingListResultPanel(string titleLocID, string messageLocID)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowQuitWithoutSavingJournalNotification(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowResetBindingsNotification(CallbackDelegate confirmCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowBurnResearchNotification(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowEatRawMeatRadialNotification(CallbackDelegate confirmCallback)
	{
	}

	[CalledBy(Type = typeof(LoadScene), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameData), Member = "MaybeDisplayErrorNotification")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowSaveGameFailedSaveNotification(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowProfileFailedSaveNotification(CallbackDelegate confirmCallback)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGameForEpisodeMigration")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowSaveGameFaileLoadNotification(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowProfileFailedLoadNotification(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowSaveDeleteFailedNotification(CallbackDelegate confirmCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickNew")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowNotEnoughSaveSlotsAvailableNotification(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowSettingsNeedRestartPanel(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowWaitingPanel(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowCloudRetryAuthenticationConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowCloudSyncCloudNewerConfirm(CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowCloudSyncLocalNewer(CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowNextConfirmation")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnConfirm()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "CancelConfirmation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowNextConfirmation")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateButtons()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsConfirmationEnabled(ConfirmationType confirmationType)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_Confirmation()
	{
	}
}
