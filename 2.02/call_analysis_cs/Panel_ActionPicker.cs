using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_ActionPicker : Panel_Base
{
	public class ActionPickerItemData
	{
		public string m_SpriteName;

		public string m_LocID;

		public Action m_Callback;

		[DeduplicatedMethod]
		[CallerCount(Count = 34)]
		public ActionPickerItemData(string spriteName, string locID, Action callback)
		{
		}
	}

	public delegate void OnCancelDelegate();

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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "EnableWithCurrentList")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	public GameObject GetObjectInteractedWith()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ShowActionPicker(GameObject interactionObject)
	{
	}

	[CalledBy(Type = typeof(RockCache), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "OnCancel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CookingSlot), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(WolfDen), Member = "ProcessInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCampFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void ShowActionPicker(GameObject interactionObject, IEnumerable<ActionPickerItemData> itemData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "RemoveAllDelegates")]
	private void ResetActionPicker()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Fire), Member = "remove_OnFireStateChanged")]
	[Calls(Type = typeof(Fire), Member = "remove_OnFireStateChanged")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[CallsUnknownMethods(Count = 22)]
	[CallerCount(Count = 1)]
	private void RemoveAllDelegates()
	{
	}

	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCampFire")]
	public void UpdatePanelContent()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(Fire), Member = "add_OnFireStateChanged")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddFeedFireActions")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "DidUseFireToLightHeldTorch")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[Calls(Type = typeof(WoodStove), Member = "FireBurningInside")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddLightFireActions")]
	private void MaybeUpdateWoodStove()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddLightFireActions")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "DidUseFireToLightHeldTorch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddFeedFireActions")]
	private void MaybeUpdateCampFire()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void MaybeUpdateCookingPotItem()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerHoldingTorchThatCanBeLit")]
	[Calls(Type = typeof(Panel_TorchLight), Member = "SetFireSourceToLightTorch")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCampFire")]
	[CallsUnknownMethods(Count = 5)]
	private bool DidUseFireToLightHeldTorch(Fire fire)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(Fire), Member = "add_OnFireStateChanged")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(CookingSlot), Member = "CanBeInteractedWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingSlotActions")]
	private void MaybeUpdateCookingSlot()
	{
	}

	[Calls(Type = typeof(Fire), Member = "HasAttachedCookables")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCampFire")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 63)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	private void AddLightFireActions(Fire fire)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "CanTakeTorch")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCampFire")]
	[CallsUnknownMethods(Count = 61)]
	private void AddFeedFireActions(Fire fire)
	{
	}

	[CallsUnknownMethods(Count = 45)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingPotItem")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	private void AddCookingPotActions()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[CallsUnknownMethods(Count = 30)]
	private void AddCookingSlotActions()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[CallsUnknownMethods(Count = 2)]
	public void PreviousItem()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	public void NextItem()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ActionPickerItem), Member = "OnClick")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelection")]
	[CallsUnknownMethods(Count = 2)]
	public void OnSelect(int indexSelected)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void RefreshVisuals()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private T GetComponentFromInteractedObject<T>() where T : MonoBehaviour
	{
		return null;
	}

	[Calls(Type = typeof(Panel_ActionPicker), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void UpdateGamepadSelection()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "NextItem")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelection")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "PreviousItem")]
	private void UpdateGamepadSelectedItem()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(ActionPickerItem), Member = "Setup")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[CallsUnknownMethods(Count = 39)]
	private void EnableWithCurrentList()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ProcessWoodStoveInteraction")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessCampfireInteraction")]
	private void FireInteractCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CallsUnknownMethods(Count = 2)]
	private void FireCookCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CallsUnknownMethods(Count = 2)]
	private void FireWaterCallback()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetFireContainer")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void TakeCharcoalCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetFireContainer")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CallsUnknownMethods(Count = 2)]
	private void TakeTorchCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsUnknownMethods(Count = 10)]
	private void DismantleFireCallback()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetFireContainer")]
	private void DismantleFireCompleteCallback(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsUnknownMethods(Count = 6)]
	private void CookingPotPickUpCallback()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void CookingPotCookCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[CallsUnknownMethods(Count = 8)]
	private void CookingPotWaterCallback()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void CookingSlotCookCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CallsUnknownMethods(Count = 8)]
	private void CookingSlotWaterCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public Panel_ActionPicker()
	{
	}
}
