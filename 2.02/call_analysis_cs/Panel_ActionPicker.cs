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
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "EnableWithCurrentList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	public GameObject GetObjectInteractedWith()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ShowActionPicker(GameObject interactionObject)
	{
	}

	[CalledBy(Type = typeof(WolfDen), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(CookingSlot), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(RockCache), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "OnCancel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCampFire")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "GetComponentFromInteractedObject")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void ShowActionPicker(GameObject interactionObject, IEnumerable<ActionPickerItemData> itemData)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "RemoveAllDelegates")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ResetActionPicker()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ResetActionPicker")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "remove_OnFireStateChanged")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	private void RemoveAllDelegates()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCampFire")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "GetComponentFromInteractedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdatePanelContent()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "GetComponentFromInteractedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(WoodStove), Member = "FireBurningInside")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddLightFireActions")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "DidUseFireToLightHeldTorch")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddFeedFireActions")]
	[Calls(Type = typeof(Fire), Member = "add_OnFireStateChanged")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeUpdateWoodStove()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "GetComponentFromInteractedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "DidUseFireToLightHeldTorch")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddFeedFireActions")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddLightFireActions")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void MaybeUpdateCampFire()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "GetComponentFromInteractedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingPotActions")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeUpdateCookingPotItem()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCampFire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerHoldingTorchThatCanBeLit")]
	[Calls(Type = typeof(Panel_TorchLight), Member = "SetFireSourceToLightTorch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private bool DidUseFireToLightHeldTorch(Fire fire)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "GetComponentFromInteractedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingSlot), Member = "CanBeInteractedWith")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "AddCookingSlotActions")]
	[Calls(Type = typeof(Fire), Member = "add_OnFireStateChanged")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeUpdateCookingSlot()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCampFire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	[Calls(Type = typeof(Fire), Member = "HasAttachedCookables")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 63)]
	private void AddLightFireActions(Fire fire)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCampFire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "CanTakeTorch")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 61)]
	private void AddFeedFireActions(Fire fire)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingPotItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 45)]
	private void AddCookingPotActions()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 30)]
	private void AddCookingSlotActions()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PreviousItem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void NextItem()
	{
	}

	[CalledBy(Type = typeof(ActionPickerItem), Member = "OnClick")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void OnSelect(int indexSelected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshVisuals()
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdatePanelContent")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCampFire")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingPotItem")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private T GetComponentFromInteractedObject<T>() where T : MonoBehaviour
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelectedItem")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "OnSelect")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateGamepadSelection()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "PreviousItem")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "NextItem")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "UpdateGamepadSelection")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateGamepadSelectedItem()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(ActionPickerItem), Member = "Setup")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 39)]
	private void EnableWithCurrentList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessCampfireInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessWoodStoveInteraction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void FireInteractCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void FireCookCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void FireWaterCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetFireContainer")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void TakeCharcoalCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetFireContainer")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void TakeTorchCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void DismantleFireCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Fire), Member = "GetAvailableCharcoalPieces")]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetFireContainer")]
	[Calls(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void DismantleFireCompleteCallback(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void CookingPotPickUpCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void CookingPotCookCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void CookingPotWaterCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void CookingSlotCookCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void CookingSlotWaterCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public Panel_ActionPicker()
	{
	}
}
