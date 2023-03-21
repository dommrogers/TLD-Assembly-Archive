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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "MaybeShowFrozenValveSocket")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "UpdateInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	private string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "InitializeInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HasValveHandleInInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "Hide")]
	[CallsUnknownMethods(Count = 3)]
	private void ShowHoverButtonPrompts()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HasValveHandleInInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "Show")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void PerformInteraction()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnCancel")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "Hide")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	private bool HasValveHandleInInventory(Inventory inventory)
	{
		return false;
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "HideInteraction")]
	[Calls(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CallsUnknownMethods(Count = 9)]
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

	[CalledBy(Type = typeof(SteamPipeValveManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "MaybeShowFrozenValveSocket")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Start")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeShowFrozenValveSocket()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Start")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnAttachValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnDetachValveComplete")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void SetSteamPipeValveActive(bool active)
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "SetSteamPipeValveActive")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
