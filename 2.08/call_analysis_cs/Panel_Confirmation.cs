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

		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Panel_Confirmation), Member = "Initialize")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
		[CalledBy(Type = typeof(Panel_Confirmation), Member = "Initialize")]
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
			return default(bool);
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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "CompareTo")]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CQueueConfirmation_003Eb__29_0(ConfirmationRequest a, ConfirmationRequest b)
		{
			return default(int);
		}
	}

	public Group m_GenericMessageGroup;

	public Group m_EmailSubmissionGroup;

	private Group m_CurrentGroup;

	private List<ConfirmationRequest> m_ConfirmationRequests;

	[Calls(Type = typeof(Group), Member = "Initialize")]
	[Calls(Type = typeof(Group), Member = "Initialize")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "OnConfirm")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "CheckForActiveController")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetPauseMenuTogglePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetActiveButtons")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "UpdateButtons")]
	[CallerCount(Count = 0)]
	public void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetActiveButtons")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsControllerDisconnectedPanel()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 4)]
	public void CancelConfirmation(ConfirmationType confirmationType)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ForceQuit()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	public string GetInputFieldText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetMaxInputLength()
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string GetVirtualKeyboardDescription()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupCancelled")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupConfirmed")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
	[CalledBy(Type = typeof(RockCache), Member = "OnLabel")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	public void SetupInputField(string virtualKeyboardDescriptionLocId, uint maxLength, bool capsLock)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveConfirmation(ConfirmationRequest confirmation)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "OnConfirm")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	private bool ShowNextConfirmation(ConfirmationRequest currentConfirmation)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	private void SetCurrentGroup(Group group)
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "MaybeUpdateDisconnectedGamepadConfirmButton")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "UpdateButtons")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "SetActiveButtons")]
	[Calls(Type = typeof(InputManager), Member = "HasReconnectedJoystick")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	private bool IsControllerSchemeEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeUpdateDisconnectedGamepadConfirmButton()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Enable")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	private void SetActiveButtons(ConfirmationRequest confirmationRequest)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowNextConfirmation")]
	[Calls(Type = typeof(InputManager), Member = "PauseGame")]
	[Calls(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetActiveButtons")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetCurrentGroup")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void ShowCurrentConfirmation()
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CallsDeduplicatedMethods(Count = 4)]
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
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	private void AddConfirmation(ConfirmationType type, string titleLocID, string messageLocID, ButtonLayout buttonLayout, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CalledBy(Type = typeof(RockCache), Member = "OnLabel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 5)]
	private void AddConfirmation(ConfirmationType type, string titleLocID, string currentName, ButtonLayout buttonLayout, string buttonLocID1, string buttonLocID2, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowConfirmPanel")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnClickedDeleteAll")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteItemRequested")]
	private void AddConfirmation(ConfirmationType type, string titleLocID, ButtonLayout buttonLayout, string buttonLocID1, string buttonLocID2, Background background, CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.AuthenticateOperation), Member = "ShowRetryDialog")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCloudSyncLocalNewer")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCloudSyncCloudNewerConfirm")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "RequestUserConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowMailingListPanel")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCloudRetryAuthenticationConfirmationPanel")]
	private void AddConfirmation(ConfirmationType type, string titleLocID, string messageLocID, string currentName, ButtonLayout buttonLayout, string buttonLocID1, string buttonLocID2, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowWaitingPanel")]
	[CallsUnknownMethods(Count = 1)]
	private void AddConfirmation(ConfirmationType type, string messageLocID, ButtonLayout buttonLayout, Background background, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "IsConfirmationEnabled")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "OnConfirm")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "CancelConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "IsControllerDisconnectedPanel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 9)]
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

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
	public void ShowSignoutConfirmationPanel(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowQuitConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnDelete")]
	public void ShowDeleteConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowResetAllTimeStatsConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRename")]
	[CalledBy(Type = typeof(Panel_SaveStory._003COnOverwriteConfirmedCoroutine_003Ed__56), Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameSandbox")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRename")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRename")]
	public void ShowRenamePanel(string locID, string currentName, string buttonPromptLocId1, string buttonPromptLocId2, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "OnSprayPaintMarkerRemove")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowConfirmPanel(string locID, string buttonPromptLocId1, string buttonPromptLocId2, CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(LoadScene), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameData), Member = "MaybeDisplayErrorNotification")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	public void ShowSaveGameFailedSaveNotification(CallbackDelegate confirmCallback)
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
	public void ShowProfileFailedSaveNotification(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGameForEpisodeMigration")]
	public void ShowSaveGameFaileLoadNotification(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowProfileFailedLoadNotification(CallbackDelegate confirmCallback)
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
	public void ShowSaveDeleteFailedNotification(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickNew")]
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

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
	public void ShowCloudRetryAuthenticationConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowCloudSyncCloudNewerConfirm(CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
	public void ShowCloudSyncLocalNewer(CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowNextConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	public void OnConfirm()
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowNextConfirmation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "CancelConfirmation")]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	private void UpdateButtons()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	private bool IsConfirmationEnabled(ConfirmationType confirmationType)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_Confirmation()
	{
	}
}
