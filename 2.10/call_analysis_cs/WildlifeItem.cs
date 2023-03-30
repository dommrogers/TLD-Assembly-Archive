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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(WildlifeItem), Member = "DisableAI")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(WildlifeItem), Member = "DisableRendering")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void PickupWildlifeItem()
	{
	}

	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = "PerformInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(BaseAi), Member = "SpawnCarcassPickup")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public GearItem SpawnCarcass()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WildlifeItem), Member = "IsActionAllowed")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StartKillAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WildlifeItem), Member = "IsActionAllowed")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void StartReleaseAnimation()
	{
	}

	[CalledBy(Type = typeof(WildlifeItem), Member = "PickupWildlifeItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void DisableAI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private void DisablePhysics()
	{
	}

	[CalledBy(Type = typeof(WildlifeItem), Member = "PickupWildlifeItem")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void DisableRendering()
	{
	}

	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void EnableAI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private void EnablePhysics()
	{
	}

	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void EnableRendering()
	{
	}

	[CalledBy(Type = typeof(WildlifeItem), Member = "StartKillAnimation")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "StartReleaseAnimation")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsActionAllowed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WildlifeItem), Member = "ResetControls")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[CallsUnknownMethods(Count = 1)]
	private void OnKilled()
	{
	}

	[CalledBy(Type = typeof(WildlifeItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WildlifeItem), Member = "ResetControls")]
	[Calls(Type = typeof(WildlifeItem), Member = "EnableAI")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(WildlifeItem), Member = "EnableRendering")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnReleased()
	{
	}

	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ResetControls()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WildlifeItem()
	{
	}
}
