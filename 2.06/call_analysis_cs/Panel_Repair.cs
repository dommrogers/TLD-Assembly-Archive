using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_Repair : Panel_AutoReferenced, IAccelerateTimeProvider
{
	private PanelReference<Panel_Inventory> m_Inventory;

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

	public string m_IconAccelerateTime;

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Panel_Repair), Member = "DisableProgressBar")]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[Calls(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Repair), Member = "DisableProgressBar")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	public void OnNextTool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnPrevTool()
	{
	}

	[Calls(Type = typeof(Panel_Repair), Member = "StartRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetModifiedRepairDuration")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_Repair), Member = "ToolCanRepairSelectedItem")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedRepairableItem")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnRepair()
	{
	}

	[CallerCount(Count = 0)]
	private void SetRepairInProgress(bool on)
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Update")]
	[Calls(Type = typeof(Panel_Repair), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void ExitInterface()
	{
	}

	[Calls(Type = typeof(Panel_Repair), Member = "DisableProgressBar")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Repair), Member = "RestoreTimeOfDay")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void OnCancel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetWorkbench(WorkBench wb)
	{
	}

	[CallerCount(Count = 0)]
	public bool RepairInProgress()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "GetModifiedRepairDuration")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "DegradeToolUsedForRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "GetModifiedRepairDuration")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "GetChanceSuccess")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	private GameObject GetSelectedTool()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "ToolCanRepairSelectedItem")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CallsUnknownMethods(Count = 2)]
	private GameObject GetSelectedRepairableItem()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "DegradeToolUsedForRepair")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[Calls(Type = typeof(Panel_Repair), Member = "ToolCanRepairSelectedItem")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	private void RefreshTools()
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnPrevTool")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnNextTool")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	private void RefreshMaterialsTable()
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "RollForRepairSuccess")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "StartRepair")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	private float GetChanceSuccess()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshRepairSkillLabel()
	{
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Panel_Repair), Member = "GetChanceSuccess")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetModifiedRepairDuration")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Repair), Member = "ToolCanRepairSelectedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	private void RefreshChanceSuccessLabel()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnNextTool")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnPrevTool")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	private void RefreshLabels()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Initialize")]
	private void DisableProgressBar()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	private void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DegradeToolUsedForRepair()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CallsUnknownMethods(Count = 4)]
	private void ConsumeMaterialsUsedForRepair()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	private void StopProgressBarAudio()
	{
	}

	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFailed")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Repair), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Repair), Member = "ConsumeMaterialsUsedForRepair")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	private void RepairFinished()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Repair), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	private void RepairFailed()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[Calls(Type = typeof(Panel_Repair), Member = "UpdateSkillAfterRepair")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	private void RepairSuccessful()
	{
	}

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[Calls(Type = typeof(Panel_Repair), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Repair), Member = "UpdateSkillAfterRepair")]
	private void UpdateRepair()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Repair), Member = "GetChanceSuccess")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool RollForRepairSuccess()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	private void RestoreTimeOfDay()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	private void AccelerateTimeOfDay(int minutes)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetChanceSuccess")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CallsUnknownMethods(Count = 5)]
	private void StartRepair(int durationMinutes, string repairAudio)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFailed")]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairSuccessful")]
	private void UpdateSkillAfterRepair(bool success)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	private int GetModifiedRepairDuration(Repairable r, int baseMinutes)
	{
		return default(int);
	}

	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedRepairableItem")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	private bool ToolCanRepairSelectedItem(GameObject toolObject)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 0)]
	public string GetSpriteName()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action GetCancelAction()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Panel_Repair()
	{
	}
}
