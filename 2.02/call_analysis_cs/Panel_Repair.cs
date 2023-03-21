using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Repair : Panel_Base
{
	public float m_SkillIncreaseChanceOnSuccess;

	public float m_SkillIncreaseChanceOnFailure;

	public float m_RepairTimeSeconds;

	public UITexture m_ItemBGSprite;

	public UILabel m_ItemNameLabel;

	public UILabel m_SkillLabel;

	public UILabel m_AmountLabel;

	public UILabel m_ChanceSuccessLabel;

	public UILabel m_TimeLabel;

	public HarvestRepairMaterial[] m_RequiredMaterials;

	public float m_RequiredMaterialCenteredX;

	public float m_RequiredMaterialSpacing;

	public UISlider m_Slider_RepairProgress;

	public UITexture m_ToolSprite;

	public UILabel m_ToolNameLabel;

	public UISprite m_ToolConditionSprite;

	public UILabel m_ToolConditionLabel;

	public Color m_CantRepairTextColor;

	public Color m_HighConditionColor;

	public string m_NoToolSpriteName;

	public Color m_NoToolSpriteColor;

	public Vector3 m_NoToolSpriteSizeModifier;

	public GearItem m_AutoSelectItem;

	public bool m_EnableDiaryOnExit;

	private float m_ElapsedProgressBarSeconds;

	private float m_ProgressBarTimeSeconds;

	private bool m_RepairWillSucceed;

	private bool m_RepairFailed;

	private bool m_RepairSucceeded;

	private float m_FailureAtProgressPercentage;

	private float m_ElapsedDisplayRepairOutcomeTime;

	private float m_DayLengthScaleBeforeRepair;

	private int m_SelectedToolIndex;

	private List<GameObject> m_Tools;

	private WorkBench m_Workbench;

	private uint m_ProgressBarAudio;

	private bool m_TimeAccelerated;

	private bool m_RepairInProgress;

	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Panel_Repair), Member = "DisableProgressBar")]
	[CallerCount(Count = 0)]
	public override void Initialize()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[Calls(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Panel_Repair), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnNextTool()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 2)]
	public void OnPrevTool()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetModifiedRepairDuration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(Panel_Repair), Member = "StartRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_Repair), Member = "ToolCanRepairSelectedItem")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedRepairableItem")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	public void OnRepair()
	{
	}

	[CallerCount(Count = 0)]
	private void SetRepairInProgress(bool on)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Update")]
	[Calls(Type = typeof(Panel_Repair), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Repair), Member = "StopProgressBarAudio")]
	private void ExitInterface()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Repair), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_Repair), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Repair), Member = "StopProgressBarAudio")]
	public void OnCancel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetWorkbench(WorkBench wb)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	public bool RepairInProgress()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "GetModifiedRepairDuration")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "GetModifiedRepairDuration")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "DegradeToolUsedForRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "GetChanceSuccess")]
	private GameObject GetSelectedTool()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "ToolCanRepairSelectedItem")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	private GameObject GetSelectedRepairableItem()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "DegradeToolUsedForRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Repair), Member = "ToolCanRepairSelectedItem")]
	private void RefreshTools()
	{
	}

	[CallsUnknownMethods(Count = 45)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnPrevTool")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnNextTool")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	private void RefreshMaterialsTable()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "StartRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RollForRepairSuccess")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetChanceSuccess()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshRepairSkillLabel()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Repair), Member = "GetChanceSuccess")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetModifiedRepairDuration")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Panel_Repair), Member = "ToolCanRepairSelectedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	private void RefreshChanceSuccessLabel()
	{
	}

	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnNextTool")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnPrevTool")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Refresh")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	private void RefreshLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "OnCancel")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	private void DisableProgressBar()
	{
	}

	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	private void Refresh()
	{
	}

	[Calls(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void DegradeToolUsedForRepair()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CallsUnknownMethods(Count = 14)]
	private void ConsumeMaterialsUsedForRepair()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	private void StopProgressBarAudio()
	{
	}

	[Calls(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFailed")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Panel_Repair), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_Repair), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_Repair), Member = "ConsumeMaterialsUsedForRepair")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 3)]
	private void RepairFinished()
	{
	}

	[Calls(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[Calls(Type = typeof(Panel_Repair), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	private void RepairFailed()
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Panel_Repair), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CallsUnknownMethods(Count = 5)]
	private void RepairSuccessful()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Repair), Member = "UpdateSkillAfterRepair")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Update")]
	[Calls(Type = typeof(Panel_Repair), Member = "RepairSuccessful")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	private void UpdateRepair()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Repair), Member = "GetChanceSuccess")]
	[CallsUnknownMethods(Count = 1)]
	private bool RollForRepairSuccess()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsUnknownMethods(Count = 3)]
	private void AccelerateTimeOfDay(int minutes)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetChanceSuccess")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	private void StartRepair(int durationMinutes, string repairAudio)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFailed")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairSuccessful")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	private void UpdateSkillAfterRepair(bool success)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private int GetModifiedRepairDuration(Repairable r, int baseMinutes)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedRepairableItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private bool ToolCanRepairSelectedItem(GameObject toolObject)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public Panel_Repair()
	{
	}
}
