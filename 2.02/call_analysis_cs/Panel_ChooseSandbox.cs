using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_ChooseSandbox : Panel_Base
{
	[Serializable]
	public class AnimMenuItems
	{
		public GameObject m_Display;

		public ExperienceModeType m_Type;

		public AnimationStateRef m_PlayOnSelect;

		public AnimationStateRef m_PlayOnDeselect;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 14)]
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

	public ButtonLegendContainer m_ButtonLegendContainer;

	public UtilsPanelChoose.DetailsObjets m_DetailObjects;

	public string m_TitleLocalizationId;

	public string m_TitleHeaderLocalizationId;

	public Vector3 m_TitleHeaderOffset;

	public GameObject m_BasicMenuRoot;

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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 4)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Enable")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	private void ConfigureMenu()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetSaveSlotInfo")]
	private void AddSavesOfTypeToMenu()
	{
	}

	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void BackWithouSFX()
	{
	}

	[Calls(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Update")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private void ProcessMenu()
	{
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRename")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSelectionUpdate")]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallerCount(Count = 0)]
	private SaveSlotInfo GetSelectedSaveSlotInfo()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 18)]
	public void OnRename()
	{
	}

	[CallerCount(Count = 0)]
	public void OnRenameExistingSandboxCancelled(bool wasCancelled)
	{
	}

	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveUserDefinedSlotName")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnRenameExistingSandboxConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowDeleteConfirmationPanel")]
	[CallsUnknownMethods(Count = 16)]
	public void OnDelete()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndexNextId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndexFromId")]
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

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetSaveSlotInfo")]
	[CallerCount(Count = 0)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[CallsUnknownMethods(Count = 1)]
	private void OnLoadSlotClicked(int index)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	private void OnSlotClicked()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "UpdateAnimation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void EnableSingleAnimItem(int targetIndex)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 2)]
	private AnimMenuItems GetAnimMenuItem(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "IsPlayingAnimation")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool IsPlayingAnySelectionAnimation()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "IsPlayingAnimation")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 5)]
	private bool IsPlayingAnyDeselectionAnimation()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "IsPlayingAnySelectionAnimation")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayingAnimation(int stateHash)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void PlaySelectedAnimation(AnimMenuItems menuItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	private void PlayDeselectedAnimation(AnimMenuItems menuItem)
	{
	}

	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "EnableSingleAnimItem")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Update")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetAnimMenuItem")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "EnableSingleAnimItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "GetAnimMenuItem")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "IsPlayingAnySelectionAnimation")]
	[Calls(Type = typeof(Panel_ChooseSandbox), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	private void UpdateAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public Panel_ChooseSandbox()
	{
	}
}
