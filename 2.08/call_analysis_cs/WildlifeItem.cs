using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WildlifeItem : MonoBehaviour
{
	private string m_KillAudio;

	private string m_PickUpAudio;

	private string m_ReleaseAudio;

	private GearItem m_GearItem;

	private BaseAi m_BaseAi;

	private bool m_PickedUp;

	private PlayerControlMode m_ControlModeAtTimeOfPickup;

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(WildlifeItem), Member = "DisableRendering")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WildlifeItem), Member = "DisableAI")]
	public void PickupWildlifeItem()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[Calls(Type = typeof(BaseAi), Member = "SpawnCarcassPickup")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	public GearItem SpawnCarcass()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(WildlifeItem), Member = "IsActionAllowed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	public void StartKillAnimation()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WildlifeItem), Member = "IsActionAllowed")]
	public void StartReleaseAnimation()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "PickupWildlifeItem")]
	private void DisableAI()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DisablePhysics()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(WildlifeItem), Member = "PickupWildlifeItem")]
	[CallsUnknownMethods(Count = 4)]
	private void DisableRendering()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallsUnknownMethods(Count = 4)]
	private void EnableAI()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void EnablePhysics()
	{
	}

	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void EnableRendering()
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(WildlifeItem), Member = "StartKillAnimation")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "StartReleaseAnimation")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsActionAllowed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(WildlifeItem), Member = "ResetControls")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	private void OnKilled()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "Update")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(WildlifeItem), Member = "EnableAI")]
	[Calls(Type = typeof(WildlifeItem), Member = "ResetControls")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WildlifeItem), Member = "EnableRendering")]
	private void OnReleased()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void ResetControls()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WildlifeItem()
	{
	}
}
