using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_FireStart : Panel_AutoReferenced
{
	private delegate void OnMethod();

	private PanelReference<Panel_Confirmation> m_Confirmation;

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

	private FireplaceInteraction m_FireplaceInteraction;

	private bool m_DestroyFireplaceOnCancel;

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

	private Action m_OnDoneStartingFire;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 54)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_FireStart), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FireStart), Member = "UpdateMenuNavigation")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_FireStart), Member = "CanHarvestCharcoal")]
	[Calls(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Panel_FireStart), Member = "CanHarvestCharcoal")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateMenuNavigation()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Enable")]
	[CalledBy(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[CallerCount(Count = 3)]
	public void Refresh()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(FireplaceInteraction), Member = "AttemptToStartFire")]
	public void ShowStartFire(float delaySeconds, Action onClosePanel)
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnDoneStartingFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCancel")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void NotifyDoneStartingFire()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsEnablePending()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Enable")]
	[CallsUnknownMethods(Count = 5)]
	private void LookAtFire()
	{
	}

	[Calls(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Panel_FireStart), Member = "LookAtFire")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCompleteCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	public void SetFireplaceInteraction(FireplaceInteraction fireplaceInteraction, bool destroyOnCancel = false)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseStarter")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseStarter")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	private FireStarterItem GetSelectedFireStarter()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseTinder")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseTinder")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	private FuelSourceItem GetSelectedTinder()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseFuel")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseFuel")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshEstimatedDurationLabel")]
	private FuelSourceItem GetSelectedFuelSource()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseAccelerant")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseAccelerant")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	private FireStarterItem GetSelectedAccelerant()
	{
		return null;
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "CalculateFireStartSuccess")]
	private void RefreshChanceOfSuccessLabel()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshBaseSkillLabel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshEstimatedDurationLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshTinderLabel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	public void IncreaseStarter()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	public void DecreaseStarter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void IncreaseTinder()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[CallerCount(Count = 0)]
	public void DecreaseTinder()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void IncreaseFuel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	public void DecreaseFuel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void IncreaseAccelerant()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	public void DecreaseAccelerant()
	{
	}

	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanStartFire()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductPowderFromInventory")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "ForceBurnResearchItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowBurnResearchNotification")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	public void OnStartFire(bool skipResearchItemCheck = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FireManager), Member = "DestroyFireObject")]
	[Calls(Type = typeof(Panel_FireStart), Member = "NotifyDoneStartingFire")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDoneStartingFire(bool success)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	private void ForceBurnResearchItem()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[Calls(Type = typeof(Panel_FireStart), Member = "NotifyDoneStartingFire")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(FireManager), Member = "DestroyFireObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	public bool CanHarvestCharcoal()
	{
		return default(bool);
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCompleteCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "TakeCharcoalCallback")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	public void OnCharcoalHarvest()
	{
	}

	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterials")]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterials")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterials")]
	public static bool FilterItem(GearItem gi, FireStartMaterialType type)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool FilterItemFireStarter(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool FilterItemTinder(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static bool FilterItemFuelSource(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool FilterItemAccelerant(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FireStart), Member = "FilterItem")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshList(StartFireSelectionRow row, List<GearItem> gearList, FireStartMaterialType type)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	private void RefreshLabels()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	private bool HasDirectSunlight()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsThisKeroseneAccelerant(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallerCount(Count = 2)]
	public bool IsGunpowderAccelerant(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_FireStart()
	{
	}
}
