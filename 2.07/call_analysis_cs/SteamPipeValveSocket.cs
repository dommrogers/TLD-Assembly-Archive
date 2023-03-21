using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.Serialization;
using TLD.UI.Generics;
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

	private PanelReference<Panel_HUD> m_HUD;

	private string m_Guid;

	private bool m_MaybeFrozen;

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "MaybeShowFrozenValveSocket")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "MaybeShowFrozenValveSocket")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CallerCount(Count = 0)]
	public void InitializeInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "UpdateInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	private string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HasValveHandleInInventory")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "InitializeInteraction")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "Hide")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void ShowHoverButtonPrompts()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "Show")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HasValveHandleInInventory")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void PerformInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "Hide")]
	public void HideInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HideInteraction")]
	private void OnCancel()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	private bool HasValveHandleInInventory(Inventory inventory)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HideInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	private void HandleInteractionChoice(int choice)
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "MaybeShowFrozenValveSocket")]
	[CalledBy(Type = typeof(SteamPipeValveManager), Member = "DeserializeAll")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Deserialize")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void MaybeShowFrozenValveSocket()
	{
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Start")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnAttachValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnDetachValveComplete")]
	[CallsUnknownMethods(Count = 5)]
	private void SetSteamPipeValveActive(bool active)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void OnValveActivateInteraction(bool activate)
	{
	}

	[Calls(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	private void OnAttachValveComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDetachValveComplete()
	{
	}

	[CallerCount(Count = 0)]
	public SteamPipeValveSocket()
	{
	}
}
