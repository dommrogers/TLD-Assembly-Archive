using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_FireStart : Panel_Base
{
	private delegate void OnMethod();

	public GameObject m_FireContainer;

	public UILabel m_Label_BaseSkill;

	public UILabel m_Label_ChanceSuccess;

	public UILabel m_Label_EstimatedDuration;

	public UILabel m_Label_Tinder;

	public StartFireSelectionRow m_SelectStarter;

	public StartFireSelectionRow m_SelectTinder;

	public StartFireSelectionRow m_SelectFuel;

	public StartFireSelectionRow m_SelectAccelerant;

	public GameObject m_CharcoalItemPrefab;

	public float m_SecondsBetweenMove;

	public GameObject m_ButtonStartFireMouse;

	public GameObject m_ButtonHarvestCharcoalMouse;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public bool m_DestroyCampFireOnCancel;

	private int m_SelectedStarterIndex;

	private int m_SelectedTinderIndex;

	private int m_SelectedFuelIndex;

	private int m_SelectedAccelerantIndex;

	private List<GearItem> m_StarterList;

	private List<GearItem> m_TinderList;

	private List<GearItem> m_FuelList;

	private List<GearItem> m_AccelerantList;

	private FireManager m_FireManager;

	private bool m_EnablePending;

	private float m_EnableDelaySeconds;

	private float m_EnableDelayElapsed;

	private Campfire m_CampFireInstance;

	private bool m_DirtyLabels;

	private int m_FramesSinceEnabled;

	private FireStarterItem m_GunpowderAccelerant;

	private GearItem m_GunpowderGearItem;

	private FireStarterItem m_KeroseneAccelerant;

	private GearItem m_KeroseneGearItem;

	private int m_SelectedButtonIndex;

	private List<OnMethod> m_OnIncreaseDelegates;

	private List<OnMethod> m_OnDecreaseDelegates;

	private List<StartFireSelectionRow> m_StartFireSelectionRows;

	private List<List<GearItem>> m_ItemLists;

	private float m_SecondsToNextMove;

	[CallsUnknownMethods(Count = 116)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_FireStart), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_FireStart), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_FireStart), Member = "CanHarvestCharcoal")]
	[Calls(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_FireStart), Member = "CanHarvestCharcoal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateMenuNavigation()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[CalledBy(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	public void Refresh()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerAttemptToStartFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessWoodStoveInteraction")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public void EnableAfterDelay(float delaySeconds)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsEnablePending()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Enable")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void LookAtFire()
	{
	}

	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_FireStart), Member = "LookAtFire")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessCampfireInteraction")]
	[CalledBy(Type = typeof(Campfire), Member = "LaunchFireStartInterface")]
	[CallerCount(Count = 3)]
	public void SetCampFireInstance(Campfire cf, bool destroyOnCancel)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "TakeCharcoalCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCompleteCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessWoodStoveInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerAttemptToStartFire")]
	public void SetFireContainer(GameObject go)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetDefaultFireStarter(GameObject starter)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseStarter")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseStarter")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	private FireStarterItem GetSelectedFireStarter()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseTinder")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseTinder")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 5)]
	private FuelSourceItem GetSelectedTinder()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseFuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseFuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshEstimatedDurationLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	private FuelSourceItem GetSelectedFuelSource()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseAccelerant")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseAccelerant")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	private FireStarterItem GetSelectedAccelerant()
	{
		return null;
	}

	[Calls(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "CalclateFireStartSuccess")]
	private void RefreshChanceOfSuccessLabel()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void RefreshBaseSkillLabel()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	private void RefreshEstimatedDurationLabel()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshTinderLabel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 3)]
	public void IncreaseStarter()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	public void DecreaseStarter()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void IncreaseTinder()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 3)]
	public void DecreaseTinder()
	{
	}

	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void IncreaseFuel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 3)]
	public void DecreaseFuel()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void IncreaseAccelerant()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 3)]
	public void DecreaseAccelerant()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	private bool CanStartFire()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductPowderFromInventory")]
	[Calls(Type = typeof(FireManager), Member = "CalclateFireStartSuccess")]
	[Calls(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "ForceBurnResearchItem")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowBurnResearchNotification")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Campfire), Member = "TooWindyToStart")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void OnStartFire(bool skipResearchItemCheck = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	private void ForceBurnResearchItem()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCancel")]
	[Calls(Type = typeof(WoodStove), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeCloseFireContainer()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[Calls(Type = typeof(FireManager), Member = "DestroyFireObject")]
	[Calls(Type = typeof(Panel_FireStart), Member = "MaybeCloseFireContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool CanHarvestCharcoal()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCompleteCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "TakeCharcoalCallback")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Panel_FireStart), Member = "MaybeCloseFireContainer")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnCharcoalHarvest()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterials")]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterials")]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterials")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 4)]
	public bool FilterItem(GearItem gi, FireStartMaterialType type, bool fuelSourceCanInitiateFire = false)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool FilterItemFireStarter(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	private bool FilterItemTinder(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private bool FilterItemFuelSource(GearItem gi, bool canInitiateFire)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool FilterItemAccelerant(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CallsUnknownMethods(Count = 64)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FireStart), Member = "FilterItem")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshList(StartFireSelectionRow row, List<GearItem> gearList, FireStartMaterialType type)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshTinderLabel")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshEstimatedDurationLabel")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void RefreshLabels()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	private bool HasDirectSunlight()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	public bool IsThisKeroseneAccelerant(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsGunpowderAccelerant(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 63)]
	public Panel_FireStart()
	{
	}
}
