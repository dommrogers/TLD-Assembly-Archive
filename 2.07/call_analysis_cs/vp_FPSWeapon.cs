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
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SnapZoom")]
		get
		{
			return default(float);
		}
	}

	public GameObject WeaponCamera
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public Vector3 DefaultPosition
	{
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
		[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
		[CallerCount(Count = 2)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 DefaultRotation
	{
		[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
		[CalledBy(Type = typeof(vp_FPSShooter), Member = "Update")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 3)]
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

	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private Vector3 RandomShake(float deltaTime, float speed, float noiseSpeed)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public static bool IsAimBreathingDisabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsAimSwayDisabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsAimStaminaDisabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsAimShakeDisabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool GetDisableDepthOfField()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static void SetDisableAimBreathing(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public static void SetDisableAimSway(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public static void SetDisableAimStamina(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public static void SetDisableAimShake(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public static void SetDisableDepthOfField(bool enable)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public bool HasFirstPersonWeapon()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanStartAiming()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ShouldStopAiming()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "NoWeaponCameraError")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(vp_Component), Member = "Awake")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	protected override void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeBuildRuntimeHierarchy")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	protected override void Start()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RegisterWeaponItem")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void MaybeBuildRuntimeHierarchy()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "DoCustomFixedUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void Update()
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	protected void FixedUpdate()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[CallerCount(Count = 0)]
	protected void FixedUpdateInternal(float fixedTime, float fixedDeltaTime)
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "DoWeaponBob")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DoWeaponSwaying")]
	[CallsUnknownMethods(Count = 2)]
	protected void UpdateForces(float time, float deltaTime)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void SetActive(bool isActive)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddForce(Vector3 positional, Vector3 angular)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddForce(float xPos, float yPos, float zPos, float xRot, float yRot, float zRot)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void AddForce2(Vector3 positional, Vector3 angular)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void AddForce(Vector3 force)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddForce(float x, float y, float z)
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetAimingZoomBlend")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "FixedUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	protected void UpdateZoom(float time)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Zoom()
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SnapZoom()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	protected void DoWeaponBob(float speed, float time)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateForces")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[CallsUnknownMethods(Count = 7)]
	protected void DoWeaponSwaying(Vector3 velocity, float time, float deltaTime)
	{
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(Skill_Rifle), Member = "GetStabilityBonus")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "IsAimSwayDisabled")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "FixedUpdateInternal")]
	[CallsUnknownMethods(Count = 21)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "RandomShake")]
	public void DoAiming(float fixedTime, float fixedDeltaTime)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "ForceVelocityFadeIn")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "ForceVelocityFadeIn")]
	public void ResetSprings(float positionReset, float rotationReset, float positionPauseTime = 0f, float rotationPauseTime = 0f)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "NoWeaponCameraError")]
	[CallsUnknownMethods(Count = 7)]
	public override void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void SnapPivot()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetPivotVisible(bool visible)
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void SnapSprings()
	{
	}

	[CallerCount(Count = 0)]
	public void StopSprings()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	public void TurnOnEffects()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DisableEffectsObject()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(ParticleSystem), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void TurnOffEffects(bool hardStop)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AnimateToExitOffset()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
	[CallerCount(Count = 0)]
	public void AnimateToDefaultPosition()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Refresh")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Awake")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 2)]
	private void NoWeaponCameraError()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CheckForFireRelease")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public int GetAmmoCount()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public bool AnimIsPlaying(int id, int layer)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(Skill_Revolver), Member = "GetRecoilScale")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Skill_Revolver), Member = "GetRecoilScale")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera.RecoilSpring), Member = "SetTarget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void PlayFireAnimation()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	private void OnFireAnimationComplete()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ToggleZoom(bool zoomed)
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void UnJam()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(GunItem), Member = "PlayCasingAudio")]
	[Calls(Type = typeof(GunItem), Member = "RemoveNextFromClip")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnUnJamComplete()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Reload")]
	[CallsUnknownMethods(Count = 3)]
	public void SetBulletsToReload(int count)
	{
	}

	[CallerCount(Count = 0)]
	public bool ReloadInProgress()
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_FPSShooter), Member = "PreventFiring")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void OnReloadComplete()
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	public void MaybeSpawnFirstPersonWeapon()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	private GameObject GetOrCreateTempParent(string objectName, Transform parent)
	{
		return null;
	}

	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "GetOrCreateTempParent")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RegisterWeaponItem")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeSpawnRightHandProp()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RegisterWeaponItem")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "GetOrCreateTempParent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeSpawnLeftHandProp()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "GetOrCreateTempParent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RegisterWeaponItem")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeSpawnShoulderProp()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnClipLoaded")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "CancelReload")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateReloadCount")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public bool DecrementBulletsToReload(int n)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CancelReload")]
	public void CancelReload()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GunItem), Member = "ResetEffects")]
	public void Reset()
	{
	}

	[Calls(Type = typeof(FirstPersonWeapon), Member = "UpdateBulletsForReload")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RegisterWeaponItem")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamRoundsUnloaded")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "UpdateBulletsForReload")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void UpdateBulletsForReload(int numToShow)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ShowNextLoadedBullet()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_ShowReloadBulletInstance")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RegisterWeaponItem")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void EnableReloadBulletInstance(bool enable)
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "MoveToTempParent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "RestoreChildObject")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "CopyChildObject")]
	public void AttachObjectChildCopy(GameObject parentObject)
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(BodyCarry), Member = "DetachFPMesh")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AttachObjectChildCopy")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BodyCarry), Member = "AttachFPMesh")]
	public void RestoreChildObject()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AnimationUtils), Member = "IsStatePlayingOnAnyLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public bool IsAnimationPlayingOnAnyLayer(int hash)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Update")]
	[CalledBy(Type = typeof(BodyCarry), Member = "PlayCarryIdleAnimation")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	public void PlayAnimation(int hash)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(BodyCarry), Member = "AttachFPMesh")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AttachObjectChildCopy")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 2)]
	private void MoveToTempParent()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AttachObjectChildCopy")]
	[CalledBy(Type = typeof(BodyCarry), Member = "AttachFPMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void CopyChildObject(GameObject newProp)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CallsUnknownMethods(Count = 1)]
	private void OnUnJamRoundsUnloaded()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GunItem), Member = "PlayCasingAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "GetDropItemLocationForLastDoor")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnRoundsUnloaded()
	{
	}

	[Calls(Type = typeof(vp_Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public vp_FPSWeapon()
	{
	}
}
