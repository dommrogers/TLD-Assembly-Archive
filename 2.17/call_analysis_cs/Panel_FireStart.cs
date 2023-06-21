using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
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

	private PowderType m_Gunpowder;

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

	public PowderType GunpowderType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 54)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_FireStart), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(Panel_FireStart), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 9)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[Calls(Type = typeof(Panel_FireStart), Member = "CanHarvestCharcoal")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Panel_FireStart), Member = "CanHarvestCharcoal")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateMenuNavigation()
	{
	}

	[CalledBy(Type = typeof(MatchesItem), Member = "PutOut")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Enable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	[CallsUnknownMethods(Count = 1)]
	public void Refresh()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(FireplaceInteraction), Member = "AttemptToStartFire")]
	[CallerCount(Count = 1)]
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
		return false;
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Enable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void LookAtFire()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_FireStart), Member = "LookAtFire")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCompleteCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[CallerCount(Count = 2)]
	public void SetFireplaceInteraction(FireplaceInteraction fireplaceInteraction, bool destroyOnCancel = false)
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseStarter")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseStarter")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private FireStarterItem GetSelectedFireStarter()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseTinder")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseTinder")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private FuelSourceItem GetSelectedTinder()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshEstimatedDurationLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseFuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseFuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private FuelSourceItem GetSelectedFuelSource()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseAccelerant")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseAccelerant")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private FireStarterItem GetSelectedAccelerant()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FireManager), Member = "CalculateFireStartSuccess")]
	[Calls(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshChanceOfSuccessLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshBaseSkillLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshEstimatedDurationLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshTinderLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void IncreaseStarter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void DecreaseAccelerant()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanStartFire()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "ForceBurnResearchItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFireStarter")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedTinder")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedAccelerant")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(Panel_FireStart), Member = "HasDirectSunlight")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowBurnResearchNotification")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductPowderFromInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(FireManager), Member = "DestroyFireObject")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[Calls(Type = typeof(Panel_FireStart), Member = "NotifyDoneStartingFire")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateMenuNavigation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanHarvestCharcoal()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "TakeCharcoalCallback")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCompleteCallback")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "UpdateMenuNavigation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void OnCharcoalHarvest()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterials")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static bool FilterItem(GearItem gi, FireStartMaterialType type)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool FilterItemFireStarter(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool FilterItemTinder(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool FilterItemFuelSource(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool FilterItemAccelerant(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_FireStart), Member = "FilterItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 17)]
	private void RefreshList(StartFireSelectionRow row, List<GearItem> gearList, FireStartMaterialType type)
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FireStart), Member = "GetSelectedFuelSource")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private bool HasDirectSunlight()
	{
		return false;
	}

	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsThisKeroseneAccelerant(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsGunpowderAccelerant(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_FireStart()
	{
	}
}
