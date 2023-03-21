using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class Panel_BodyHarvest : Panel_Base
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

	public ButtonLegendContainer m_ButtonLegendContainer;

	public float m_HarvestTimeSeconds;

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

	public string m_RequiredQuarterToolLocID;

	public int m_HarvestMeatMinutesPerKG;

	public int m_HarvestFrozenMeatMinutesPerKG;

	public int m_HarvestHideMinutesPerUnit;

	public int m_HarvestGutMinutesPerUnit;

	public Panel_BodyHarvest_MenuItem m_MenuItem_Meat;

	public Panel_BodyHarvest_MenuItem m_MenuItem_Hide;

	public Panel_BodyHarvest_MenuItem m_MenuItem_Gut;

	public GameObject m_Mouse_Button_Harvest;

	public GameObject m_Mouse_Button_Quarter;

	public string m_NoToolSpriteName;

	public Color m_NoToolSpriteColor;

	public Vector3 m_NoToolSpriteSize;

	public UITexture m_ToolTexture;

	public UILabel m_Label_ToolName;

	public GameObject m_ChangeToolButtons;

	public UILabel m_ToolConditionLabel;

	public UISprite m_ToolConditionIcon;

	public Color m_HighConditionColor;

	private HarvestTab m_TabSelected;

	private HarvestTab m_TabRequested;

	private float m_ElapsedProgressBarSeconds;

	private float m_ProgressBarTimeSeconds;

	private float m_FailureAtProgressPercentage;

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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 1)]
	private void RequestFadeInErrorMessage()
	{
	}

	[CallerCount(Count = 0)]
	private void RequestFadeoutError()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassTooFrozenToQuarterMessage")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CheckIfResourcesLeft")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	private void DisplayErrorMessage(string text)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateErrorMessage")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallsUnknownMethods(Count = 6)]
	private void HandleMessageErrorFadeout()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateErrorMessage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	private void HandleMessageErrorFadein()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "HandleMessageErrorFadein")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "HandleMessageErrorFadeout")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateErrorMessage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ResetErrorMessage()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisableProgressBar")]
	[CallsUnknownMethods(Count = 16)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "StopProgressBarAudio")]
	public void OnBack()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseMeatHarvest")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MakeDefaultSelections")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseGutHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseGutHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseHideHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseHideHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseMeatHarvest")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvestMenuNavigation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	private void SelectMenuItem(int index)
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnDecreaseHarvestAmount")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnIncreaseHarvestAmount")]
	private void UpdateHarvestMenuNavigation()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateControllerInputForTabs")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvestMenuNavigation")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	private void UpdateMenuNavigation()
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[CalledBy(Type = typeof(Condition_CheckPanelRequirements), Member = "OnCheck")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "CheckCompletionActionPossible")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CheckIfResourcesLeft")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	public bool CanEnable(BodyHarvest bodyHarvest)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckGearStillPlaced")]
	public bool IsCurrent(BodyHarvest bodyHarvest)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateTabs")]
	[CallerCount(Count = 0)]
	private void EnableTabs()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(PlayerManager), Member = "RestoreTransformFromLastInspection")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CallsUnknownMethods(Count = 13)]
	private void MaybeHandleGearItemPlacement(ComingFromScreenCategory comingFrom, BodyHarvest bodyHarvest, bool enable)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	private void MaybeDropDepletedItem(BodyHarvest currentBodyHarvest)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateTabs")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CollectArrows")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisableProgressBar")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnPopupClicked()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	public void OnHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanQuarter()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnTabQuarterSelected()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnTabHarvestSelected()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(BodyHarvest), Member = "GetPercentFrozen")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	public void OnQuarter()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptQuarter")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CallsUnknownMethods(Count = 5)]
	public static bool HasNoHarvestingTool()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshTitle")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(BodyHarvest), Member = "GetPercentFrozen")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	public static bool CarcassTooFrozenToHarvestBareHands(BodyHarvest bodyHarvest)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void DisplayCarcassToFrozenMessage()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	public static bool CheckIfResourcesLeft(BodyHarvest bodyHarvest)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MakeDefaultSelections")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	private void CameraPan(HarvestCarcass bodypart)
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnIncreaseHarvestAmount")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnDecreaseHarvestAmount")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnDecreaseHarvestAmount")]
	public void OnDecreaseGutHarvest()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DetermineTimeForToolBreak")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	private void StartHarvest(int durationMinutes, string harvestAudio)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DetermineTimeForToolBreak")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "AccelerateTimeOfDay")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	private void StartQuarter(int durationMinutes, string quarterAudio)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	private void DetermineTimeForToolBreak(int duration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float GetQuarterDurationMinutes()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshEstimatedTimeLabel")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[Calls(Type = typeof(Skill_CarcassHarvesting), Member = "GetHideGutHarvestTimeScale")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Skill_CarcassHarvesting), Member = "GetHideGutHarvestTimeScale")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Skill_CarcassHarvesting), Member = "GetMeatHarvestTimeScale")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshCalorieLabels")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Skill_CarcassHarvesting), Member = "GetMeatHarvestTimeScale")]
	[CallsUnknownMethods(Count = 10)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 3)]
	private void TransferMeatToQuarters(BodyHarvest[] quarterBodyHarvestArray)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[Calls(Type = typeof(BodyHarvest), Member = "RefreshCarcassSite")]
	[Calls(Type = typeof(BodyHarvest), Member = "CanSpawnCarcassSite")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BodyHarvest), Member = "HasSpawnedCarcassSite")]
	private void SpawnOrRefreshCarcassSite()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[CallsUnknownMethods(Count = 2)]
	private void SpawnQuarteringMessOnCarcassSite()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RandomRotateQuarter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "SkipSpawnChanceRollInitialDecayAndAutoEvolve")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private void SpawnQuarters()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private int CalculateNumberOfQuartersToSpawn()
	{
		return default(int);
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RandomRotateGutsOrHide")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GearItem), Member = "SkipSpawnChanceRollInitialDecayAndAutoEvolve")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	private void SpawnHideAndGutsAfterQuarter()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void MaybeCollectSpentArrows()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	[CallsUnknownMethods(Count = 5)]
	private void RandomRotateQuarter(Transform transform)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnHideAndGutsAfterQuarter")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void RandomRotateGutsOrHide(Transform transform)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(BodyHarvest), Member = "GetGearItemCondition")]
	[Calls(Type = typeof(BodyHarvest), Member = "IsGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetSingleItemWeightKG")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "GetSingleItemWeightKG")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	private void TransferMeatFromCarcassToInventory()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	private void TransferHideFromCarcassToInventory()
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	private void TransferGutFromCarcassToInventory()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	private void ApplyWearToTool()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[Calls(Type = typeof(Skill_CarcassHarvesting), Member = "ApplyHoursToSkill")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "MaybeCollectSpentArrows")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SpawnHideAndGutsAfterQuarter")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void QuarterSuccessful()
	{
	}

	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[Calls(Type = typeof(Skill_CarcassHarvesting), Member = "ApplyHoursToSkill")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "SendStatistic")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "TransferGutFromCarcassToInventory")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "TransferHideFromCarcassToInventory")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	private void HarvestSuccessful()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private bool HarvestInProgress()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	private void CleanUpOnExit()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(BodyHarvest), Member = "GetPercentFrozen")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void RefreshTitle()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshCalorieLabels")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshEstimatedTimeLabel")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	private void RefreshLabels()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	private void RefreshEstimatedTimeLabel()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	private void RefreshHarvestEstimatedCalories(float numCaloriesBurned)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshCalorieLabels()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Initialize")]
	private void DisableProgressBar()
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshCalorieLabels")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshEstimatedTimeLabel")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "HandleMessageErrorFadein")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "HandleMessageErrorFadeout")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshTitle")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RefreshTools")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "UpdateTabs")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	private void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "EnableTabs")]
	private void UpdateTabs()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CleanUpOnExit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "InterruptQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	private void StopProgressBarAudio()
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void UpdateHarvest()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "InterruptQuarter")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void UpdateQuarter()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CleanUpOnExit")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "InterruptHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "InterruptQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CallsUnknownMethods(Count = 3)]
	private void AccelerateTimeOfDay(int minutes)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "SelectMenuItem")]
	[CallsUnknownMethods(Count = 6)]
	private void MakeDefaultSelections()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(BodyHarvest), Member = "GetPercentFrozen")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsCarcassTooFrozenToQuarter()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "StopProgressBarAudio")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	private void InterruptQuarter()
	{
	}

	[Calls(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "RestoreTimeOfDay")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void InterruptHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 2)]
	public void OnToolPrev()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnToolNext()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DetermineTimeForToolBreak")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnHarvest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	private GearItem GetSelectedTool()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	private void RefreshTools()
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	private void RefreshToolSelection()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 46)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCarcassHarvesting")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	private void DisplayCarcassTooFrozenToQuarterMessage()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetTabRightPressed")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetTabLeftPressed")]
	private void UpdateControllerInputForTabs()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CollectArrows")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "ComputeBoundsFromColliders")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "ComputeBoundsFromColliders")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	private static void ComputeBoundsFromColliders(Transform t, ref Bounds b)
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "ComputeBoundsFromColliders")]
	private static void CollectArrows(BodyHarvest bh)
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Panel_BodyHarvest()
	{
	}
}
