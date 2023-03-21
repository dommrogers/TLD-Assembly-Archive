using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_PickWater : Panel_AutoReferenced
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

	private PanelReference<Panel_Container> m_ContainerPanel;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	public string m_ProgressBarMessage
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Update()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	private void ExitInterface()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[CallerCount(Count = 0)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	public void OnAll()
	{
	}

	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecuteAll")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TakeWater")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[Calls(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	public void OnExecute()
	{
	}

	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CallerCount(Count = 0)]
	public void OnExecuteAll()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnIncrease()
	{
	}

	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickWater), Member = "ReduceToNearestDeltaMultiple")]
	public void OnDecrease()
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoilDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnowDown")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnDecrease")]
	[CallsUnknownMethods(Count = 2)]
	public static float ReduceToNearestDeltaMultiple(float numLiters)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float GetDeltaLiters()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CallsUnknownMethods(Count = 1)]
	public void SetWaterSupplyForDrop(WaterSupply ws)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CalledBy(Type = typeof(WaterSource), Member = "PerformInteraction")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTakingWater()
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnAll")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecuteAll")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnIncrease")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnDecrease")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "SetWaterSupplyForDrop")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "SetWaterSourceForTaking")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "SetWaterSupplyForTransferFromInventoryToContainer")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "DropWater")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "DropWater")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "DropWater")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateWater")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	private void InstantiateAndDropWaterBottle(GameObject prefab, float volume, LiquidQuality quality)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	private GearItem InstantiateWaterSupply(GameObject prefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[CallsUnknownMethods(Count = 2)]
	private void DropWater()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_PickWater), Member = "OnTakeWaterComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	private void TakeWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[CallsUnknownMethods(Count = 1)]
	public void TransferAllWaterContainerToInventory(Container container, WaterSupply waterSupplyContainer)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferAllWaterContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToInventoryItem")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 4)]
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
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferAllWaterInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_PickWater), Member = "InstantiateWaterSupply")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Container), Member = "GetWaterSupply")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void TransferWaterInventoryToContainer(Container container, WaterSupply waterSupplyInventory, float liters)
	{
	}

	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TakeWater")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	private void OnTakeWaterComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public Panel_PickWater()
	{
	}
}
