using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WildlifeItem : MonoBehaviour
{
	private LocalizedString m_LocalizedDisplayName;

	private string m_KillAudio;

	private string m_PickUpAudio;

	private string m_ReleaseAudio;

	private GearItem m_GearItem;

	private BaseAi m_BaseAi;

	private bool m_PickedUp;

	private PlayerControlMode m_ControlModeAtTimeOfPickup;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanInteract()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(WildlifeItem), Member = "DisableAI")]
	[Calls(Type = typeof(WildlifeItem), Member = "DisableRendering")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[Calls(Type = typeof(BaseAi), Member = "SpawnCarcassPickup")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public GearItem SpawnCarcass()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(WildlifeItem), Member = "IsActionAllowed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	public void StartKillAnimation()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(WildlifeItem), Member = "IsActionAllowed")]
	[CallerCount(Count = 1)]
	public void StartReleaseAnimation()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 6)]
	private void DisableAI()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void DisablePhysics()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(WildlifeItem), Member = "ProcessInteraction")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void DisableRendering()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallsUnknownMethods(Count = 6)]
	private void EnableAI()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void EnablePhysics()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallsUnknownMethods(Count = 11)]
	private void EnableRendering()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "StartKillAnimation")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "StartReleaseAnimation")]
	private bool IsActionAllowed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(WildlifeItem), Member = "ResetControls")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	private void OnKilled()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(WildlifeItem), Member = "Update")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(WildlifeItem), Member = "EnableAI")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WildlifeItem), Member = "EnableRendering")]
	[Calls(Type = typeof(WildlifeItem), Member = "ResetControls")]
	[CallsDeduplicatedMethods(Count = 5)]
	private void OnReleased()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CallsUnknownMethods(Count = 6)]
	private void ResetControls()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public WildlifeItem()
	{
	}
}
