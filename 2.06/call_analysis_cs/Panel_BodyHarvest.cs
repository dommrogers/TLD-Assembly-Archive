using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gameplay;
using TLD.SaveState;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisableProgressBar")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public override void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	public void OnBack()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvestMenuNavigation")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseMeatHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseMeatHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseHideHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseHideHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseGutHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseGutHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MakeDefaultSelections")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void SelectMenuItem(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnIncreaseHarvestAmount")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnDecreaseHarvestAmount")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateHarvestMenuNavigation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvestMenuNavigation")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateControllerInputForTabs")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateMenuNavigation()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "CheckCompletionActionPossible")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "TryPerformInteraction")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Condition_CheckPanelRequirements), Member = "OnCheck")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CheckIfResourcesLeft")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	public bool CanEnable(BodyHarvest bodyHarvest)
	{
		return false;
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckGearStillPlaced")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool IsCurrent(BodyHarvest bodyHarvest)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateTabs")]
	private void EnableTabs()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(PlayerManager), Member = "RestoreTransformFromLastInspection")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeHandleGearItemPlacement(ComingFromScreenCategory comingFrom, BodyHarvest bodyHarvest, bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeDropDepletedItem(BodyHarvest currentBodyHarvest)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "InteractWithBodyHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisableProgressBar")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateTabs")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CollectArrows")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 32)]
	public void Enable(bool enable, BodyHarvest bh, bool playBookEndAnim, ComingFromScreenCategory comingFrom)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsHarvesting()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsQuartering()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsHarvestingOrQuartering()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnPopupClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void OnHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanQuarter()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnTabQuarterSelected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnTabHarvestSelected()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassTooFrozenToQuarterMessage")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static bool HasNoHarvestingTool()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshTitle")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	public static bool CarcassTooFrozenToHarvestBareHands(BodyHarvest bodyHarvest)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[CallsUnknownMethods(Count = 3)]
	public static void DisplayCarcassToFrozenMessage()
	{
	}

	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[CallsUnknownMethods(Count = 1)]
	public static bool CheckIfResourcesLeft(BodyHarvest bodyHarvest)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MakeDefaultSelections")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private void CameraPan(HarvestCarcass bodypart)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnIncreaseHarvestAmount")]
	[CallsUnknownMethods(Count = 1)]
	public void OnIncreaseMeatHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnDecreaseHarvestAmount")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDecreaseMeatHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnIncreaseHarvestAmount")]
	[CallsUnknownMethods(Count = 1)]
	public void OnIncreaseHideHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnDecreaseHarvestAmount")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDecreaseHideHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnIncreaseHarvestAmount")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DetermineTimeForToolBreak")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void StartHarvest(int durationMinutes, string harvestAudio)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DetermineTimeForToolBreak")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void StartQuarter(int durationMinutes, string quarterAudio)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 3)]
	private void DetermineTimeForToolBreak(int duration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float GetQuarterDurationMinutes()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshEstimatedTimeLabel")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshCalorieLabels")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private float GetHarvestDurationMinutes()
	{
		return 0f;
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void TransferMeatToQuarters(BodyHarvest[] quarterBodyHarvestArray)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "HasSpawnedCarcassSite")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[Calls(Type = typeof(CarcassSite), Member = "Refresh")]
	[CallsUnknownMethods(Count = 3)]
	private void SpawnOrRefreshCarcassSite()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[CallsUnknownMethods(Count = 1)]
	private void SpawnQuarteringMessOnCarcassSite()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "SkipSpawnChanceRollInitialDecayAndAutoEvolve")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RandomRotateQuarter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void SpawnQuarters()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int CalculateNumberOfQuartersToSpawn()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 18)]
	private void SpawnHideAndGutsAfterQuarter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeCollectSpentArrows()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void RandomRotateQuarter(Transform transform)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RandomRotateGutsOrHide(Transform transform)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "IsGearItem")]
	[Calls(Type = typeof(BodyHarvest), Member = "GetGearItemCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void TransferMeatFromCarcassToInventory()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void TransferHideFromCarcassToInventory()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void TransferGutFromCarcassToInventory()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyWearToTool()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SpawnHideAndGutsAfterQuarter")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[Calls(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Skill_CarcassHarvesting), Member = "ApplyHoursToSkill")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void QuarterSuccessful()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisableProgressBar")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "TransferHideFromCarcassToInventory")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "TransferGutFromCarcassToInventory")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Skill_CarcassHarvesting), Member = "ApplyHoursToSkill")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void HarvestSuccessful()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool HarvestInProgress()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	private void CleanUpOnExit()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void RefreshTitle()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshCalorieLabels")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshTextures()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshEstimatedTimeLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshHarvestEstimatedCalories(float numCaloriesBurned)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshQuarterEstimatedCalories(float numCaloriesBurned)
	{
	}

	[CallerCount(Count = 0)]
	private bool IsTabHarvestSelected()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private bool IsTabQuarterSelected()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshCalorieLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void DisableProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateTabs")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshTitle")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshTextures")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateErrorMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void Refresh()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "EnableTabs")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateHarvest()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptQuarter")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateQuarter()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CleanUpOnExit")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "InterruptQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreTimeOfDay()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsUnknownMethods(Count = 1)]
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
		return false;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void InterruptQuarter()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnToolNext()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DetermineTimeForToolBreak")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[CallerCount(Count = 12)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetSelectedTool()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshTools()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 11)]
	private void RefreshToolSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[CallsUnknownMethods(Count = 3)]
	private void DisplayCarcassTooFrozenToQuarterMessage()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateControllerInputForTabs()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "ComputeBoundsFromColliders")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CollectArrows")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "ComputeBoundsFromColliders")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private static void ComputeBoundsFromColliders(Transform t, ref Bounds b)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "ComputeBoundsFromColliders")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private static void CollectArrows(BodyHarvest bh)
	{
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 6)]
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
	[CallsUnknownMethods(Count = 1)]
	private void RequestFadeInErrorMessage()
	{
	}

	[CallerCount(Count = 0)]
	private void RequestFadeoutError()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CheckIfResourcesLeft")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassTooFrozenToQuarterMessage")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DisplayErrorMessage(string text)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void HandleMessageErrorFadeout()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void HandleMessageErrorFadein()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateErrorMessage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
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
