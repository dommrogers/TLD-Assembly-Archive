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
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 23)]
	public override void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Disable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Enable(MillingMachine machine)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(Panel_Milling), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Milling), Member = "Interrupt")]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Milling), Member = "BeginRepair")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnRepair()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void OnScrollbarChanged()
	{
	}

	[CalledBy(Type = typeof(MillingMachine), Member = "ProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public bool DetermineRepairables()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void OnGearItemDisplayClicked(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void ApplyCondition(float percent)
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "OnRepair")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Milling), Member = "RollForRepairSuccess")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void BeginRepair()
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "UpdateRepair")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[Calls(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Milling), Member = "EndRepair")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void CompleteRepair()
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetMaterials")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	private void ConsumeMaterials(float progress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private float DetermineConditionImprovement(SkillType skill)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void EndRepair()
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	private void GetMaterials(out GearItem[] mats, out int[] units, bool adjustForProgress)
	{
		mats = null;
		units = null;
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "BeginRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "GetMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallerCount(Count = 9)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetSelected()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Milling), Member = "HandleMenuMovement")]
	[Calls(Type = typeof(Panel_Milling), Member = "OnRepair")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(Panel_Milling), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void HandleInput()
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void HandleMenuMovement(float movement)
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "GetMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GearInInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private bool HasEnoughMaterials()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "Disable")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "UpdateRepair")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "EndRepair")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(Panel_Milling), Member = "Disable")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void Interrupt()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	private void RefreshAll()
	{
	}

	[CalledBy(Type = typeof(MillingMachine), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnScrollbarChanged")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "EndRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleMenuMovement")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshAll")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GearItemDisplay), Member = "Setup")]
	[Calls(Type = typeof(GearItemDisplay), Member = "SetSelected")]
	[Calls(Type = typeof(GearItemDisplay), Member = "Clear")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void RefreshList()
	{
	}

	[CalledBy(Type = typeof(MillingMachine), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnScrollbarChanged")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnGearItemDisplayClicked")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "EndRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleMenuMovement")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshAll")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Utils), Member = "FormatDisplayTimeMinutes")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[Calls(Type = typeof(GearItemDisplay), Member = "SetSelected")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 36)]
	private void RefreshSelected()
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "GetMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 34)]
	private void RefreshRequiredMaterials(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "BeginRepair")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private bool RollForRepairSuccess(SkillType skill)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[Calls(Type = typeof(Panel_Milling), Member = "Interrupt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateRepair()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public Panel_Milling()
	{
	}
}
