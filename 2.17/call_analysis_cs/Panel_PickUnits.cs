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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override void Enable(bool enable)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	private void ExitInterface()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "ExitInterface")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	public void OnAll()
	{
	}

	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecuteAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "DropGear")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 2)]
	public void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnDecrease()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	public void SetGearForDrop(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	public void SetGearForHarvest(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	public void SetGearForTransferToContainer(GearItem gi, Container c)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CallerCount(Count = 2)]
	public void SetGearForTransferToInventory(GearItem gi, Container c)
	{
	}

	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnAll")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecuteAll")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnIncrease")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnDecrease")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "SetGearForDrop")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "SetGearForHarvest")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToContainer")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Refresh()
	{
	}

	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[CallsUnknownMethods(Count = 2)]
	private void DropGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[CallsUnknownMethods(Count = 1)]
	private void HarvestGear()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(StackableItem), Member = "GetStackCondition")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToContainerItem")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateStackable")]
	[Calls(Type = typeof(GearItem), Member = "set_CurrentHP")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public void TransferGearInventoryToContainer()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(StackableItem), Member = "GetStackCondition")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(Container), Member = "DestroyGear")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void TransferGearContainerToInventory()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_PickUnits()
	{
	}
}
