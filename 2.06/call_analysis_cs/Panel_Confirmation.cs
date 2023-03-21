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
		[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(Panel_Confirmation), Member = "Initialize")]
		public void Initialize(GameObject obj)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Enum), Member = "CompareTo")]
		[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Group), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetActiveButtons")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputField), Member = "IsLockedIn")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "UpdateButtons")]
	[CallerCount(Count = 0)]
	public void LateUpdate()
	{
	}

	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetActiveButtons")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	public bool IsControllerDisconnectedPanel()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 4)]
	public void CancelConfirmation(ConfirmationType confirmationType)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string GetVirtualKeyboardDescription()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupCancelled")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupConfirmed")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(RockCache), Member = "OnLabel")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
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
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
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

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	private void SetActiveButtons(ConfirmationRequest confirmationRequest)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowNextConfirmation")]
	[Calls(Type = typeof(InputManager), Member = "PauseGame")]
	[Calls(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetActiveButtons")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetCurrentGroup")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void ShowCurrentConfirmation()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	private void QueueConfirmation(ConfirmationRequest request)
	{
	}

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallsUnknownMethods(Count = 6)]
	private void AddConfirmation(ConfirmationType type, string messageLocID, ButtonLayout buttonLayout, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowMailingListResultPanel")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallerCount(Count = 1)]
	private void AddConfirmation(ConfirmationType type, string titleLocID, string messageLocID, ButtonLayout buttonLayout, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CalledBy(Type = typeof(RockCache), Member = "OnLabel")]
	private void AddConfirmation(ConfirmationType type, string titleLocID, string currentName, ButtonLayout buttonLayout, string buttonLocID1, string buttonLocID2, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteItemRequested")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowConfirmPanel")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnClickedDeleteAll")]
	private void AddConfirmation(ConfirmationType type, string titleLocID, ButtonLayout buttonLayout, string buttonLocID1, string buttonLocID2, Background background, CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowMailingListPanel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCloudRetryAuthenticationConfirmationPanel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCloudSyncCloudNewerConfirm")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCloudSyncLocalNewer")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.AuthenticateOperation), Member = "ShowRetryDialog")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "RequestUserConfirmation")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	private void AddConfirmation(ConfirmationType type, string titleLocID, string messageLocID, string currentName, ButtonLayout buttonLayout, string buttonLocID1, string buttonLocID2, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowWaitingPanel")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "QueueConfirmation")]
	[CallerCount(Count = 1)]
	private void AddConfirmation(ConfirmationType type, string messageLocID, ButtonLayout buttonLayout, Background background, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "IsConfirmationEnabled")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "OnConfirm")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "IsControllerDisconnectedPanel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "CancelConfirmation")]
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

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
	public void ShowQuitConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnDelete")]
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

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
	public void ShowOverwriteSaveConfirmation(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowOverwriteJournalPanelNotification(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRename")]
	[CalledBy(Type = typeof(Panel_SaveStory._003COnOverwriteConfirmedCoroutine_003Ed__56), Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameSandbox")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRename")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRename")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
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

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
	public void ShowResetBindingsNotification(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	public void ShowBurnResearchNotification(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public void ShowEatRawMeatRadialNotification(CallbackDelegate confirmCallback)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameData), Member = "MaybeDisplayErrorNotification")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(LoadScene), Member = "Update")]
	public void ShowSaveGameFailedSaveNotification(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
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

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
	public void ShowProfileFailedLoadNotification(CallbackDelegate confirmCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
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

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "CancelConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowNextConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[CallerCount(Count = 4)]
	public void OnCancel()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "LateUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	private void UpdateButtons()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[CallerCount(Count = 0)]
	private bool IsConfirmationEnabled(ConfirmationType confirmationType)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Panel_Confirmation()
	{
	}
}
