using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_ActionPicker : Panel_AutoReferenced
{
	public delegate void OnCancelDelegate();

	private PanelReference<Panel_Cooking> m_Cooking;

	private PanelReference<Panel_FeedFire> m_FeedFire;

	private PanelReference<Panel_FireStart> m_FireStart;

	private PanelReference<Panel_GearSelect> m_GearSelect;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	public ActionPickerItem[] m_ActionPickerItemList;

	public UISprite m_SpriteBG;

	public UISprite m_SpriteBG_Glow;

	public float m_ActionPickerItemOffset;

	public float m_BGWidthPerItem;

	public OnCancelDelegate OnCancelCallback;

	private List<ActionPickerItemData> m_ActionPickerItemDataList;

	private int m_SelectedIndex;

	private GameObject m_ObjectInteractedWith;

	private ButtonLegendContainer m_ButtonLegendContainer;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "OnCancel")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_ActionPicker), Member = "EnableWithCurrentList")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GameObject GetObjectInteractedWith()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ShowActionPicker(GameObject interactionObject)
	{
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "OnCancel")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "ShowActionPanel")]
	[CalledBy(Type = typeof(FireplaceInteraction), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingSlot), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(WolfDen), Member = "PerformInteraction")]
	public void ShowActionPicker(GameObject interactionObject, IEnumerable<ActionPickerItemData> itemData)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "RemoveAllDelegates")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CallsUnknownMethods(Count = 1)]
	private void ResetActionPicker()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	private void RemoveAllDelegates()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdatePanelContent()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Fire), Member = "add_OnFireStateChanged")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddFeedFireActions")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddLightFireActions")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private void MaybeUpdateFireplaceInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeUpdateCookingPotItem()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingSlot), Member = "CanCookingSlotBeUsed")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Fire), Member = "add_OnFireStateChanged")]
	private void MaybeUpdateCookingSlot()
	{
	}

	[Calls(Type = typeof(Fire), Member = "HasAttachedCookables")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	private void AddLightFireActions(Fire fire)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "CanTakeTorch")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
	[CallsUnknownMethods(Count = 5)]
	private void AddFeedFireActions(Fire fire)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingPotItem")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void AddCookingPotActions()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void AddCookingSlotActions()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Update")]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	public void PreviousItem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void NextItem()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ActionPickerItem), Member = "OnClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnSelect(int indexSelected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshVisuals()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	private T GetComponentFromInteractedObject<T>() where T : MonoBehaviour
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "OnSelect")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateGamepadSelection()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelection")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "NextItem")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "PreviousItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	private void UpdateGamepadSelectedItem()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ActionPickerItem), Member = "Setup")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	private void EnableWithCurrentList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void FireInteractCallback()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	private void FireCookCallback()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void FireWaterCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CallsUnknownMethods(Count = 1)]
	private void TakeCharcoalCallback()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetFireplaceInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void TakeTorchCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCompleteCallback")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	private void DismantleFireCallback()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCallback")]
	[Calls(Type = typeof(FireManager), Member = "RemoveFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetFireplaceInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	private void DismantleFireCompleteCallback(bool success, bool playerCancel, float progress)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	private void CookingPotPickUpCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[CallsUnknownMethods(Count = 1)]
	private void CookingPotCookCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[CallsUnknownMethods(Count = 1)]
	private void CookingPotWaterCallback()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void CookingSlotCookCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CallsUnknownMethods(Count = 1)]
	private void CookingSlotWaterCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_ActionPicker()
	{
	}
}
