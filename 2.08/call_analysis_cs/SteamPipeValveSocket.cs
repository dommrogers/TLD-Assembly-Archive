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
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetGuid()
	{
		return null;
	}

	[Calls(Type = typeof(SteamPipeValveSocket), Member = "MaybeShowFrozenValveSocket")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "MaybeShowFrozenValveSocket")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	public void InitializeInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "UpdateInteraction")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	private string GetHoverText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "InitializeInteraction")]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "Hide")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HasValveHandleInInventory")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void ShowHoverButtonPrompts()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "Show")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HasValveHandleInInventory")]
	public void PerformInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "Hide")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	public void HideInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HideInteraction")]
	private void OnCancel()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 5)]
	private bool HasValveHandleInInventory(Inventory inventory)
	{
		return default(bool);
	}

	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HideInteraction")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	private void HandleInteractionChoice(int choice)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SteamPipeValveManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "MaybeShowFrozenValveSocket")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Start")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
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

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	private void OnValveActivateInteraction(bool activate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CallsUnknownMethods(Count = 2)]
	private void OnAttachValveComplete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	private void OnDetachValveComplete()
	{
	}

	[CallerCount(Count = 0)]
	public SteamPipeValveSocket()
	{
	}
}
