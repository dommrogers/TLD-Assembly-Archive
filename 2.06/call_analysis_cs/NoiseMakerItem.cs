using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
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

	private PanelReference<Panel_HUD> m_HUD;

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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 11)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "EnableRendering")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	public void Ignite()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void Ignite(string igniteAudio)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWickLit(float deltaTODMinutes)
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[CallerCount(Count = 0)]
	private void UpdateDetonate(float deltaTODMinutes)
	{
	}

	[Calls(Type = typeof(NavMeshObstacle), Member = "get_radius")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(MoveAgent), Member = "GetRadius")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Rigidbody), Member = "get_velocity")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void MaybeEnableNavMeshObstacle(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallsUnknownMethods(Count = 2)]
	private void OnIgniteComplete()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Toggle")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	public void IgniteDelayed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[CallsUnknownMethods(Count = 5)]
	public void IgniteAfterDelay()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	public void CancelIgnite()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Drop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
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

	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Rigidbody), Member = "get_angularDrag")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody), Member = "get_drag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	public void OnCollisionStay(Collision collisionInfo)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "PerformDamageToAllInRange")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void PerformDetonation(ContactPoint[] contacts)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(AiUtils), Member = "GetAisWithinRange")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	private void PerformDamageToAllInRange()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ForceExtinguish()
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	public float GetNormalizedWickTimeLeft()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetModifiedBurnLifetimeMinutes()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnCollisionEnter")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	public void OnDroppedInWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	public void ForceBurnout()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void StopLoopingAudio()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void StopIgniteAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopDetonateAudio()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateDetonate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateNoiseMakerAudioPosition()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateDetonate")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 3)]
	private void Unlight()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ForceBurnout")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	private void BurnOut()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "ApplyBurnAffliction")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSItem")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	private void ProcessItemInHandDetonated()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "Throw")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallsUnknownMethods(Count = 6)]
	public void Toggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void HandleOnThrown()
	{
	}

	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[Calls(Type = typeof(Condition), Member = "MaybeShowPainEffect")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	private void ApplyBurnAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void SetState(NoiseMakerState state)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	public NoiseMakerItem()
	{
	}
}
