using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_Harvest : Panel_AutoReferenced, IAccelerateTimeProvider
{
	private PanelReference<Panel_Inventory> m_Inventory;

	public float m_HarvestTimeSeconds;

	public UITexture m_ItemBGSprite;

	public UILabel m_ItemNameLabel;

	public GameObject m_AmountObject;

	public UILabel m_AmountLabel;

	public GameObject m_TimeObject;

	public UILabel m_TimeLabel;

	public HarvestRepairMaterial[] m_HarvestYields;

	public float m_HarvestYieldCenteredX;

	public float m_HarvestYieldSpacing;

	public string m_IconAccelerateTime;

	public bool m_EnableDiaryOnExit;

	private float m_ElapsedProgressBarSeconds;

	private float m_ProgressBarTimeSeconds;

	private float m_FailureAtProgressPercentage;

	private float m_ElapsedDisplayRepairOutcomeTime;

	private float m_DayLengthScaleBeforeRepair;

	public GameObject m_Label_RepairProgress;

	public GameObject m_Progress_Repair;

	public GearItem m_AutoSelectItem;

	private int m_SelectedHarvestItemIndex;

	private GameObject m_HarvestItem;

	private uint m_ProgressBarAudio;

	private bool m_TimeAccelerated;

	private bool m_HarvestInProgress;

	private int m_NumUnitsToHarvest;

	private int m_NumUnitsLeftToHarvest;

	private Vector3 m_TimeObjectOrigPos;

	[Calls(Type = typeof(Panel_Harvest), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Harvest), Member = "StopProgressBar")]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestInProgress")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Harvest), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "UpdateHarvest")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[Calls(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Harvest), Member = "StopProgressBar")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Panel_Harvest), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	private void HarvestSuccessful()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnAmountIncrease()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnAmountDecrease()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 3)]
	public void OnHarvest()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteSurvivalPanelAction")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "IsAcceleratingTime")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "OnCancel")]
	public bool HarvestInProgress()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[Calls(Type = typeof(Panel_Harvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	private void ExitInterface()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Harvest), Member = "StopProgressBar")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestInProgress")]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "HarvestGear")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "OnHarvest")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	public void StartHarvest(int numUnits, int durationMinutes, string harvestAudio)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private GameObject GetSelectedHarvestItem()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void RefreshRepairProgressLabel()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DisableProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[Calls(Type = typeof(Panel_Harvest), Member = "RefreshRepairProgressLabel")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void Refresh()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	private void StopProgressBarAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateHarvest()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "StopProgressBar")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsUnknownMethods(Count = 1)]
	private void AccelerateTimeOfDay(int minutes)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	private void MaybeReturnAmmoOrFuelToInventory(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Harvest), Member = "RestoreTimeOfDay")]
	private void StopProgressBar()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestInProgress")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsAcceleratingTime()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetActionText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public string GetSpriteName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UIPanel GetPanelToFade()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIWidget GetWidgetToFade()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Action GetCancelAction()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void StartAcceleratingTime()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void StopAcceleratingTime()
	{
	}

	[CallerCount(Count = 0)]
	public Panel_Harvest()
	{
	}
}
