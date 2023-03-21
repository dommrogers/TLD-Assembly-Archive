using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Choose4DON : Panel_Base
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "Enable")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(Panel_Choose4DON), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void ConfigureMenu()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Panel_Choose4DON), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SpecialEvent), Member = "GetSandboxMenuDescSuffix")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void AddSavesOfTypeToMenu()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Panel_Choose4DON), Member = "ProcessMenu")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_Choose4DON), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void BackWithouSFX()
	{
	}

	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "Update")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	private void ProcessMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnRename")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnSelectionUpdate")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "AddSavesOfTypeToMenu")]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[Calls(Type = typeof(Panel_Choose4DON), Member = "GetSaveSlotInfo")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	private SaveSlotInfo GetSelectedSaveSlotInfo()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_Choose4DON), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 18)]
	public void OnRename()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnRenameExistingSandboxCancelled(bool wasCancelled)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Choose4DON), Member = "ConfigureMenu")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveUserDefinedSlotName")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void OnRenameExistingSandboxConfirmed()
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Choose4DON), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowDeleteConfirmationPanel")]
	[CallsUnknownMethods(Count = 16)]
	public void OnDelete()
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(Panel_Choose4DON), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndexNextId")]
	[Calls(Type = typeof(Panel_Choose4DON), Member = "ConfigureMenu")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Choose4DON), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[CallsUnknownMethods(Count = 3)]
	private void OnSlotClicked()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Panel_Choose4DON()
	{
	}
}
