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
	[CallsUnknownMethods(Count = 6)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[Calls(Type = typeof(Utils), Member = "EnableRendering")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	public void Update()
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	private void UpdateWickLit(float deltaTODMinutes)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	private void UpdateDetonate(float deltaTODMinutes)
	{
	}

	[Calls(Type = typeof(MoveAgent), Member = "GetRadius")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NavMeshObstacle), Member = "get_radius")]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Toggle")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	public void IgniteDelayed()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Rigidbody), Member = "get_angularDrag")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody), Member = "get_drag")]
	public void OnCollisionStay(Collision collisionInfo)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
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

	[Calls(Type = typeof(NoiseMakerItem), Member = "PerformDamageToAllInRange")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 6)]
	private void PerformDetonation(ContactPoint[] contacts)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(AiUtils), Member = "GetAisWithinRange")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void PrepareForThrow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[CallsUnknownMethods(Count = 1)]
	public void DestroyHeatSource()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	public void HideEffects(bool hide)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Unlight")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	public void OnDroppedInWater()
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CallerCount(Count = 0)]
	public void ForceBurnout()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateDetonate")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateNoiseMakerAudioPosition()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateDetonate")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void Unlight()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ForceBurnout")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateWickLit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	private void BurnOut()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "ApplyBurnAffliction")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSItem")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	private void ProcessItemInHandDetonated()
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "IgniteDelayed")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "Throw")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Toggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void HandleOnThrown()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
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

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	public NoiseMakerItem()
	{
	}
}
