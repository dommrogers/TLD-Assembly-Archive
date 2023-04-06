using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.SaveState;
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

	public BowItem m_BowItem;

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
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SnapZoom")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return 0f;
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
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 DefaultRotation
	{
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
		[CalledBy(Type = typeof(vp_FPSShooter), Member = "Update")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector3);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool GetStartCalled()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private Vector3 RandomShake(float deltaTime, float speed, float noiseSpeed)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public static bool IsAimBreathingDisabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAimSwayDisabled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool IsAimStaminaDisabled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool IsAimShakeDisabled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool GetDisableDepthOfField()
	{
		return false;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool HasFirstPersonWeapon()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanStartAiming()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool ShouldStopAiming()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Component), Member = "Awake")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "NoWeaponCameraError")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 24)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeBuildRuntimeHierarchy")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 19)]
	protected override void Start()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RegisterWeaponItem")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 12)]
	public void MaybeBuildRuntimeHierarchy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoCustomFixedUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	protected void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CallsUnknownMethods(Count = 3)]
	protected void FixedUpdateInternal(float fixedTime, float fixedDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DoWeaponSwaying")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DoWeaponBob")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void UpdateForces(float time, float deltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void SetActive(bool isActive)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void AddForce(Vector3 positional, Vector3 angular)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void AddForce(float xPos, float yPos, float zPos, float xRot, float yRot, float zRot)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void AddForce2(Vector3 positional, Vector3 angular)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void AddForce2(float xPos, float yPos, float zPos, float xRot, float yRot, float zRot)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyFallImpact(float impact)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void AddForce(Vector3 force)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void AddForce(float x, float y, float z)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetAimingZoomBlend")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void UpdateZoom(float time)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Zoom()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CallsUnknownMethods(Count = 1)]
	public void SnapZoom()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateForces")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 5)]
	protected void DoWeaponBob(float speed, float time)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateForces")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	protected void DoWeaponSwaying(Vector3 velocity, float time, float deltaTime)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(Skill_Rifle), Member = "GetStabilityBonus")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "IsAimSwayDisabled")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "RandomShake")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	public void DoAiming(float fixedTime, float fixedDeltaTime)
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "ForceVelocityFadeIn")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetSprings(float positionReset, float rotationReset, float positionPauseTime = 0f, float rotationPauseTime = 0f)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "NoWeaponCameraError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public override void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void SnapPivot()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetPivotVisible(bool visible)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void SnapSprings()
	{
	}

	[CallerCount(Count = 0)]
	public void StopSprings()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public void TurnOnEffects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DisableEffectsObject()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ParticleSystem), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public void TurnOffEffects(bool hardStop)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AnimateToExitOffset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AnimateToDefaultPosition()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void NoWeaponCameraError()
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CheckForFireRelease")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public int GetAmmoCount()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 1)]
	public bool AnimIsPlaying(int id, int layer)
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(Skill_Revolver), Member = "GetRecoilScale")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(vp_FPSCamera.RecoilSpring), Member = "SetTarget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void PlayFireAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	private void OnFireAnimationComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ToggleZoom(bool zoomed)
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void UnJam()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(GunItem), Member = "RemoveNextFromClip")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[Calls(Type = typeof(GunItem), Member = "PlayCasingAudio")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnUnJamComplete()
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Reload")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	public void SetBulletsToReload(int count)
	{
	}

	[CallerCount(Count = 0)]
	public bool ReloadInProgress()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSShooter), Member = "PreventFiring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnReloadComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	public void MaybeSpawnFirstPersonWeapon()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private GameObject GetOrCreateTempParent(string objectName, Transform parent)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RegisterWeaponItem")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "GetOrCreateTempParent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeSpawnRightHandProp()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RegisterWeaponItem")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "GetOrCreateTempParent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeSpawnLeftHandProp()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RegisterWeaponItem")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "GetOrCreateTempParent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeSpawnShoulderProp()
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnClipLoaded")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateReloadCount")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "CancelReload")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool DecrementBulletsToReload(int n)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CancelReload")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[CallerCount(Count = 2)]
	public void CancelReload()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "ResetEffects")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RegisterWeaponItem")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamRoundsUnloaded")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "UpdateBulletsForReload")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateBulletsForReload(int numToShow)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ShowNextLoadedBullet()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RegisterWeaponItem")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnFirstPersonWeapon")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_ShowReloadBulletInstance")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableReloadBulletInstance")]
	[CallsUnknownMethods(Count = 1)]
	public void EnableReloadBulletInstance(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "RestoreChildObject")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MoveToTempParent")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "CopyChildObject")]
	public void AttachObjectChildCopy(GameObject parentObject)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AttachObjectChildCopy")]
	[CalledBy(Type = typeof(BodyCarry), Member = "AttachFPMesh")]
	[CalledBy(Type = typeof(BodyCarry), Member = "DetachFPMesh")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void RestoreChildObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationUtils), Member = "IsStatePlayingOnAnyLayer")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAnimationPlayingOnAnyLayer(int hash)
	{
		return false;
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "Update")]
	[CalledBy(Type = typeof(BodyCarry), Member = "PlayCarryIdleAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayAnimation(int hash)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AttachObjectChildCopy")]
	[CalledBy(Type = typeof(BodyCarry), Member = "AttachFPMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 12)]
	private void MoveToTempParent()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AttachObjectChildCopy")]
	[CalledBy(Type = typeof(BodyCarry), Member = "AttachFPMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	private void CopyChildObject(GameObject newProp)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CallsUnknownMethods(Count = 1)]
	private void OnUnJamRoundsUnloaded()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "GetDropItemLocationForLastDoor")]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadTypedAsset")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[Calls(Type = typeof(GunItem), Member = "PlayCasingAudio")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnRoundsUnloaded()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Component), Member = ".ctor")]
	public vp_FPSWeapon()
	{
	}
}
