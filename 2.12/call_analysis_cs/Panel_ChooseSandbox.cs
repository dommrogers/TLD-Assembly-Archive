using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_ChooseSandbox : Panel_AutoReferenced
{
	[Serializable]
	public class AnimMenuItems
	{
		public GameObject m_Display;

		public SandboxConfig m_SandboxConfig;

		public AnimationStateRef m_PlayOnSelect;

		public AnimationStateRef m_PlayOnDeselect;

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public AnimMenuItems()
		{
		}
	}

	private enum AnimationState
	{
		None,
		Select,
		Deselect
	}

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_Loading> m_Loading;

	private PanelReference<Panel_MainMenu> m_MainMenu;

	private PanelReference<Panel_Sandbox> m_Sandbox;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public UtilsPanelChoose.DetailsObjets m_DetailObjects;

	public LocalizedString m_Title;

	public LocalizedString m_TitleHeader;

	public Vector3 m_TitleHeaderOffset;

	public GameObject m_BasicMenuRoot;

	public Color m_InvalidSaveColor;

	public LocalizedString m_MissingDLCString;

	public UILabel m_SlotsUsedLabel;

	public Color m_SlotsUsedColorNormal;

	public Color m_SlotsUsedColorFull;

	public GameObject m_MouseButtonDelete;

	public GameObject m_MouseButtonRename;

	public UILabel m_CloudMessageLabel;

	public List<AnimMenuItems> m_AnimMenuItems;

	public Animator m_Animator;

	private SaveSlotInfo m_SlotToRename;

	private SaveSlotInfo m_SlotToDelete;

	private BasicMenu m_BasicMenu;

	private CloudSaveMenuExtension m_CloudSaveMenuExtension;

	private const int INVALID_INDEX = -1;

	private int m_PreviousAnimIndex;

	private int m_TargetAnimIndex;

	private AnimationState m_CurrentEpisodeAnimationState;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_AutoReferenced), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ConfigureMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsMissingOptionalContent")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsLoadable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void AddSavesOfTypeToMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "UpdateAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 3)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void BackWithouSFX()
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetSelectedSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsMissingOptionalContent")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsLoadable")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRename")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CallsUnknownMethods(Count = 1)]
	private SaveSlotInfo GetSelectedSaveSlotInfo()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetSelectedSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnRename()
	{
	}

	[CallerCount(Count = 0)]
	public void OnRenameExistingSandboxCancelled(bool wasCancelled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveUserDefinedSlotName")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[CallsUnknownMethods(Count = 2)]
	private void OnRenameExistingSandboxConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetSelectedSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowDeleteConfirmationPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDelete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndexNextId")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndexFromId")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetSelectedSaveSlotInfo")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallsUnknownMethods(Count = 1)]
	private void DeleteSaveSlot()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDeleteCancelled(bool wasCancelled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsMissingOptionalContent")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsLoadable")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnLoadSlotClicked(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsMissingOptionalContent")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsLoadable")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnSlotClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "UpdateAnimation")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void EnableSingleAnimItem(int targetIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "UpdateAnimation")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private AnimMenuItems GetAnimMenuItem(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "UpdateAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "IsPlayingAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private bool IsPlayingAnySelectionAnimation()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "UpdateAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "IsPlayingAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private bool IsPlayingAnyDeselectionAnimation()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "IsPlayingAnySelectionAnimation")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayingAnimation(int stateHash)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void PlaySelectedAnimation(AnimMenuItems menuItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void PlayDeselectedAnimation(AnimMenuItems menuItem)
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "IsPlayingAnyDeselectionAnimation")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "IsPlayingAnySelectionAnimation")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetAnimMenuItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "EnableSingleAnimItem")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_ChooseSandbox()
	{
	}
}
