using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_PickUnits : Panel_AutoReferenced
{
	public ButtonLegendContainer m_ButtonLegendContainer;

	public UILabel m_Label_Description;

	public UILabel m_Label_NumUnits;

	public GameObject m_Execute_Button;

	public GameObject m_ExecuteAll_Button;

	public UITexture m_GearIcon;

	public GameObject m_ButtonIncrease;

	public GameObject m_ButtonDecrease;

	private PanelReference<Panel_Container> m_ContainerPanel;

	private PanelReference<Panel_Crafting> m_CraftingPanel;

	private PanelReference<Panel_Harvest> m_Harvest;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	private PanelReference<Panel_Repair> m_Repair;

	public int m_numUnits;

	public int m_maxUnits;

	public EnablePanelOnExit m_EnablePanelOnExit;

	public bool m_CameFromDrag;

	private GearItem m_GearItem;

	private Container m_Container;

	private PickUnitsExecuteAction m_ExecuteAction;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	private void ExitInterface()
	{
	}

	[Calls(Type = typeof(Panel_PickUnits), Member = "ExitInterface")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnAll()
	{
	}

	[Calls(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecuteAll")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "DropGear")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void OnExecute()
	{
	}

	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CallerCount(Count = 0)]
	public void OnExecuteAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnIncrease()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	public void OnDecrease()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[CallerCount(Count = 1)]
	public void SetGearForDrop(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public void SetGearForTransferToInventory(GearItem gi, Container c)
	{
	}

	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnIncrease")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnAll")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecuteAll")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnDecrease")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "SetGearForDrop")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "SetGearForHarvest")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToContainer")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void DropGear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[CallsUnknownMethods(Count = 1)]
	private void HarvestGear()
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToContainerItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateStackable")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void TransferGearInventoryToContainer()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(Container), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToInventoryItem")]
	public void TransferGearContainerToInventory()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_PickUnits()
	{
	}
}
