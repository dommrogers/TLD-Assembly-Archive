using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SteamPipeValveSocket : MonoBehaviour
{
	private const int HANDLE_INTERACTION = 0;

	private const int SOCKET_INTERACTION = 1;

	public SteamPipe m_SteamPipe;

	public SteamPipeValve m_SteamPipeValve;

	public LocalizedString m_LocalizedDisplayName;

	public Collider m_SocketCollider;

	public Collider m_AttachedHandleCollider;

	public List<GearItem> m_RequiredGearItems;

	public List<GearItem> m_RemoveFromInventory;

	public List<GearItem> m_ReturnToInventory;

	public bool m_SteamPipeValveActive;

	public bool m_SetOpenStateOnDismantle;

	public bool m_IsOpenOnDismantle;

	public bool m_CanDismantle;

	public bool m_CanDismantleWhenFrozen;

	public bool m_CanAttachWhenFrozen;

	public bool m_AttachAndOpen;

	public bool m_AutomaticAttach;

	public GameObject m_FrozenValveSocket;

	public GameObject m_UnfrozenValveSocket;

	public AnimatedInteraction m_AttachValveInteraction;

	public AnimatedInteraction m_DetachValveInteraction;

	private string m_Guid;

	private bool m_MaybeFrozen;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetGuid()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "MaybeShowFrozenValveSocket")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "MaybeShowFrozenValveSocket")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "Hide")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HasValveHandleInInventory")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeUpdateFrozenState")]
	public void ShowHoverButtonPrompts()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnCancel")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "Hide")]
	public void HideHoverButtonPrompts()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "Show")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeUpdateFrozenState")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HasValveHandleInInventory")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HideHoverButtonPrompts")]
	private void OnCancel()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	private bool HasValveHandleInInventory(Inventory inventory)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ProcessInteraction")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HideHoverButtonPrompts")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	private void HandleInteractionChoice(int choice)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SteamPipeValveManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SteamPipeValveManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "MaybeShowFrozenValveSocket")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Start")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void MaybeShowFrozenValveSocket()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnAttachValveComplete")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnDetachValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	private void SetSteamPipeValveActive(bool active)
	{
	}

	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void OnValveActivateInteraction(bool activate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CallsUnknownMethods(Count = 4)]
	private void OnAttachValveComplete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	private void OnDetachValveComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SteamPipeValveSocket()
	{
	}
}
