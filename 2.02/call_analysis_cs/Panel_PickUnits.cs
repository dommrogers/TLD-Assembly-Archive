using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_PickUnits : Panel_Base
{
	public ButtonLegendContainer m_ButtonLegendContainer;

	public UILabel m_Label_Description;

	public UILabel m_Label_NumUnits;

	public GameObject m_Execute_Button;

	public GameObject m_ExecuteAll_Button;

	public UITexture m_GearIcon;

	public GameObject m_ButtonIncrease;

	public GameObject m_ButtonDecrease;

	public int m_numUnits;

	public int m_maxUnits;

	public EnablePanelOnExit m_EnablePanelOnExit;

	public bool m_CameFromDrag;

	private GearItem m_GearItem;

	private Container m_Container;

	private PickUnitsExecuteAction m_ExecuteAction;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryEquipPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "GetKeyDown")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(InputManager), Member = "GetKeyDown")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	private void ExitInterface()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "ExitInterface")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	public void OnAll()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "Update")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "DropGear")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[Calls(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecuteAll")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Container), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	public void OnExecuteAll()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnIncrease()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnDecrease()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	public void SetGearForDrop(GearItem gi)
	{
	}

	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetGearForHarvest(GearItem gi)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CallsUnknownMethods(Count = 1)]
	public void SetGearForTransferToContainer(GearItem gi, Container c)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	public void SetGearForTransferToInventory(GearItem gi, Container c)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnAll")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecuteAll")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnIncrease")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnDecrease")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "SetGearForDrop")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "SetGearForHarvest")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToContainer")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Container), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	private void Refresh()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallerCount(Count = 1)]
	private void DropGear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[CallsUnknownMethods(Count = 5)]
	private void HarvestGear()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToContainerItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateStackable")]
	public void TransferGearInventoryToContainer()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToInventoryItem")]
	[Calls(Type = typeof(Container), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	public void TransferGearContainerToInventory()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Panel_PickUnits()
	{
	}
}
