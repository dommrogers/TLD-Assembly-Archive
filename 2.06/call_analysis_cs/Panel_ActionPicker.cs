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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelection")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "OnCancel")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "EnableWithCurrentList")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
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

	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "OnCancel")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "ShowActionPanel")]
	[CalledBy(Type = typeof(FireplaceInteraction), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingSlot), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
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

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	private void RemoveAllDelegates()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdatePanelContent()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Fire), Member = "add_OnFireStateChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddLightFireActions")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddFeedFireActions")]
	private void MaybeUpdateFireplaceInteraction()
	{
	}

	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybeUpdateCookingPotItem()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CookingSlot), Member = "CanCookingSlotBeUsed")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingSlotActions")]
	[Calls(Type = typeof(Fire), Member = "add_OnFireStateChanged")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CallsUnknownMethods(Count = 7)]
	private void MaybeUpdateCookingSlot()
	{
	}

	[CallsUnknownMethods(Count = 46)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
	[Calls(Type = typeof(Fire), Member = "HasAttachedCookables")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	private void AddLightFireActions(Fire fire)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "CanTakeTorch")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
	[CallsUnknownMethods(Count = 45)]
	private void AddFeedFireActions(Fire fire)
	{
	}

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingPotItem")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	private void AddCookingPotActions()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
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
	[DeduplicatedMethod]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
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
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "OnSelect")]
	private void UpdateGamepadSelection()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(ActionPickerItem), Member = "Setup")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	private void EnableWithCurrentList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private void FireInteractCallback()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private void TakeCharcoalCallback()
	{
	}

	[Calls(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetFireplaceInteraction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void TakeTorchCallback()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCompleteCallback")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void DismantleFireCallback()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCallback")]
	[Calls(Type = typeof(FireManager), Member = "RemoveFire")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetFireplaceInteraction")]
	private void DismantleFireCompleteCallback(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsUnknownMethods(Count = 2)]
	private void CookingPotPickUpCallback()
	{
	}

	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void CookingPotCookCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[CallsUnknownMethods(Count = 1)]
	private void CookingPotWaterCallback()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void CookingSlotCookCallback()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private void CookingSlotWaterCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public Panel_ActionPicker()
	{
	}
}
