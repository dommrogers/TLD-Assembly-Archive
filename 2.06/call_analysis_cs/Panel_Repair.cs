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
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[Calls(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Repair), Member = "DisableProgressBar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_Repair), Member = "ToolCanRepairSelectedItem")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedRepairableItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetModifiedRepairDuration")]
	[Calls(Type = typeof(Panel_Repair), Member = "StartRepair")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 35)]
	public void OnRepair()
	{
	}

	[CallerCount(Count = 0)]
	private void SetRepairInProgress(bool on)
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnCancel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Repair), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void ExitInterface()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Repair), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_Repair), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
		return false;
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "GetChanceSuccess")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "DegradeToolUsedForRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "GetModifiedRepairDuration")]
	[CallerCount(Count = 10)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private GameObject GetSelectedTool()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "ToolCanRepairSelectedItem")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private GameObject GetSelectedRepairableItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "DegradeToolUsedForRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Repair), Member = "ToolCanRepairSelectedItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshTools()
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnNextTool")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnPrevTool")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void RefreshMaterialsTable()
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RollForRepairSuccess")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "StartRepair")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float GetChanceSuccess()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshRepairSkillLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetChanceSuccess")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetModifiedRepairDuration")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_Repair), Member = "ToolCanRepairSelectedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshChanceSuccessLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnNextTool")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnPrevTool")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 9)]
	private void RefreshLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnCancel")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DisableProgressBar()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	private void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[CallsUnknownMethods(Count = 1)]
	private void DegradeToolUsedForRepair()
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void ConsumeMaterialsUsedForRepair()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopProgressBarAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFailed")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_Repair), Member = "ConsumeMaterialsUsedForRepair")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Repair), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[Calls(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Panel_Repair), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RepairSuccessful()
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Repair), Member = "UpdateSkillAfterRepair")]
	[Calls(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateRepair()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Repair), Member = "GetChanceSuccess")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool RollForRepairSuccess()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CallerCount(Count = 3)]
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

	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetChanceSuccess")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void StartRepair(int durationMinutes, string repairAudio)
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFailed")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateSkillAfterRepair(bool success)
	{
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 3)]
	private int GetModifiedRepairDuration(Repairable r, int baseMinutes)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Repair), Member = "GetSelectedRepairableItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ToolCanRepairSelectedItem(GameObject toolObject)
	{
		return false;
	}

	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 2)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action GetCancelAction()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
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
