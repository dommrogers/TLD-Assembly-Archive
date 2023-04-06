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
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "AddFootstepTrail")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsStateEnabled")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CallsUnknownMethods(Count = 5)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetSprintDown")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(InputManager), Member = "CanExecuteCrouchAction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerMovement), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[CallsUnknownMethods(Count = 2)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetForceWalk(bool enabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsWalkForced()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsCrouchOrLimpOrWalkForced()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetForceLimp(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsLimpForced()
	{
		return false;
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
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsNoRandomSprainForced()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetForceNoRandomSprain(bool isNoRandomSprainForced)
	{
	}

	[CallerCount(Count = 0)]
	public float GetSprintStaminaRemainingAsPercentage()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStimExitEffects")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CalledBy(Type = typeof(Fatigue), Member = "ComputeHeavyBreathingState")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnElevatorMoving")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(PlayerManager), Member = "GetNormalizedSprintReduction")]
	[CallsUnknownMethods(Count = 2)]
	public float GetModifiedMaxSprintStamina()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSecondsSprinting()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSecondsNotSprinting()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 1)]
	public float GetIndoorMovementSlowdownMultiplier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	public float GetMaterialMovementMultiplier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetLimpMovementMultiplier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetBodyCarryMovementMultiplier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 1)]
	public float GetSnowDepthMovementMultiplier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetVelocity")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[CallsUnknownMethods(Count = 9)]
	public float GetWindMovementMultiplier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetBodyCarryMovementMultiplier")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 19)]
	public void MovedDistance(Vector3 delta, bool wasStopped)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateDistanceTraveled(float dist)
	{
	}

	[CalledBy(Type = typeof(AiTarget), Member = "GetVelocity")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "GetWindMovementMultiplier")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public float GetDetectionRangeScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[CallsUnknownMethods(Count = 2)]
	public float GetFootStepsRangeScale()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "Update_SpearRaised")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateStamina")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeApplyStaminaCost")]
	[CalledBy(Type = typeof(PlayerSwing), Member = "Update")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	public void AddSprintStamina(float stamina)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSprintStamina()
	{
		return 0f;
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
		return false;
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 3)]
	public bool StaminaUsedForClimbing()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[CallsUnknownMethods(Count = 3)]
	private bool AllowStaminaToRecover()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public PlayerMovement()
	{
	}
}
