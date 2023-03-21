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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(InputManager), Member = "GetKeyDown")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryEquipPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ExitInterface()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnAll()
	{
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecuteAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Container), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TakeWater")]
	[Calls(Type = typeof(Panel_PickWater), Member = "DropWater")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	public void OnExecuteAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnIncrease()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnDecrease()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnowDown")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnDecrease")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float ReduceToNearestDeltaMultiple(float numLiters)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetDeltaLiters()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	public void SetWaterSupplyForDrop(WaterSupply ws)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessWaterSourceInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	public void SetWaterSourceForTaking(WaterSource source, WaterSupply ws)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	public void SetWaterSupplyForTransferFromInventoryToContainer(WaterSupply ws, Container c)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void SetWaterSupplyForTransferFromContainerToInventory(WaterSupply ws, Container c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTakingWater()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnAll")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecuteAll")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnIncrease")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnDecrease")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "SetWaterSupplyForDrop")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "SetWaterSourceForTaking")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "SetWaterSupplyForTransferFromInventoryToContainer")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Container), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 44)]
	private void Refresh()
	{
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "DropWater")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "InstantiateWater")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InstantiateAndDropWaterBottle(GameObject prefab, float volume, LiquidQuality quality)
	{
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private GearItem InstantiateWaterSupply(GameObject prefab)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void DropWater()
	{
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void TakeWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[CallsUnknownMethods(Count = 1)]
	public void TransferAllWaterContainerToInventory(Container container, WaterSupply waterSupplyContainer)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferAllWaterContainerToInventory")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToInventoryItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void TransferWaterContainerToInventory(Container container, WaterSupply waterSupplyContainer, float liters)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CallsUnknownMethods(Count = 1)]
	public void TransferAllWaterInventoryToContainer(Container container, WaterSupply waterSupplyInventory)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferAllWaterInventoryToContainer")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Container), Member = "GetWaterSupply")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateWaterSupply")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToContainerItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public void TransferWaterInventoryToContainer(Container container, WaterSupply waterSupplyInventory, float liters)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private void OnTakeWaterComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Panel_PickWater()
	{
	}
}
