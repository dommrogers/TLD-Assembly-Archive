using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Harvest : Panel_Base
{
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
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Harvest), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_Harvest), Member = "UpdateHarvest")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Harvest), Member = "DisableProgressBar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 2)]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Panel_Harvest), Member = "StopProgressBar")]
	[Calls(Type = typeof(Panel_Harvest), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[Calls(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "UpdateHarvest")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[Calls(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private void HarvestSuccessful()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnAmountIncrease()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnAmountDecrease()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	public void OnHarvest()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "HarvestInProgress")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 2)]
	public bool HarvestInProgress()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Enable")]
	[Calls(Type = typeof(Panel_Harvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_Harvest), Member = "StopProgressBarAudio")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	private void ExitInterface()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Harvest), Member = "StopProgressBar")]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestInProgress")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "HarvestGear")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "OnHarvest")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	public void StartHarvest(int numUnits, int durationMinutes, string harvestAudio)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private GameObject GetSelectedHarvestItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "Refresh")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void RefreshRepairProgressLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Initialize")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DisableProgressBar()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 54)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[Calls(Type = typeof(Panel_Harvest), Member = "RefreshRepairProgressLabel")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "StopProgressBar")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	private void StopProgressBarAudio()
	{
	}

	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "Update")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void UpdateHarvest()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "StopProgressBar")]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreTimeOfDay()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void AccelerateTimeOfDay(int minutes)
	{
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void MaybeReturnAmmoOrFuelToInventory(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(Panel_Harvest), Member = "RestoreTimeOfDay")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Harvest), Member = "StopProgressBarAudio")]
	private void StopProgressBar()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Panel_Harvest()
	{
	}
}
