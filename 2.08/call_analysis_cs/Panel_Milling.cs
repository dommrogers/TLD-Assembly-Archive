using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_Milling : Panel_AutoReferenced, IAccelerateTimeProvider
{
	public List<GearItemDisplay> m_ItemList;

	public GameObject m_Root;

	public Color m_RedColorToUse;

	public float m_RepairRealTimeSeconds;

	public float m_SkillIncreaseChanceOnSuccess;

	public GameObject m_ScrollbarSpawner;

	public UILabel m_ConditionLabel;

	public UISprite m_ConditionIcon;

	public UILabel m_NameLabel;

	public UILabel m_RepairAmountLabel;

	public UILabel m_RequiredMaterialHeaderLabel;

	public List<HarvestRepairMaterial> m_RequiredMaterials;

	public float m_RequiredMaterialCenteredX;

	public float m_RequiredMaterialSpacing;

	public UITexture m_SelectedImage;

	public UILabel m_SkillLabel;

	public UILabel m_SuccessLabel;

	public UILabel m_TimeRequiredLabel;

	public UILabel m_WeightLabel;

	public string m_IconAccelerateTime;

	public ButtonLegendContainer m_ButtonLegendContainer;

	private PanelReference<Panel_HUD> m_HUD;

	private bool _003Cm_MillingInProgress_003Ek__BackingField;

	private MillingMachine m_Machine;

	private List<GearItem> m_Millables;

	private int m_SelectedIndex;

	private int m_DisplayOffset;

	private uint m_AudioPlayingId;

	private float m_CompletionProgress;

	private float m_RealTimeCraftingElapsed;

	private bool m_RepairSuccess;

	private float m_StoredDayLengthScale;

	private UISlider m_Slider;

	private GameObject m_SliderRoot;

	private Color m_OriginalHeaderTint;

	private Color m_OriginalConditionTint;

	public bool m_MillingInProgress
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public override void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnBack")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	public void Disable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	public void Enable(MillingMachine machine)
	{
	}

	[Calls(Type = typeof(Panel_Milling), Member = "Disable")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	public void OnBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Milling), Member = "Interrupt")]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "BeginRepair")]
	[CallsUnknownMethods(Count = 1)]
	public void OnRepair()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void OnScrollbarChanged()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(MillingMachine), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 6)]
	public bool DetermineRepairables()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallsUnknownMethods(Count = 1)]
	protected void OnGearItemDisplayClicked(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[Calls(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	private void ApplyCondition(float percent)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnRepair")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	private void BeginRepair()
	{
	}

	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "UpdateRepair")]
	[Calls(Type = typeof(Panel_Milling), Member = "EndRepair")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[Calls(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void CompleteRepair()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetMaterials")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	private void ConsumeMaterials(float progress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[CallsUnknownMethods(Count = 2)]
	private float DetermineConditionImprovement(SkillType skill)
	{
		return default(float);
	}

	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void EndRepair()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[CallsUnknownMethods(Count = 10)]
	private void GetMaterials(out GearItem[] mats, out int[] units, bool adjustForProgress)
	{
		mats = null;
		units = null;
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "GetMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnRepair")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "BeginRepair")]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetSelected()
	{
		return null;
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Milling), Member = "OnRepair")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(Panel_Milling), Member = "Disable")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 0)]
	private void HandleInput()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 1)]
	private void HandleMenuMovement(float movement)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetMaterials")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool HasEnoughMaterials()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "UpdateRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Disable")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "EndRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Milling), Member = "Disable")]
	private void Interrupt()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	private void RefreshAll()
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "EndRepair")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleMenuMovement")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnScrollbarChanged")]
	[Calls(Type = typeof(GearItemDisplay), Member = "Setup")]
	[CalledBy(Type = typeof(MillingMachine), Member = "PerformInteraction")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GearItemDisplay), Member = "Clear")]
	[Calls(Type = typeof(GearItemDisplay), Member = "SetSelected")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Enable")]
	private void RefreshList()
	{
	}

	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GearItemDisplay), Member = "SetSelected")]
	[CalledBy(Type = typeof(MillingMachine), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnScrollbarChanged")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnGearItemDisplayClicked")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "EndRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleMenuMovement")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshAll")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(Utils), Member = "FormatDisplayTimeMinutes")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	private void RefreshSelected()
	{
	}

	[Calls(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetMaterials")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshRequiredMaterials(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 2)]
	private bool RollForRepairSuccess(SkillType skill)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[Calls(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	private void UpdateRepair()
	{
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UIPanel GetPanelToFade()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Panel_Milling()
	{
	}
}
