using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
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

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "AddFootstepTrail")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsStateEnabled")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(InputManager), Member = "CanExecuteCrouchAction")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[Calls(Type = typeof(InputManager), Member = "GetSprintDown")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerMovement), Member = "Start")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CallsUnknownMethods(Count = 3)]
	public void SetForceCrouch(bool enabled)
	{
	}

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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetForceLimpSlow(bool enabled)
	{
	}

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
	[CallerCount(Count = 1)]
	public void SetForceNoRandomSprain(bool isNoRandomSprainForced)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForRopeClimbStress")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathingLoopRTPC")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetSprintStaminaRemainingAsPercentage()
	{
		return default(float);
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Fatigue), Member = "ComputeHeavyBreathingState")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(PlayerManager), Member = "GetNormalizedSprintReduction")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
	public float GetIndoorMovementSlowdownMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 4)]
	public float GetMaterialMovementMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetLimpMovementMultiplier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	public float GetBodyCarryMovementMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[CallsUnknownMethods(Count = 5)]
	public float GetSnowDepthMovementMultiplier()
	{
		return default(float);
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetVelocity")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public float GetWindMovementMultiplier()
	{
		return default(float);
	}

	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(Feat_SnowWalker), Member = "IncrementMeters")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Feat_FreeRunner), Member = "IncrementMeters")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CallsUnknownMethods(Count = 43)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetBodyCarryMovementMultiplier")]
	[Calls(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	public void MovedDistance(Vector3 delta, bool wasStopped)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	public void UpdateDistanceTraveled(float dist)
	{
	}

	[CalledBy(Type = typeof(PlayerMovement), Member = "GetWindMovementMultiplier")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AiTarget), Member = "GetVelocity")]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public float GetDetectionRangeScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[CallsUnknownMethods(Count = 4)]
	public float GetFootStepsRangeScale()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(PlayerSwing), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeApplyStaminaCost")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateStamina")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnElevatorMoving")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStimExitEffects")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update_SpearRaised")]
	public void AddSprintStamina(float stamina)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSprintStamina()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void DisableStaminaRecharge(bool disabled)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsStaminaRechargeDisabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	public bool StaminaUsedForClimbing()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[CallsUnknownMethods(Count = 6)]
	private bool AllowStaminaToRecover()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public PlayerMovement()
	{
	}
}
