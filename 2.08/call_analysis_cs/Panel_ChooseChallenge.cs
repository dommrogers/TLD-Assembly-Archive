using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_ChooseChallenge : Panel_AutoReferenced
{
	private PanelReference<Panel_Challenges> m_Challenges;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_Loading> m_Loading;

	private PanelReference<Panel_MainMenu> m_MainMenu;

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

	private SaveSlotInfo m_SlotToRename;

	private SaveSlotInfo m_SlotToDelete;

	private BasicMenu m_BasicMenu;

	private CloudSaveMenuExtension m_CloudSaveMenuExtension;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_AutoReferenced), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Enable")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	private void ConfigureMenu()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	private void AddSavesOfTypeToMenu()
	{
	}

	[Calls(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemId")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 3)]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void BackWithouSFX()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemId")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessMenu()
	{
	}

	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CallerCount(Count = 0)]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRename")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CallsUnknownMethods(Count = 1)]
	private SaveSlotInfo GetSelectedSaveSlotInfo()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "GetSelectedSaveSlotInfo")]
	public void OnRename()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnRenameExistingChallengeCancelled(bool wasCancelled)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveUserDefinedSlotName")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void OnRenameExistingChallengeConfirmed()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowDeleteConfirmationPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "GetSelectedSaveSlotInfo")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnDelete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "GetSelectedSaveSlotInfo")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndexNextId")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndexFromId")]
	private void DeleteSaveSlot()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDeleteCancelled(bool wasCancelled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[CallsUnknownMethods(Count = 1)]
	private void OnLoadSlotClicked(int index)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[CallsUnknownMethods(Count = 2)]
	private void OnSlotClicked()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_ChooseChallenge()
	{
	}
}
