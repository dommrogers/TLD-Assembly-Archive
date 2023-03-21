using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Milling : Panel_Base
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

	public ButtonLegendContainer m_ButtonLegendContainer;

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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 23)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Update()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CallsUnknownMethods(Count = 2)]
	public void Disable()
	{
	}

	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Enable(MillingMachine machine)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(Panel_Milling), Member = "Disable")]
	public void OnBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Milling), Member = "Interrupt")]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Milling), Member = "BeginRepair")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void OnRepair()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnScrollbarChanged()
	{
	}

	[CalledBy(Type = typeof(MillingMachine), Member = "ProcessInteraction")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CallsUnknownMethods(Count = 15)]
	public bool DetermineRepairables()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnGearItemDisplayClicked(int index)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CallsUnknownMethods(Count = 6)]
	private void ApplyCondition(float percent)
	{
	}

	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnRepair")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "RollForRepairSuccess")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void BeginRepair()
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Milling), Member = "EndRepair")]
	[Calls(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "UpdateRepair")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	private void CompleteRepair()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetMaterials")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	private void ConsumeMaterials(float progress)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	private float DetermineConditionImprovement(SkillType skill)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[CallerCount(Count = 2)]
	private void EndRepair()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void GetMaterials(out GearItem[] mats, out int[] units, bool adjustForProgress)
	{
		mats = null;
		units = null;
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "GetMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnRepair")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "BeginRepair")]
	private GearItem GetSelected()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Milling), Member = "Disable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(Panel_Milling), Member = "OnRepair")]
	[Calls(Type = typeof(Panel_Milling), Member = "HandleMenuMovement")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	private void HandleInput()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	private void HandleMenuMovement(float movement)
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetMaterials")]
	private bool HasEnoughMaterials()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "UpdateRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Disable")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Milling), Member = "Disable")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(Panel_Milling), Member = "EndRepair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	private void Interrupt()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	private void RefreshAll()
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "OnScrollbarChanged")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "EndRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(MillingMachine), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshAll")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleMenuMovement")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItemDisplay), Member = "Setup")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GearItemDisplay), Member = "Clear")]
	[Calls(Type = typeof(GearItemDisplay), Member = "SetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 7)]
	private void RefreshList()
	{
	}

	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MillingMachine), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnScrollbarChanged")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnGearItemDisplayClicked")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "EndRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleMenuMovement")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshAll")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(GearItemDisplay), Member = "SetSelected")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Utils), Member = "FormatDisplayTimeMinutes")]
	private void RefreshSelected()
	{
	}

	[Calls(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetMaterials")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	private void RefreshRequiredMaterials(GearItem gearItem)
	{
	}

	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "BeginRepair")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	private bool RollForRepairSuccess(SkillType skill)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[Calls(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateRepair()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Panel_Milling()
	{
	}
}
