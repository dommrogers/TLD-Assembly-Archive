using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_FPSWeapon : vp_Component
{
	protected CharacterController Controller;

	public float RenderingZoomDamping;

	private bool m_StartCalled;

	protected float m_FinalZoomTime;

	public float RenderingFieldOfView;

	public FPSMeshID m_FPSMeshId;

	private float m_UnzoomedFieldOfView;

	private float m_ZoomedFieldOfView;

	private float m_Accumulator;

	public Vector2 RenderingClippingPlanes;

	public Vector3 PositionOffset;

	public float PositionSpringStiffness;

	public float PositionSpringDamping;

	public float PositionKneeling;

	public float PositionFallRetract;

	public float PositionFallYCancel;

	public float PositionPivotSpringStiffness;

	public float PositionPivotSpringDamping;

	public float PositionSpring2Stiffness;

	public float PositionSpring2Damping;

	public Vector3 PositionWalkSlide;

	public Vector3 PositionPivot;

	public float PositionInputVelocityScale;

	public float PositionMaxInputVelocity;

	protected vp_Spring m_PositionSpring;

	protected vp_Spring m_PositionSpring2;

	protected vp_Spring m_PositionPivotSpring;

	protected GameObject m_WeaponCamera;

	protected GameObject m_WeaponGroup;

	protected GameObject m_Pivot;

	public Vector3 RotationOffset;

	public float RotationSpringStiffness;

	public float RotationSpringDamping;

	public float RotationSpring2Stiffness;

	public float RotationSpring2Damping;

	public Vector3 RotationLookSway;

	public Vector3 RotationStrafeSway;

	public Vector3 RotationFallSway;

	public float RotationSlopeSway;

	public float RotationInputVelocityScale;

	public float RotationMaxInputVelocity;

	protected vp_Spring m_RotationSpring;

	protected vp_Spring m_RotationSpring2;

	public float ShakeSpeed;

	public Vector3 ShakeAmplitude;

	protected Vector3 m_Shake;

	public Vector4 BobRate;

	public Vector4 BobAmplitude;

	public float BobInputVelocityScale;

	public float BobMaxInputVelocity;

	protected float m_LastBobSpeed;

	public float SwayStartFatigue;

	public float SwayMaxFatigue;

	public float SwayMotionSpeed;

	public Vector3 SwayLimits;

	public float SwayCrouchScalar;

	public Vector3 PositionExitOffset;

	public Vector3 RotationExitOffset;

	private GameObject m_FXGameObject;

	private Light m_LightIndoor;

	private Light m_LightOutdoor;

	private Camera m_WeaponCameraComponent;

	private Animator m_Animator;

	private int m_BulletsToReload;

	public GearItem m_GearItem;

	public GunItem m_GunItem;

	public FirstPersonWeapon m_FirstPersonWeaponRightHand;

	public FirstPersonWeapon m_FirstPersonWeaponLeftHand;

	public FirstPersonWeapon m_FirstPersonWeaponShoulder;

	public GameObject m_FirstPersonWeaponRightHandPrefab;

	public GameObject m_FirstPersonWeaponLeftHandPrefab;

	public GameObject m_FirstPersonWeaponShoulderPrefab;

	public bool m_UseFirstPersonHands;

	public float m_AimingMinYawStepDegrees;

	public float m_AimingMaxYawStepDegrees;

	public float m_AimingMinYawDegrees;

	public float m_AimingMaxYawDegrees;

	public float m_BreathingCycleMinPitchDegrees;

	public float m_BreathingCycleMaxPitchDegrees;

	public float m_KneelingBonusPitch;

	public float m_KneelingBonusYaw;

	public float m_ColdRandomShakingOscillationSpeed;

	public float m_ColrRandomShakingNoiseSpeed;

	public float m_ColdTeethChatterRate;

	public Vector3 m_ColdShakingAngleLimits;

	public float m_ColdShakeAngle;

	private float m_CurrentBreathTimePercentAsPitchDegrees;

	private float m_CurrentBreathingPercent;

	private float m_AimingCurrentYawDegrees;

	public float m_StaminaWeaponDropDegrees;

	private float m_ShiverTeethChatteringTime;

	private GameObject m_RightTemporaryParent;

	private GameObject m_LeftTemporaryParent;

	private GameObject m_ShoulderTemporaryParent;

	private GameObject m_MovedChild;

	private GameObject m_NewChild;

	[NonSerialized]
	private static bool m_DisableAimBreathing;

	[NonSerialized]
	private static bool m_DisableAimSway;

	[NonSerialized]
	private static bool m_DisableAimStamina;

	[NonSerialized]
	private static bool m_DisableAimShake;

	[NonSerialized]
	private static bool m_DisableDepthOfField;

	private const string TEMP_RIGHT_PARENT = "Right_Temp_Parent";

	private const string TEMP_LEFT_PARENT = "Left_Temp_Parent";

	private const string TEMP_SHOULDER_PARENT = "Shoulder_Temp_Parent";

	private Vector3 m_RandomShakeAngle;

	private Action<float, float> m_FixedUpdateCallback;

	public float RenderingFieldOfViewVertical
	{
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "HidePrevious")]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SnapZoom")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
		[CallsUnknownMethods(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
		[CallerCount(Count = 7)]
		get
		{
			return default(float);
		}
	}

	public GameObject WeaponCamera
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public Vector3 DefaultPosition
	{
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AnimateToDefaultPosition")]
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
		[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 4)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 DefaultRotation
	{
		[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
		[CalledBy(Type = typeof(vp_FPSShooter), Member = "Update")]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AnimateToDefaultPosition")]
		[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
		[CallsUnknownMethods(Count = 4)]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
		get
		{
			return default(Vector3);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool GetStartCalled()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	private Vector3 RandomShake(float deltaTime, float speed, float noiseSpeed)
	{
		return default(Vector3);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool IsAimBreathingDisabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_sway")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	public static bool IsAimSwayDisabled()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool IsAimStaminaDisabled()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool IsAimShakeDisabled()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool GetDisableDepthOfField()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void SetDisableAimBreathing(bool enable)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void SetDisableAimSway(bool enable)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void SetDisableAimStamina(bool enable)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void SetDisableAimShake(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetDisableDepthOfField(bool enable)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool CanStartAiming()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ShouldStopAiming()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "NoWeaponCameraError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(vp_Component), Member = "Awake")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	protected new void Awake()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 36)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[CallsUnknownMethods(Count = 117)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	protected new void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoCustomFixedUpdate")]
	[CallerCount(Count = 0)]
	protected new void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[CallsDeduplicatedMethods(Count = 4)]
	protected void FixedUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CallsUnknownMethods(Count = 4)]
	protected void FixedUpdateInternal(float fixedTime, float fixedDeltaTime)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DoWeaponSwaying")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DoWeaponBob")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected void UpdateForces(float time, float deltaTime)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddForce(Vector3 positional, Vector3 angular)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void AddForce(float xPos, float yPos, float zPos, float xRot, float yRot, float zRot)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddForce2(Vector3 positional, Vector3 angular)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void AddForce2(float xPos, float yPos, float zPos, float xRot, float yRot, float zRot)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ApplyFallImpact(float impact)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddForce(Vector3 force)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddForce(float x, float y, float z)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetAimingZoomBlend")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "FixedUpdate")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	protected void UpdateZoom(float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Zoom()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SnapZoom()
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateForces")]
	[CallsUnknownMethods(Count = 6)]
	protected void DoWeaponBob(float speed, float time)
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "Min")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "Max")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "Min")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "Max")]
	[CallsDeduplicatedMethods(Count = 3)]
	protected void DoWeaponSwaying(Vector3 velocity, float time, float deltaTime)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(Skill_Rifle), Member = "GetStabilityBonus")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "IsAimSwayDisabled")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "RandomShake")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "FixedUpdateInternal")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Quaternion), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public void DoAiming(float fixedTime, float fixedDeltaTime)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(vp_Spring), Member = "ForceVelocityFadeIn")]
	[Calls(Type = typeof(vp_Spring), Member = "ForceVelocityFadeIn")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void ResetSprings(float positionReset, float rotationReset, float positionPauseTime = 0f, float rotationPauseTime = 0f)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "NoWeaponCameraError")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public override void Refresh()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "HidePrevious")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void SnapPivot()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void SetPivotVisible(bool visible)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "HidePrevious")]
	[CallsUnknownMethods(Count = 20)]
	[CallerCount(Count = 1)]
	public void SnapSprings()
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	public void StopSprings()
	{
	}

	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	public void TurnOnEffects()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void DisableEffectsObject()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(ParticleSystem), Member = "Clear")]
	public void TurnOffEffects(bool hardStop)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AnimateToExitOffset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	public void AnimateToDefaultPosition()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void NoWeaponCameraError()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CheckForFireRelease")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	public int GetAmmoCount()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool AnimIsPlaying(int id, int layer)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(vp_FPSCamera.RecoilSpring), Member = "SetTarget")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public void PlayFireAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	private void OnFireAnimationComplete()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	public void ToggleZoom(bool zoomed)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CallerCount(Count = 1)]
	public void UnJam()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(GunItem), Member = "PlayCasingAudio")]
	[Calls(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(GunItem), Member = "RemoveNextFromClip")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(GunItem), Member = "GetAmmoCondition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void OnUnJamComplete()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Reload")]
	[CallsUnknownMethods(Count = 58)]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	public void SetBulletsToReload(int count)
	{
	}

	[CallerCount(Count = 0)]
	public bool ReloadInProgress()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSShooter), Member = "PreventFiring")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public void OnReloadComplete()
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CallerCount(Count = 0)]
	public void MaybeSpawnFirstPersonWeapon()
	{
	}

	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	private GameObject GetOrCreateTempParent(string objectName, Transform parent)
	{
		return null;
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 15)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "GetOrCreateTempParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeSpawnRightHandProp()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "GetOrCreateTempParent")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeSpawnLeftHandProp()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "GetOrCreateTempParent")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeSpawnShoulderProp()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnClipLoaded")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "CancelReload")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateReloadCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	public bool DecrementBulletsToReload(int n)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CancelReload")]
	public void CancelReload()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GunItem), Member = "ResetEffects")]
	public void Reset()
	{
	}

	[Calls(Type = typeof(FirstPersonWeapon), Member = "UpdateBulletsForReload")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamRoundsUnloaded")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "UpdateBulletsForReload")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void UpdateBulletsForReload(int numToShow)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ShowNextLoadedBullet()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_ShowReloadBulletInstance")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void EnableReloadBulletInstance(bool enable)
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "CopyChildObject")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MoveToTempParent")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "RestoreChildObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void AttachObjectChildCopy(GameObject parentObject)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AttachObjectChildCopy")]
	[CalledBy(Type = typeof(BodyCarry), Member = "AttachFPMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BodyCarry), Member = "DetachFPMesh")]
	[CallsDeduplicatedMethods(Count = 7)]
	public void RestoreChildObject()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Update")]
	[CalledBy(Type = typeof(BodyCarry), Member = "IsPlayingCarryIdleAnimation")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AnimationUtils), Member = "IsStatePlayingOnAnyLayer")]
	[CallerCount(Count = 2)]
	public bool IsAnimationPlayingOnAnyLayer(int hash)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "PlayCarryIdleAnimation")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Update")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void PlayAnimation(int hash)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 37)]
	[CalledBy(Type = typeof(BodyCarry), Member = "AttachFPMesh")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AttachObjectChildCopy")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	private void MoveToTempParent()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AttachObjectChildCopy")]
	[CalledBy(Type = typeof(BodyCarry), Member = "AttachFPMesh")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	private void CopyChildObject(GameObject newProp)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	private void OnUnJamRoundsUnloaded()
	{
	}

	[Calls(Type = typeof(GunItem), Member = "PlayCasingAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "InstatiateItemAtLocation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "GetDropItemLocationForLastDoor")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[CallsUnknownMethods(Count = 17)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	private void OnRoundsUnloaded()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(vp_Component), Member = ".ctor")]
	public vp_FPSWeapon()
	{
	}
}
