using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_ChooseChallenge : Panel_Base
{
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 4)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Enable")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 3)]
	private void ConfigureMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "GetSaveSlotInfo")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	private void AddSavesOfTypeToMenu()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void BackWithouSFX()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemId")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Update")]
	[CallsUnknownMethods(Count = 22)]
	private void ProcessMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRename")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "GetSelectedSaveSlotInfo")]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "GetSaveSlotInfo")]
	[CallsUnknownMethods(Count = 1)]
	private SaveSlotInfo GetSelectedSaveSlotInfo()
	{
		return null;
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "GetSaveSlotInfo")]
	public void OnRename()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnRenameExistingChallengeCancelled(bool wasCancelled)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveUserDefinedSlotName")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void OnRenameExistingChallengeConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowDeleteConfirmationPanel")]
	[CallsUnknownMethods(Count = 16)]
	public void OnDelete()
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndexFromId")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndexNextId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void DeleteSaveSlot()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDeleteCancelled(bool wasCancelled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_ChooseChallenge), Member = "GetSaveSlotInfo")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[CallsUnknownMethods(Count = 1)]
	private void OnLoadSlotClicked(int index)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void OnSlotClicked()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public Panel_ChooseChallenge()
	{
	}
}
