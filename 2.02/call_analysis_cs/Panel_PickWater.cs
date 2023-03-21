using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_PickWater : Panel_Base
{
	public ButtonLegendContainer m_ButtonLegendContainer;

	public UILabel m_Label_Description;

	public UILabel m_Label_Title;

	public UILabel m_Label_NumUnits;

	public GameObject m_Execute_Button;

	public GameObject m_ExecuteAll_Button;

	public LocalizedString m_LocalizedProgressBarMessage;

	public float m_ProgressBarDurationSecondsBase;

	public float m_ProgressBarDurationSecondsPerLiter;

	public GameObject m_WaterBottle_1000ml;

	public GameObject m_WaterBottle_500ml;

	public GameObject m_WaterSupply_Potable;

	public GameObject m_WaterSupply_NonPotable;

	public float m_numLiters;

	public float m_maxLiters;

	public EnablePanelOnExit m_EnablePanelOnExit;

	public bool m_CameFromDrag;

	private WaterSupply m_WaterSupply;

	private WaterSource m_WaterSource;

	private Container m_Container;

	private PickWaterExecuteAction m_ExecuteAction;

	private bool m_IsTakingWater;

	public UITexture m_GearIcon;

	public GameObject m_ButtonIncrease;

	public GameObject m_ButtonDecrease;

	public string m_ProgressBarMessage
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryEquipPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(InputManager), Member = "GetKeyDown")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(InputManager), Member = "GetKeyDown")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Update")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(Panel_Container), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	private void ExitInterface()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnAll()
	{
	}

	[Calls(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecuteAll")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Update")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_PickWater), Member = "DropWater")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TakeWater")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Container), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	public void OnExecuteAll()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public void OnIncrease()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnDecrease()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnDecrease")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnowDown")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilDown")]
	public float ReduceToNearestDeltaMultiple(float numLiters)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetDeltaLiters()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	public void SetWaterSupplyForDrop(WaterSupply ws)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessWaterSourceInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public void SetWaterSourceForTaking(WaterSource source, WaterSupply ws)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	public void SetWaterSupplyForTransferFromInventoryToContainer(WaterSupply ws, Container c)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void SetWaterSupplyForTransferFromContainerToInventory(WaterSupply ws, Container c)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsTakingWater()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnAll")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecuteAll")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnIncrease")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnDecrease")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "SetWaterSupplyForDrop")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "SetWaterSourceForTaking")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "SetWaterSupplyForTransferFromInventoryToContainer")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Container), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	private void Refresh()
	{
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "DropWater")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "DropWater")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "DropWater")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateWater")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	private void InstantiateAndDropWaterBottle(GameObject prefab, float volume, LiquidQuality quality)
	{
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 5)]
	private GearItem InstantiateWaterSupply(GameObject prefab)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	private void DropWater()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	private void TakeWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[CallsUnknownMethods(Count = 1)]
	public void TransferAllWaterContainerToInventory(Container container, WaterSupply waterSupplyContainer)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferAllWaterContainerToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToInventoryItem")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	public void TransferWaterContainerToInventory(Container container, WaterSupply waterSupplyContainer, float liters)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CallsUnknownMethods(Count = 1)]
	public void TransferAllWaterInventoryToContainer(Container container, WaterSupply waterSupplyInventory)
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToContainerItem")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferAllWaterInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateWaterSupply")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Container), Member = "GetWaterSupply")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void TransferWaterInventoryToContainer(Container container, WaterSupply waterSupplyInventory, float liters)
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	private void OnTakeWaterComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public Panel_PickWater()
	{
	}
}
