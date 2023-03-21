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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "EnableRendering")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Ignite()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[CallsUnknownMethods(Count = 2)]
	public void Ignite(string igniteAudio)
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	private void UpdateWickLit(float deltaTODMinutes)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	private void UpdateDetonate(float deltaTODMinutes)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(MoveAgent), Member = "GetRadius")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "get_radius")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeEnableNavMeshObstacle(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnIgniteComplete()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Toggle")]
	[CallsUnknownMethods(Count = 2)]
	public void IgniteDelayed()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void IgniteAfterDelay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[CallsUnknownMethods(Count = 3)]
	public void CancelIgnite()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Drop()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Rigidbody), Member = "get_angularDrag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody), Member = "get_drag")]
	public void OnCollisionStay(Collision collisionInfo)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "PerformDamageToAllInRange")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void PerformDetonation(ContactPoint[] contacts)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[Calls(Type = typeof(AiUtils), Member = "GetAisWithinRange")]
	[CallsDeduplicatedMethods(Count = 5)]
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

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[CallerCount(Count = 3)]
	public void OnDroppedInWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	public void ForceBurnout()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[DeduplicatedMethod]
	public void StopLoopingAudio()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopIgniteAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopDetonateAudio()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateDetonate")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	private void UpdateNoiseMakerAudioPosition()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateDetonate")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void Unlight()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ForceBurnout")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[CallerCount(Count = 3)]
	private void BurnOut()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "ApplyBurnAffliction")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	private void ProcessItemInHandDetonated()
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "IgniteDelayed")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "Throw")]
	[CallsUnknownMethods(Count = 1)]
	public void Toggle()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void HandleOnThrown()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Condition), Member = "MaybeShowPainEffect")]
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CallsUnknownMethods(Count = 3)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
