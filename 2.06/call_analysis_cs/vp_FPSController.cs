using System;
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
		[DeduplicatedMethod]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Component), Member = "Awake")]
	[CallsUnknownMethods(Count = 3)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected override void Start()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void DoPlayerStrafing(Vector3 moveDirection, Vector3 prevPos)
	{
	}

	[Calls(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(CharacterController), Member = "get_velocity")]
	[Calls(Type = typeof(CharacterController), Member = "get_velocity")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(vp_FPSController), Member = "ShouldFreezeMovement")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbHorisontalForce")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[Calls(Type = typeof(CharacterController), Member = "get_height")]
	[Calls(Type = typeof(CharacterController), Member = "set_height")]
	[Calls(Type = typeof(CharacterController), Member = "get_height")]
	[Calls(Type = typeof(CharacterController), Member = "set_height")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(GameManager), Member = "AreControlsLockedForIntro")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(GameManager), Member = "IsMovementLockedBecauseOfLantern")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	protected override void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(CharacterController), Member = "set_height")]
	[Calls(Type = typeof(CharacterController), Member = "set_height")]
	[CallerCount(Count = 2)]
	public void SetCompactImmmediate(bool isCompact)
	{
	}

	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_FPSController), Member = "GetSlopeMultiplier")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetBodyCarryMovementMultiplier")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetSnowDepthMovementMultiplier")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetWindMovementMultiplier")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector2), Member = "get_normalized")]
	[CallsUnknownMethods(Count = 16)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[Calls(Type = typeof(Vector2), Member = "get_normalized")]
	protected void UpdateMoves()
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	protected float GetSlopeMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void AddForce(Vector3 force)
	{
	}

	[CallerCount(Count = 0)]
	public void AddForce(float x, float y, float z)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool Jump()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(CapsuleCollider), Member = "get_direction")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody), Member = "get_mass")]
	protected void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	protected void AbsorbHorisontalForce(Vector3 impact)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_FPSController), Member = "AbsorbForce")]
	protected void AbsorbUpForce(float impact)
	{
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbHorisontalForce")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbHorisontalForce")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbHorisontalForce")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbHorisontalForce")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbUpForce")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbUpForce")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	private float AbsorbForce(float current, float toAbsorb)
	{
		return default(float);
	}

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
	[DeduplicatedMethod]
	public void Move(Vector2 input)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SetPosition(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GroundCharacterInternal")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "PrepareStruggle")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[CalledBy(Type = typeof(Action_LookAtTargetForTime), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	public void Stop()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void TryGroundingCharacterController()
	{
	}

	[CallerCount(Count = 0)]
	public void SetWasGroundedLastFrame(bool grounded)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	private bool ShouldFreezeMovement()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsUsingSplitSteps()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public float GetEffectiveMovePercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Component), Member = ".ctor")]
	public vp_FPSController()
	{
	}
}
