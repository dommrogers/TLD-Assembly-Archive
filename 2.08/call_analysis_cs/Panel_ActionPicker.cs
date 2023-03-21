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

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "EnableWithCurrentList")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[CallsUnknownMethods(Count = 1)]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GameObject GetObjectInteractedWith()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void ShowActionPicker(GameObject interactionObject)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[CalledBy(Type = typeof(WolfDen), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingSlot), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(FireplaceInteraction), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "ShowActionPanel")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "OnCancel")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 2)]
	public void ShowActionPicker(GameObject interactionObject, IEnumerable<ActionPickerItemData> itemData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "RemoveAllDelegates")]
	[CallerCount(Count = 2)]
	private void ResetActionPicker()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveAllDelegates()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
	public void UpdatePanelContent()
	{
	}

	[Calls(Type = typeof(Fire), Member = "add_OnFireStateChanged")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddLightFireActions")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddFeedFireActions")]
	private void MaybeUpdateFireplaceInteraction()
	{
	}

	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybeUpdateCookingPotItem()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CookingSlot), Member = "CanCookingSlotBeUsed")]
	[Calls(Type = typeof(Fire), Member = "add_OnFireStateChanged")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeUpdateCookingSlot()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
	[Calls(Type = typeof(Fire), Member = "HasAttachedCookables")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	private void AddLightFireActions(Fire fire)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Fire), Member = "CanTakeTorch")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void AddFeedFireActions(Fire fire)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingPotItem")]
	[CallsUnknownMethods(Count = 4)]
	private void AddCookingPotActions()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void PreviousItem()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void NextItem()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ActionPickerItem), Member = "OnClick")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelection")]
	[CallsUnknownMethods(Count = 2)]
	public void OnSelect(int indexSelected)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void RefreshVisuals()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private T GetComponentFromInteractedObject<T>() where T : MonoBehaviour
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "OnSelect")]
	private void UpdateGamepadSelection()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "PreviousItem")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "NextItem")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelection")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateGamepadSelectedItem()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActionPickerItem), Member = "Setup")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CallsUnknownMethods(Count = 1)]
	private void FireWaterCallback()
	{
	}

	[Calls(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void TakeCharcoalCallback()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetFireplaceInteraction")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
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
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCallback")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[Calls(Type = typeof(FireManager), Member = "RemoveFire")]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetFireplaceInteraction")]
	private void DismantleFireCompleteCallback(bool success, bool playerCancel, float progress)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CallsUnknownMethods(Count = 1)]
	private void CookingSlotCookCallback()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
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
