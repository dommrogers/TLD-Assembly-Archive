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

	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "AddFootstepTrail")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsStateEnabled")]
	private void Start()
	{
	}

	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(InputManager), Member = "CanExecuteCrouchAction")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[Calls(Type = typeof(InputManager), Member = "GetSprintDown")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	private void Update()
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
	[Calls(Type = typeof(PlayerMovement), Member = "Start")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	public void SetForceCrouch(bool enabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsCrouchForced()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetForceWalk(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsWalkForced()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsCrouchOrLimpOrWalkForced()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetForceLimp(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsLimpForced()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetForceLimpSlow(bool enabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsLimpSlowForced()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnElevatorMoving")]
	[CalledBy(Type = typeof(Fatigue), Member = "ComputeHeavyBreathingState")]
	[Calls(Type = typeof(PlayerManager), Member = "GetNormalizedSprintReduction")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStimExitEffects")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CallsUnknownMethods(Count = 2)]
	public float GetModifiedMaxSprintStamina()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetSecondsSprinting()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSecondsNotSprinting()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 1)]
	public float GetIndoorMovementSlowdownMultiplier()
	{
		return default(float);
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CallsUnknownMethods(Count = 1)]
	public float GetBodyCarryMovementMultiplier()
	{
		return default(float);
	}

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	public float GetSnowDepthMovementMultiplier()
	{
		return default(float);
	}

	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetVelocity")]
	[CallerCount(Count = 1)]
	public float GetWindMovementMultiplier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[Calls(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetBodyCarryMovementMultiplier")]
	[Calls(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public void MovedDistance(Vector3 delta, bool wasStopped)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateDistanceTraveled(float dist)
	{
	}

	[CalledBy(Type = typeof(PlayerMovement), Member = "GetWindMovementMultiplier")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AiTarget), Member = "GetVelocity")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	public float GetFootStepsRangeScale()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeApplyStaminaCost")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update_SpearRaised")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateStamina")]
	[CalledBy(Type = typeof(PlayerSwing), Member = "Update")]
	public void AddSprintStamina(float stamina)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CallsUnknownMethods(Count = 3)]
	public bool StaminaUsedForClimbing()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallerCount(Count = 0)]
	private bool AllowStaminaToRecover()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public PlayerMovement()
	{
	}
}
