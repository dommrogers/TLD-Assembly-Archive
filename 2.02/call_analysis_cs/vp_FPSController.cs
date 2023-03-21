using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class vp_FPSController : vp_Component
{
	public CharacterController m_Controller;

	public float MotorVelocityMin;

	public float MotorVelocityMax;

	public float MotorAcceleration;

	public float MotorDamping;

	public float MotorJumpForce;

	public float MotorAirSpeed;

	public float MotorSlopeSpeedUp;

	public float MotorSlopeSpeedDown;

	public bool MotorAnalogInput;

	public float InputDeadzone;

	protected Vector3 m_MotorThrottle;

	protected bool m_MoveForward;

	protected bool m_MoveLeft;

	protected bool m_MoveRight;

	protected bool m_MoveBack;

	protected Vector2 m_MoveInput;

	public float PhysicsForceDamping;

	public float PhysicsPushForce;

	public float PhysicsGravityModifier;

	public float PhysicsWallBounce;

	protected Vector3 m_ExternalForce;

	protected bool m_WasGroundedLastFrame;

	protected float m_FallSpeed;

	protected float m_LastFallSpeed;

	protected float m_HighestFallSpeed;

	protected float m_FallImpact;

	protected float m_FallDistance;

	protected bool m_Compact;

	protected float m_NormalHeight;

	protected Vector3 m_NormalCenter;

	protected float m_CompactHeight;

	protected Vector3 m_CompactCenter;

	public static bool s_SplitMoveOptimizationEnabled;

	private bool m_IsOnUnpassableCapsule;

	private Vector3 m_UnpassableCapsuleNormalHit;

	private Vector3 m_LastMoveVelocity;

	private bool m_ControllerStoppedMoving;

	private bool m_CameraWasDetachedLastFrame;

	private float m_TimeMoving;

	private float m_LastMotorAccel;

	private bool m_SplitStepsEnabled;

	private float m_EffectiveMovePercent;

	private const float SPLIT_OPTIMIZATION_REDUCE_MOVE_LOW_THRESHOLD = 0.2f;

	private const float SPLIT_OPTIMIZATION_REDUCED_MOVE_HIGH_THRESHOLD = 0.5f;

	public float FallImpact
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public float FallDistance
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public Vector3 Velocity
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
	}

	public bool Compact
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float NormalHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
	}

	[Calls(Type = typeof(vp_Component), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	protected new void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected new void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 22)]
	private void DoPlayerStrafing(Vector3 moveDirection, Vector3 prevPos)
	{
	}

	[Calls(Type = typeof(CharacterController), Member = "Move_Injected")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(CharacterController), Member = "get_velocity_Injected")]
	[Calls(Type = typeof(Vector3), Member = "op_Addition")]
	[Calls(Type = typeof(CharacterController), Member = "Move_Injected")]
	[Calls(Type = typeof(CharacterController), Member = "get_velocity_Injected")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "op_Division")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector3), Member = "get_sqrMagnitude")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(vp_FPSController), Member = "AdjustMovementForCapsule")]
	[Calls(Type = typeof(vp_FPSController), Member = "ShouldFreezeMovement")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Vector3), Member = "op_Subtraction")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(CharacterController), Member = "set_height")]
	[Calls(Type = typeof(CharacterController), Member = "get_height")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbUpForce")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbHorisontalForce")]
	[Calls(Type = typeof(Vector3), Member = "op_Subtraction")]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition_Injected")]
	[Calls(Type = typeof(Vector3), Member = "Scale")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition_Injected")]
	[Calls(Type = typeof(Vector3), Member = "Dot")]
	[Calls(Type = typeof(CharacterController), Member = "Move_Injected")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(Vector3), Member = "Scale")]
	[Calls(Type = typeof(PlayerMovement), Member = "UpdateDistanceTraveled")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector3), Member = "op_Subtraction")]
	[Calls(Type = typeof(Vector3), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "op_Addition")]
	[Calls(Type = typeof(Vector3), Member = "op_Addition")]
	[Calls(Type = typeof(Vector3), Member = "op_Subtraction")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition_Injected")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[Calls(Type = typeof(vp_Component), Member = "Update")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(GameManager), Member = "AreControlsLockedForIntro")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CharacterController), Member = "set_center_Injected")]
	[Calls(Type = typeof(GameManager), Member = "IsMovementLockedBecauseOfLantern")]
	[Calls(Type = typeof(Vector3), Member = "op_Division")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Physics), Member = "get_gravity_Injected")]
	[Calls(Type = typeof(Vector3), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(CharacterController), Member = "get_stepOffset")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(CharacterController), Member = "get_height")]
	[Calls(Type = typeof(Vector3), Member = "op_Multiply")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Vector3), Member = "op_Addition")]
	[Calls(Type = typeof(Vector3), Member = "op_Multiply")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Physics), Member = "get_gravity_Injected")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(CharacterController), Member = "set_height")]
	protected new void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CharacterController), Member = "set_height")]
	[Calls(Type = typeof(CharacterController), Member = "set_height")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	public void SetCompactImmmediate(bool isCompact)
	{
	}

	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetBodyCarryMovementMultiplier")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetSnowDepthMovementMultiplier")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetWindMovementMultiplier")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_FPSController), Member = "GetSlopeMultiplier")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	protected void UpdateMoves()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected float GetSlopeMultiplier()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSController), Member = "AddForce")]
	[CalledBy(Type = typeof(Condition), Member = "ApplyLowHealthStagger")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateLowHealthStagger")]
	[CalledBy(Type = typeof(ImpactDefinition), Member = "Apply")]
	[CalledBy(Type = typeof(vp_Explosion), Member = "Awake")]
	public void AddForce(Vector3 force)
	{
	}

	[Calls(Type = typeof(vp_FPSController), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddForce(float x, float y, float z)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool Jump()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Rigidbody), Member = "get_mass")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(CapsuleCollider), Member = "get_direction")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	protected void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	protected void AbsorbHorisontalForce(Vector3 impact)
	{
	}

	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void AbsorbUpForce(float impact)
	{
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbUpForce")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbHorisontalForce")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbHorisontalForce")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbHorisontalForce")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbHorisontalForce")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbUpForce")]
	private float AbsorbForce(float current, float toAbsorb)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void MoveForward()
	{
	}

	[CallerCount(Count = 0)]
	public void MoveBack()
	{
	}

	[CallerCount(Count = 0)]
	public void MoveLeft()
	{
	}

	[CallerCount(Count = 0)]
	public void MoveRight()
	{
	}

	[CallerCount(Count = 0)]
	public void Move(Vector2 input)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetPosition(Vector3 position)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(Action_LookAtTargetForTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "PrepareStruggle")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GroundCharacterInternal")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void TryGroundingCharacterController()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetWasGroundedLastFrame(bool grounded)
	{
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private bool ShouldFreezeMovement()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	private Vector3 AdjustMovementForCapsule(Vector3 moveDirection)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool CanDoStrafing()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsUsingSplitSteps()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public float GetEffectiveMovePercent()
	{
		return default(float);
	}

	[Calls(Type = typeof(vp_Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public vp_FPSController()
	{
	}
}
