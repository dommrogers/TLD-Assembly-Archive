using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using Steamworks;
using TLD.AddressableAssets;
using TLD.Gameplay;
using TLD.SaveState;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class vp_FPSCamera : vp_Component
{
	public delegate void BobStepDelegate();

	public delegate void WeaponSwitchDelegate();

	public struct RecoilSpring
	{
		private Vector2 m_Current;

		private Vector2 m_Target;

		private Vector2 m_Velocity;

		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
		[CallerCount(Count = 1)]
		public void SetTarget(float pitch, float yaw)
		{
		}

		[CallAnalysisFailed]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
		[CallerCount(Count = 1)]
		public void Update(vp_FPSCamera cam)
		{
		}

		[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
		[CallerCount(Count = 1)]
		public void Reset()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass224_0
	{
		public vp_FPSCamera _003C_003E4__this;

		public Transform t;

		public vp_Timer.Callback _003C_003E9__0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass224_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateWhenSilent")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CDeactivateWhenSilent_003Eb__0()
		{
		}
	}

	private const float ZOOMED_FOV_MULTIPLIER = 0.7f;

	private const float MIN_TIME_STEP = 0.02f;

	public static bool s_EnabledCustomFixedStep;

	protected CharacterController Controller;

	public PanViewCamera m_PanViewCamera;

	public Vector2 TouchSensitivity;

	public float GamepadDeadzone;

	public float GamepadDeadZonePower;

	public float GamepadSensitivity;

	public float GamepadTimeToMaxVelocity;

	public float GamepadTimeActiveResetAfterTimeInactive;

	public Vector2 GamepadMinVelocity;

	public Vector2 GamepadMaxVelocity;

	public int GamepadHistorySize;

	private Vector2[] GamepadHistory;

	private int GamepadHistoryCount;

	public float GamepadTimeActiveResetOnAngleDifferenceDegrees;

	public float m_MaxAmbientSwayAngleDegreesA;

	public float m_AmbientSwaySpeedA;

	public float m_MaxAmbientAimingSwayAngleDegreesA;

	public float m_AmbientAimingSwaySpeedA;

	public float m_SwayVarianceTime;

	private float GamepadTimeActive;

	private float GamepadTimeInactive;

	private float m_Accumulator;

	private float m_MouseSensitivity;

	private float m_UnzoomedMouseSensitivity;

	private float m_ZoomedMouseSensitivity;

	public int MouseSmoothSteps;

	public float MouseSmoothWeight;

	public bool MouseAcceleration;

	public float MouseAccelerationThreshold;

	protected Vector2 m_MouseMove;

	protected List<Vector2> m_MouseSmoothBuffer;

	private float m_RenderingFieldOfView;

	private float m_UnzoomedFieldOfView;

	public float RenderingFieldOfViewTest;

	public float RenderingZoomDamping;

	protected float m_FinalZoomTime;

	public Vector3 PositionOffset;

	public float PositionGroundLimit;

	public float PositionSpringStiffness;

	public float PositionSpringDamping;

	public float PositionSpring2Stiffness;

	public float PositionSpring2Damping;

	public float PositionKneeling;

	protected vp_Spring m_PositionSpring;

	protected vp_Spring m_PositionSpring2;

	public Vector2 RotationPitchLimit;

	public Vector2 RotationYawLimit;

	protected float m_Pitch;

	protected float m_Yaw;

	public float RotationSpringStiffness;

	public float RotationSpringDamping;

	public float RotationKneeling;

	public float RotationStrafeRoll;

	protected vp_Spring m_RotationSpring;

	protected Vector2 m_InitialRotation;

	public float m_BasePitch;

	public float m_BaseRoll;

	public float ShakeSpeed;

	public Vector3 ShakeAmplitude;

	protected Vector3 m_Shake;

	public Vector4 BobRate;

	public Vector4 BobAmplitude;

	public float BobInputVelocityScale;

	public float BobMaxInputVelocity;

	public BobStepDelegate BobStepCallback;

	public float BobStepThreshold;

	public float RecoilMinVelocity;

	public float RecoilPitchDamping;

	public float RecoilPitchStiffness;

	public float RecoilYawDamping;

	public float RecoilYawStiffness;

	public float m_OffsetY;

	public Camera m_WeaponCamera;

	public AssetLabelReference m_WeaponAssetLabel;

	public static bool m_DebugCamera;

	protected Camera m_Camera;

	protected float m_LastUpBob;

	protected bool m_BobWasElevating;

	protected float m_HighestFallSpeed;

	protected bool m_WasGroundedLastFrame;

	protected float m_EarthQuakeTime;

	protected Vector2 m_EarthQuakeMagnitude;

	protected float m_EarthQuakeWeaponShakeFactor;

	protected float m_EarthQuakeCameraRollFactor;

	private Transform m_WeaponParent;

	private readonly Dictionary<FPSItem, vp_FPSWeapon> m_Weapons;

	protected vp_FPSWeapon m_CurrentWeapon;

	protected vp_FPSShooter m_CurrentShooter;

	private GearItem m_PendingGearItem;

	protected float m_SwitchWeaponTimer;

	protected float m_ShowWeaponTimer;

	protected AudioListener m_AudioListener;

	private bool m_OverlayWasActive;

	private CameraPathAnimator[] m_CameraPathAnimators;

	private Vector2 DefaultRotationPitchLimit;

	private Vector2 DefaultRotationYawLimit;

	private float m_NearClipPlane;

	private bool _003CIsZoomed_003Ek__BackingField;

	private bool m_FirstFrame;

	private int m_NumUpdates;

	private bool m_UseRootOrientation;

	private bool m_LockRotationLimit;

	public Vector2 m_LockedRotationPitchLimit;

	public Vector2 m_LockedRotationYawLimit;

	private Vector2 m_AmbientSwayAngles;

	public float m_DeadZoneDampenScale;

	private float m_DeadZoneTime;

	private bool m_UpdateForcesAndSprings;

	private bool m_FreeCameraLookEnabled;

	[NonSerialized]
	private static bool m_DisableAmbientSway;

	private float m_CurrentAmbientSwaySpeed;

	private float m_CurrentMaxAmbientSwayAngle;

	private Vector3 m_RandomSwayOScillationAngles;

	private Vector3 m_RandomSwaySpeeds;

	private Vector3 m_CurrentRandomSwaySpeeds;

	private float m_RandomSwayCountdown;

	private Action<float, float> m_FixedUpdateCallback;

	private bool m_ForceIndoorFovAllowed;

	private float m_TargetPitch;

	private float m_CurrentPitch;

	private float m_TargetYaw;

	private float m_CurrentYaw;

	private float m_YawPitchDampingFactor;

	private bool m_UseUnscaledTime;

	public RecoilSpring m_RecoilSpring;

	public float MouseSensitivity
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public vp_FPSWeapon CurrentWeapon
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public vp_FPSShooter CurrentShooter
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public Vector3 PositionSpring
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector2 Angle
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
		[CallerCount(Count = 33)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public bool IsZoomed
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_ambient_sway")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAmbientSwayDisabled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static void SetDisableAmbientSway(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public void SetUseRootOrientation(bool useRootOrientation)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(vp_Component), Member = "Awake")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 25)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[Calls(Type = typeof(InputManager), Member = "GetMouseSensitivity")]
	[Calls(Type = typeof(InputManager), Member = "GetZoomSensitivity")]
	[Calls(Type = typeof(InputManager), Member = "GetGamepadCameraSensitivity")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetFOVFromOptions(float newFOV)
	{
	}

	[CallerCount(Count = 0)]
	public void SetMouseSensitivityFromOptions(float newMouseSensitivity)
	{
	}

	[CallerCount(Count = 0)]
	public void SetZoomSensitivityFromOptions(float newMouseSensitivity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Camera GetCameraComponent()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected override void Init()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Start")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoCustomFixedUpdate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(GameManager), Member = "AreControlsLockedForIntro")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "RestoreMainCameraPos")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "HidePrevious")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetMouseDelta")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ComputeJoystickInput")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateMouseLook")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 15)]
	protected override void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void SetUpdateForcesAndStrings(bool update)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeBlendToSyncBone")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "UpdateSyncPlayerToSyncBone")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "UpdateCamera")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 25)]
	public void UpdateCameraRotation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "UpdateMainCamera")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 12)]
	protected void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(RecoilSpring), Member = "Update")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(RecoilSpring), Member = "Reset")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private void DoLateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "RestoreMainCameraPos")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	protected void FixedUpdate()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "IsAmbientSwayDisabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateAmbientSway")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	protected void FixedUpdateInternal(float fixedTime, float fixedDeltaTime)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DetectFallingImpact")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoBob")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateEarthQuake")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	protected void UpdateForces(float time, float smoothDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void RefreshCameraTransform()
	{
	}

	[CallerCount(Count = 0)]
	public void SetWasGroundedLastFrame(bool wasGroundedLastFrame)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	protected void DetectFallingImpact(float smoothDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 22)]
	protected void DoCameraCollision()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DetectFallingImpact")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "DoLimpAnimation")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "DoStumbleEffects")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "DoStumbleEffects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "KnockedDownByAI")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Knockdown")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyFallImpact(float impact, bool weaponOnly)
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void AddForce2(Vector3 force)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void AddForce2(float x, float y, float z)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void AddRollForce(float force)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void AddRotationForce(Vector3 force)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void AddRotationForce(float x, float y, float z)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPitchLimit(Vector2 limit)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "EnablePlayerFreeCameraMovement")]
	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanToAfterFadeOutCommon")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnEnterConstrainedState")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterWaitForFirstClick")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterPrepareStruggle")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterOutro")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public void SetYawLimit(Quaternion baseRotation, Vector2 limit)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 2)]
	public void SetPitchLimitFromBase(Quaternion baseRotation, Vector2 limit)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsRotationLimitLocked()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsFreeCameraLookEnabled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 1)]
	public void EnableFreeCameraLook(Vector2 pitchLimit, Vector2 yawLimit)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[CallsUnknownMethods(Count = 1)]
	public void DisableFreeCameraLook()
	{
	}

	[CallerCount(Count = 0)]
	public void LockRotationLimit()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "RestoreYawPitchLimits")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "DisablePlayerFreeCameraMovement")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CallerCount(Count = 8)]
	public void UnlockRotationLimit()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private Vector2 GetMouseDelta()
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateMouseLook")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "AddToYaw")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private float CalculateClampedYaw(float delta, float orginalYaw, float yaw)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "CalculateClampedYaw")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateMouseLook(Vector2 input)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "CalculateClampedYaw")]
	public void AddToYaw(float angle)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetAimingZoomBlend")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	protected void UpdateZoom(float time)
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CancelZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void ToggleZoom(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	public float GetUnzoomedFieldOfView()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Zoom()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetFOVFromOptions")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	public void SnapZoom()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	protected void UpdateShakes(float fixedTime)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateAmbientSway")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private Vector2 RandomSway(float deltaTime, float speed)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "RandomSway")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsUnknownMethods(Count = 1)]
	protected void UpdateAmbientSway(float fixedDeltaTime)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameManager), Member = "IsMovementLockedBecauseOfLantern")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected void DoBob(float speed, float time)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void DetectBobStep(float speed, float upBob)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected void DoSwaying(Vector3 velocity)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected void UpdateEarthQuake(float time)
	{
	}

	[CallerCount(Count = 0)]
	public void DoEarthQuake(float x, float y, float duration, float weaponShakeFactor = 1f, float cameraRollFactor = 0f)
	{
	}

	[CallerCount(Count = 0)]
	public void StopEarthQuake()
	{
	}

	[CalledBy(Type = typeof(vp_Explosion), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DoBomb(float force)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DoBomb(Vector3 positionForce, float minRollForce, float maxRollForce, Vector2 earthQuakeForce, float earthQuakeTime, float earthQuakeWeaponShakeFactor, float earthQuakeCameraRollFactor, Vector3 weaponPositionForce, Vector3 weaponRotationForce)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void DoStomp(float force)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DoAttackHit(float shakeForce, float rollForce)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public override void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	public void SetAngle(float yaw, float pitch)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public void SnapSprings()
	{
	}

	[CallerCount(Count = 0)]
	public void StopSprings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	public void UnWieldCurrentWeapon()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UnWieldCurrentWeapon")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetWeaponAvailable")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Unequip")]
	[Calls(Type = typeof(PlayerManager), Member = "OnExtinguishComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoSwitchWeapon")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public void SwitchWeapon(GearItem gearItem)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "OnWeaponUnequipped")]
	[CallerCount(Count = 2)]
	private void DoSwitchWeapon()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallerCount(Count = 1)]
	private void HidePrevious()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void ShowNext()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoSwitchWeapon")]
	private void OnWeaponUnequipped()
	{
	}

	[CallerCount(Count = 0)]
	private void OnWeaponEquipped()
	{
	}

	[CallerCount(Count = 0)]
	public void CancelWeaponSwitch()
	{
	}

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "PanViewCameraIsDetached")]
	[CallsUnknownMethods(Count = 2)]
	public bool WeaponSwitchInProgress()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool UseUnscaledTime()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void ForceUnscaledTime(bool useUnscaleTime)
	{
	}

	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateFXTransform")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public GameObject GetFPSItemGameObject(FPSItem item)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateWhenSilent")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 6)]
	public void DeactivateAllWeapons()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalCompleteResetWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(GunItem), Member = "TotalCasingsInClip")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "TurnOffEffects")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 21)]
	public void SetWeapon(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass224_0), Member = "<DeactivateWhenSilent>b__0")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AudioSource), Member = "get_loop")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 9)]
	protected void DeactivateWhenSilent(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetWeaponLayer(int layer)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "TurnOffEffects")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "TurnOnEffects")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[CallsUnknownMethods(Count = 3)]
	public void EnableEffectsForWeapon(FPSItem itemData, bool enable, bool hardStop)
	{
	}

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public vp_FPSWeapon GetWeaponFromItemData(FPSItem itemData)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeBuildRuntimeHierarchy")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void RegisterWeaponItem(FPSItem itemData)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "GetFirstPersonWeaponCanSwitch")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool PanViewCameraIsDetached()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Camera GetWeaponCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void SetNearPlaneOverride(float nearPlane)
	{
	}

	[CallerCount(Count = 0)]
	public float GetNearPlaneOverride()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeResetNearPlane")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(Action_NearPlaneOverride), Member = "OnStop")]
	[CalledBy(Type = typeof(Action_NearPlaneOverride), Member = "MaybeResetNearPlane")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 3)]
	public void StopNearPlaneOverride()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private bool AnimatedCameraPathIsPlaying()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Vector2), Member = "get_normalized")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsUnknownMethods(Count = 6)]
	private Vector2 ComputeJoystickInput(float deltaTime)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_drop_scatter_item_in_hands")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeResetCurrentWeapon()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeBuildRuntimeHierarchy")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	private void LoadAllFPSWeapons()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dump_weapon_ids")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void DumpWeaponIds()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void DoCustomFixedUpdate(Action<float, float> fixedUpdateAction, ref float accumulator)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public vp_FPSCamera()
	{
	}
}
