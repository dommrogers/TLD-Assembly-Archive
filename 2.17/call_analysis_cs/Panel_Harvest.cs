using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
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

	private GearItem m_HarvestItem;

	private uint m_ProgressBarAudio;

	private bool m_TimeAccelerated;

	private bool m_HarvestInProgress;

	private int m_NumUnitsToHarvest;

	private int m_NumUnitsLeftToHarvest;

	private Vector3 m_TimeObjectOrigPos;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Panel_Harvest), Member = "DisableProgressBar")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestInProgress")]
	[Calls(Type = typeof(Panel_Harvest), Member = "StopProgressBar")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Harvest), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "UpdateHarvest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[Calls(Type = typeof(Panel_Harvest), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Panel_Harvest), Member = "StopProgressBar")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	private void HarvestSuccessful()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnHarvest()
	{
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "IsAcceleratingTime")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteSurvivalPanelAction")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool HarvestInProgress()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "OnCancel")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Harvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ExitInterface()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestInProgress")]
	[Calls(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Harvest), Member = "StopProgressBar")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "HarvestGear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void StartHarvest(int numUnits, int durationMinutes, string harvestAudio)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	private GearItem GetSelectedHarvestItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshRepairProgressLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DisableProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(Panel_Harvest), Member = "RefreshRepairProgressLabel")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 12)]
	private void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopProgressBarAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateHarvest()
	{
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "StopProgressBar")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsUnknownMethods(Count = 1)]
	private void AccelerateTimeOfDay(int minutes)
	{
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeReturnAmmoOrFuelToInventory(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "OnCancel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Harvest), Member = "RestoreTimeOfDay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void StopProgressBar()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestInProgress")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAcceleratingTime()
	{
		return false;
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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Action GetCancelAction()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void StopAcceleratingTime()
	{
	}

	[CallerCount(Count = 0)]
	public Panel_Harvest()
	{
	}
}
