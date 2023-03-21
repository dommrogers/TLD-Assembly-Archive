using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public enum ForcedMovement
	{
		None,
		ForceCrouch,
		ForceWalk,
		ForceLimp,
		ForceLimpSlow
	}

	public static bool m_UnlimitedSprint;

	public float m_MaxSlopeOutdoors;

	public float m_MaxSlopeIndoors;

	public float m_IndoorMovementSpeedMultiplier;

	public float m_RoadMovementSpeedMultiplier;

	public float m_WindMovementSpeedMultiplierMin;

	public float m_WindMovementSpeedMultiplierMax;

	public float m_MinWindSpeedToAffectMovement;

	public float m_ShallowSnowSpeedMultiplier;

	public float m_DeepSnowSpeedMultiplierMin;

	public float m_DeepSnowSpeedMultiplierMax;

	public float m_SlowLimpSpeedMultiplier;

	public float m_SlowBodyCarrySpeedMultiplier;

	public float m_DetectionRangeScaleWhenCrouched;

	public float m_FootStepRangeScaleWhenCrouched;

	public float m_FootStepRangeScaleWhenWalking;

	public float m_CrouchToStandPerceptionDelaySeconds;

	public float m_SprintStaminaRecoverPerHour;

	public float m_SprintStaminaUsagePerSecond;

	public float m_SecondsNotSprintingBeforeRecovery;

	public float m_MinFatigueToScaleStaminaRecovery;

	public float m_SprintStaminaRecoveryFatigueScale;

	public float m_SprintDisableWhenForwardInputBelow;

	public float m_SprintDisableWhenStrafeInputAbove;

	public bool m_ShouldStartAutoWalkingOnForwards;

	private float m_MaxSprintStamina;

	private float m_SprintStamina;

	private float m_LastCrouchedTime;

	private float m_SecondsSprinting;

	private float m_SecondsNotSprinting;

	private float m_DistanceAccumulator;

	private FootstepTrail m_FootstepTrail;

	private bool m_StartHasBeenCalled;

	private bool m_StaminaRechargeDisabled;

	private ForcedMovement m_ForcedMovement;

	private bool m_ForceNoRandomSprain;

	private bool m_IsCrouching;

	private float m_AccumulatedDistance;

	private static PlayerMovementSaveDataProxy m_PlayerMovementSaveDataProxy;

	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "AddFootstepTrail")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsStateEnabled")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	private void Start()
	{
	}

	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InputManager), Member = "CanExecuteCrouchAction")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[Calls(Type = typeof(InputManager), Member = "GetSprintDown")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerMovement), Member = "Start")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CallsUnknownMethods(Count = 2)]
	public void SetForceCrouch(bool enabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsCrouchForced()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetForceWalk(bool enabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsWalkForced()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsCrouchOrLimpOrWalkForced()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetForceLimp(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsLimpForced()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetForceLimpSlow(bool enabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsLimpSlowForced()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsNoRandomSprainForced()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetForceNoRandomSprain(bool isNoRandomSprainForced)
	{
	}

	[CallerCount(Count = 0)]
	public float GetSprintStaminaRemainingAsPercentage()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnElevatorMoving")]
	[CalledBy(Type = typeof(Fatigue), Member = "ComputeHeavyBreathingState")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStimExitEffects")]
	[Calls(Type = typeof(PlayerManager), Member = "GetNormalizedSprintReduction")]
	[CallerCount(Count = 10)]
	public float GetModifiedMaxSprintStamina()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSecondsSprinting()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetSecondsNotSprinting()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public float GetIndoorMovementSlowdownMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	public float GetMaterialMovementMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetLimpMovementMultiplier()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CallsUnknownMethods(Count = 1)]
	public float GetBodyCarryMovementMultiplier()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public float GetSnowDepthMovementMultiplier()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetVelocity")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public float GetWindMovementMultiplier()
	{
		return default(float);
	}

	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetBodyCarryMovementMultiplier")]
	[Calls(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	public void MovedDistance(Vector3 delta, bool wasStopped)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void UpdateDistanceTraveled(float dist)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AiTarget), Member = "GetVelocity")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "GetWindMovementMultiplier")]
	[CallsUnknownMethods(Count = 1)]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[CallsUnknownMethods(Count = 3)]
	public float GetDetectionRangeScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetFootStepsRangeScale()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerSwing), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeApplyStaminaCost")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateStamina")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update_SpearRaised")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	public void AddSprintStamina(float stamina)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSprintStamina()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void DisableStaminaRecharge(bool disabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsStaminaRechargeDisabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public bool StaminaUsedForClimbing()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[CallsUnknownMethods(Count = 3)]
	private bool AllowStaminaToRecover()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public PlayerMovement()
	{
	}
}
