using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AI;

public class NoiseMakerItem : MonoBehaviour
{
	public float m_WildlifeFleeRadius;

	public float m_PlayerDamageRadius;

	public float m_AIDamageRadius;

	public float m_PlayerDamageInflictionInRadius;

	public float m_AIDamageInflictionInRadius;

	public DamageSource m_DamageSource;

	public bool m_ShouldApplyDamageToPlayer;

	public float m_BurnAfflicationDamageAmount;

	public float m_BurnLifetimeMinutes;

	public float m_IgniteDelaySeconds;

	public float m_DetonateLifetimeMinutes;

	public string m_IgniteAudio;

	public string m_BurnOutAudio;

	public string m_LoopWithoutIgniteAudio;

	public string m_DetonateAudio;

	public string m_CollideAudio;

	public float m_ThrowForce;

	public float m_ThrowTorque;

	public float m_StaminaDrainPerSecond;

	public float m_ReduceLifetimeMinutesPerSwing;

	public string m_RadialSpriteName;

	public bool m_RuinedByWater;

	private NoiseMakerEffects m_Effects;

	public float velDamp;

	public float aVelDamp;

	public bool m_CanThrow;

	public bool m_IsThrowing;

	public bool m_Thrown;

	public Color m_Color;

	public NoiseMakerState m_State;

	private float m_ElapsedBurnMinutes;

	private float m_ElapsedTimeAfterDetonated;

	private HeatSource m_HeatSource;

	private uint m_IgniteAudioID;

	private uint m_DetonateAudioID;

	private float m_DragIncreaseAfterCollision;

	private bool m_RenderingDisabled;

	private float m_RenderingDisabledNumFramesLeft;

	private bool m_PlayCollisonAudio;

	private bool m_IgniteAfterDelay;

	private float m_ElapsedIgniteDelaySeconds;

	private float m_IgniteDelay;

	private GearItem m_GearItem;

	private Rigidbody m_Rigidbody;

	private bool m_IgitePending;

	private NavMeshObstacle m_NavMeshObstacle;

	private static NoiseMakerSaveDataProxy m_NoiseMakerSaveDataProxy;

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[Calls(Type = typeof(Utils), Member = "EnableRendering")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	public void Update()
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Ignite()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	public void Ignite(string igniteAudio)
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	private void UpdateWickLit(float deltaTODMinutes)
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateDetonate(float deltaTODMinutes)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "get_radius")]
	[Calls(Type = typeof(MoveAgent), Member = "GetRadius")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Rigidbody), Member = "get_velocity")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	private void MaybeEnableNavMeshObstacle(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallsUnknownMethods(Count = 4)]
	private void OnIgniteComplete()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Toggle")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void IgniteDelayed()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[CallsUnknownMethods(Count = 13)]
	public void IgniteAfterDelay()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void CancelIgnite()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Drop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "StopIgniteAudio")]
	public void ForcePaused()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsWickLit()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsFresh()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsPaused()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Rigidbody), Member = "get_angularDrag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody), Member = "get_drag")]
	public void OnCollisionStay(Collision collisionInfo)
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "StopIgniteAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "PerformDamageToAllInRange")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void PerformDetonation(ContactPoint[] contacts)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(AiUtils), Member = "GetAisWithinRange")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	private void PerformDamageToAllInRange()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DisableRendering")]
	[CallsUnknownMethods(Count = 1)]
	public void DisableRendering(int numFrames)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void EnableCollisionAudio()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void PrepareForThrow()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DestroyHeatSource()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CallsUnknownMethods(Count = 5)]
	public void HideEffects(bool hide)
	{
	}

	[CallerCount(Count = 0)]
	public void ForceExtinguish()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public float GetNormalizedWickTimeLeft()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	public float GetModifiedBurnLifetimeMinutes()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	public void OnDroppedInWater()
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CallerCount(Count = 0)]
	public void ForceBurnout()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "StopIgniteAudio")]
	[DeduplicatedMethod]
	public void StopLoopingAudio()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ForcePaused")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "StopLoopingAudio")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnDestroy")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnDisable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StopAudioForEquippedItem")]
	private void StopIgniteAudio()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void StopDetonateAudio()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateDetonate")]
	private void UpdateNoiseMakerAudioPosition()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateDetonate")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "StopIgniteAudio")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	private void Unlight()
	{
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ForceBurnout")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "StopIgniteAudio")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void BurnOut()
	{
	}

	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "ApplyBurnAffliction")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSMeshID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	private void ProcessItemInHandDetonated()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "Throw")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallsUnknownMethods(Count = 9)]
	public void Toggle()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void HandleOnThrown()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Condition), Member = "MaybeShowPainEffect")]
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CallsUnknownMethods(Count = 7)]
	private void ApplyBurnAffliction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SetState(NoiseMakerState state)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "StopIgniteAudio")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "StopIgniteAudio")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NoiseMakerItem()
	{
	}
}
