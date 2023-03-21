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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = "PerformInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(WildlifeItem), Member = "DisableAI")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
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

	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(WildlifeItem), Member = "IsActionAllowed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void StartKillAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WildlifeItem), Member = "IsActionAllowed")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsUnknownMethods(Count = 4)]
	public void StartReleaseAnimation()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(WildlifeItem), Member = "PickupWildlifeItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void DisableAI()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	private void DisablePhysics()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EnablePhysics()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void EnableRendering()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "StartKillAnimation")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "StartReleaseAnimation")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	private bool IsActionAllowed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(WildlifeItem), Member = "ResetControls")]
	[CallerCount(Count = 0)]
	private void OnKilled()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(WildlifeItem), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(WildlifeItem), Member = "EnableAI")]
	[Calls(Type = typeof(WildlifeItem), Member = "ResetControls")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void OnReleased()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallsUnknownMethods(Count = 2)]
	private void ResetControls()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public WildlifeItem()
	{
	}
}
