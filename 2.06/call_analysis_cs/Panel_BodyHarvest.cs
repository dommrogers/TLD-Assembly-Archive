using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gameplay;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_BodyHarvest : Panel_AutoReferenced, IAccelerateTimeProvider
{
	private enum HarvestAction
	{
		None,
		Harvesting,
		Quartering
	}

	private enum HarvestTab
	{
		Harvest,
		Quarter
	}

	private PanelReference<Panel_Inventory> m_Inventory;

	private BodyHarvestSettings m_Settings;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public GameObject m_Title;

	public GameObject m_Title_Frozen;

	public UILabel m_Label_Title_Frozen;

	public UILabel m_Label_Title;

	public UILabel m_Label_FrozenInfo;

	public UILabel m_Label_AmountToHarvest;

	public UILabel m_Label_QuarterEstimatedTime;

	public UILabel m_Label_QuarterEstimatedCalories;

	public GameObject m_QuarterPanel;

	public GameObject m_QuarterTabButtonLeft;

	public GameObject m_QuarterTabButtonRight;

	public UILabel m_Label_HarvestEstimatedTime;

	public UILabel m_Label_HarvestEstimatedCalories;

	public GameObject m_HarvestPanel;

	public GameObject m_HarvestTabButtonLeft;

	public GameObject m_HarvestTabButtonRight;

	public UISprite m_GamepadTabLeft_Harvest;

	public UISprite m_GamepadTabRight_Harvest;

	public UISprite m_GamepadTabLeft_Quarter;

	public UISprite m_GamepadTabRight_Quarter;

	public UILabel m_Label_CurrentCalories;

	public UILabel m_Label_CurrentCaloriesAmount;

	public UILabel m_Label_ProgressBar;

	public UIProgressBar m_ProgressBar_Harvest;

	public GameObject m_HarvestAmount_Button_Increase;

	public GameObject m_HarvestAmount_Button_Decrease;

	public UITexture m_GearItemTexture;

	public Panel_BodyHarvest_MenuItem m_MenuItem_Meat;

	public Panel_BodyHarvest_MenuItem m_MenuItem_Hide;

	public Panel_BodyHarvest_MenuItem m_MenuItem_Gut;

	public GameObject m_Mouse_Button_Harvest;

	public GameObject m_Mouse_Button_Quarter;

	public UITexture m_ToolTexture;

	public UILabel m_Label_ToolName;

	public GameObject m_ChangeToolButtons;

	public UILabel m_ToolConditionLabel;

	public UISprite m_ToolConditionIcon;

	private HarvestTab m_TabSelected;

	private HarvestTab m_TabRequested;

	private float m_ElapsedProgressBarSeconds;

	private float m_ProgressBarTimeSeconds;

	private float m_DayLengthScaleBeforeHarvest;

	private float m_MeatHarvestAmountBefore;

	private int m_HideHarvestAmountBefore;

	private int m_GutHarvestAmountBefore;

	private uint m_ProgressBarAudio;

	private bool m_TimeAccelerated;

	private const float m_QuarterPrefabSpawnHeightOffset = 1f;

	private const float m_QuarterGutsHideSpawnRadius = 0.7f;

	private const float m_QuarterGutsHideSpawnAngle = 0.26f;

	private ComingFromScreenCategory m_ComingFromScreenCategory;

	private HarvestAction m_CurrentHarvestAction;

	private float m_MinutesSpentOnMostRecentHarvest;

	private float m_TimeForToolToBreak;

	private int m_SelectedToolItemIndex;

	private int m_SelectedTabIndex;

	private BodyHarvest m_BodyHarvest;

	private int m_SelectedButtonIndex;

	private List<Panel_BodyHarvest_MenuItem> m_MenuItems;

	private List<GearItem> m_Tools;

	private bool m_PlayBookEndAnimation;

	private static Collider[] s_PossibleColliders;

	public UILabel m_Label_Error;

	public float m_ErrorDisplayDuration;

	private float m_DisplayErrorTimer;

	private float m_ErrorDisplayFadingDuration;

	private float m_FadeInStartAlpha;

	private float m_ErrorDisplayFadeOutTimer;

	private float m_ErrorDisplayFadeInTimer;

	private bool m_FadeOutErrorRequested;

	private bool m_FadeInErrorRequested;

	private bool m_DisplayErrorRequested;

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisableProgressBar")]
	[CallsUnknownMethods(Count = 14)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	public void OnBack()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseHideHarvest")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MakeDefaultSelections")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseGutHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseGutHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseHideHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseMeatHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseMeatHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvestMenuNavigation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	private void SelectMenuItem(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnDecreaseHarvestAmount")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnIncreaseHarvestAmount")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void UpdateHarvestMenuNavigation()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateControllerInputForTabs")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvestMenuNavigation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	private void UpdateMenuNavigation()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Condition_CheckPanelRequirements), Member = "OnCheck")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "TryPerformInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "CheckCompletionActionPossible")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshTools")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CheckIfResourcesLeft")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	public bool CanEnable(BodyHarvest bodyHarvest)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckGearStillPlaced")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	public bool IsCurrent(BodyHarvest bodyHarvest)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateTabs")]
	private void EnableTabs()
	{
	}

	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[Calls(Type = typeof(PlayerManager), Member = "RestoreTransformFromLastInspection")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	private void MaybeHandleGearItemPlacement(ComingFromScreenCategory comingFrom, BodyHarvest bodyHarvest, bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeDropDepletedItem(BodyHarvest currentBodyHarvest)
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "InteractWithBodyHarvest")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CollectArrows")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateTabs")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisableProgressBar")]
	public void Enable(bool enable, BodyHarvest bh, bool playBookEndAnim, ComingFromScreenCategory comingFrom)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsHarvesting()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsQuartering()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsHarvestingOrQuartering()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	public void OnPopupClicked()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void OnHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanQuarter()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	public void OnTabQuarterSelected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnTabHarvestSelected()
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassTooFrozenToQuarterMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnQuarter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptQuarter")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnCancel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool HasNoHarvestingTool()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshTitle")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	public static bool CarcassTooFrozenToHarvestBareHands(BodyHarvest bodyHarvest)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public static void DisplayCarcassToFrozenMessage()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "PerformInteraction")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static bool CheckIfResourcesLeft(BodyHarvest bodyHarvest)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MakeDefaultSelections")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void CameraPan(HarvestCarcass bodypart)
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnIncreaseHarvestAmount")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[CallsUnknownMethods(Count = 1)]
	public void OnIncreaseMeatHarvest()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnDecreaseHarvestAmount")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	public void OnDecreaseMeatHarvest()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnIncreaseHarvestAmount")]
	public void OnIncreaseHideHarvest()
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnDecreaseHarvestAmount")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	public void OnDecreaseHideHarvest()
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnIncreaseHarvestAmount")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	public void OnIncreaseGutHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnDecreaseHarvestAmount")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDecreaseGutHarvest()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DetermineTimeForToolBreak")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	private void StartHarvest(int durationMinutes, string harvestAudio)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DetermineTimeForToolBreak")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	private void StartQuarter(int durationMinutes, string quarterAudio)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	private void DetermineTimeForToolBreak(int duration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float GetQuarterDurationMinutes()
	{
		return default(float);
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshCalorieLabels")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshEstimatedTimeLabel")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	private float GetHarvestDurationMinutes()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private string GetHarvestAudio()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private string GetQuarterAudio()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private GameObject GetQuarterObjectPrefab()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void TransferMeatToQuarters(BodyHarvest[] quarterBodyHarvestArray)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "HasSpawnedCarcassSite")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CallsUnknownMethods(Count = 3)]
	private void SpawnOrRefreshCarcassSite()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SpawnQuarteringMessOnCarcassSite()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RandomRotateQuarter")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "SkipSpawnChanceRollInitialDecayAndAutoEvolve")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void SpawnQuarters()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int CalculateNumberOfQuartersToSpawn()
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CallsDeduplicatedMethods(Count = 12)]
	private void SpawnHideAndGutsAfterQuarter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeCollectSpentArrows()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	private void RandomRotateQuarter(Transform transform)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsUnknownMethods(Count = 3)]
	private void RandomRotateGutsOrHide(Transform transform)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(BodyHarvest), Member = "GetGearItemCondition")]
	[Calls(Type = typeof(BodyHarvest), Member = "IsGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	private void TransferMeatFromCarcassToInventory()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void TransferHideFromCarcassToInventory()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void TransferGutFromCarcassToInventory()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	private void ApplyWearToTool()
	{
	}

	[Calls(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[Calls(Type = typeof(Skill_CarcassHarvesting), Member = "ApplyHoursToSkill")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SpawnHideAndGutsAfterQuarter")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void QuarterSuccessful()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[Calls(Type = typeof(Skill_CarcassHarvesting), Member = "ApplyHoursToSkill")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "TransferGutFromCarcassToInventory")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "TransferHideFromCarcassToInventory")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	private void HarvestSuccessful()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool HarvestInProgress()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	private void CleanUpOnExit()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshTitle()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshCalorieLabels")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	private void RefreshLabels()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshTextures()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	private void RefreshEstimatedTimeLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshHarvestEstimatedCalories(float numCaloriesBurned)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshQuarterEstimatedCalories(float numCaloriesBurned)
	{
	}

	[CallerCount(Count = 0)]
	private bool IsTabHarvestSelected()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool IsTabQuarterSelected()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CallerCount(Count = 1)]
	private void RefreshCalorieLabels()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Initialize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	private void DisableProgressBar()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateErrorMessage")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshTextures")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshTitle")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshTools")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateTabs")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	private void Refresh()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "EnableTabs")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateTabs()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopProgressBarAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void UpdateHarvest()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptQuarter")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void UpdateQuarter()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CleanUpOnExit")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "InterruptQuarter")]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreTimeOfDay()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	private void AccelerateTimeOfDay(int minutes)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[CallsUnknownMethods(Count = 1)]
	private void MakeDefaultSelections()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsCarcassTooFrozenToQuarter()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnCancel")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	private void InterruptQuarter()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void InterruptHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnToolPrev()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnToolNext()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DetermineTimeForToolBreak")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	private GearItem GetSelectedTool()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshTools()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void RefreshToolSelection()
	{
	}

	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void DisplayCarcassTooFrozenToQuarterMessage()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void UpdateControllerInputForTabs()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CollectArrows")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "ComputeBoundsFromColliders")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "ComputeBoundsFromColliders")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	private static void ComputeBoundsFromColliders(Transform t, ref Bounds b)
	{
	}

	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "ComputeBoundsFromColliders")]
	private static void CollectArrows(BodyHarvest bh)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAcceleratingTime()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetActionText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIWidget GetWidgetToFade()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Action GetCancelAction()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
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
	[CallsUnknownMethods(Count = 1)]
	private void RequestFadeInErrorMessage()
	{
	}

	[CallerCount(Count = 0)]
	private void RequestFadeoutError()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassTooFrozenToQuarterMessage")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CheckIfResourcesLeft")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	private void DisplayErrorMessage(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void HandleMessageErrorFadeout()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void HandleMessageErrorFadein()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateErrorMessage()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void ResetErrorMessage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public Panel_BodyHarvest()
	{
	}
}
