using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class vp_FPSCamera : vp_Component
{
	public delegate void BobStepDelegate();

	public delegate void WeaponSwitchDelegate();

	public struct RecoilSpring
	{
		private Vector2 m_Current;

		private Vector2 m_Target;

		private Vector2 m_Velocity;

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
		public void SetTarget(float pitch, float yaw)
		{
		}

		[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
		[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateMouseLook")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RecoilSpring), Member = "Reset")]
		public void Update(vp_FPSCamera cam)
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
		[CalledBy(Type = typeof(RecoilSpring), Member = "Update")]
		public void Reset()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass228_0
	{
		public vp_FPSCamera _003C_003E4__this;

		public Transform t;

		public vp_Timer.Callback _003C_003E9__0;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass228_0()
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

	protected List<vp_FPSWeapon> m_Weapons;

	protected int m_CurrentWeaponID;

	protected vp_FPSWeapon m_CurrentWeapon;

	protected vp_FPSShooter m_CurrentShooter;

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

	private int m_PendingWeaponId;

	private GearItem m_PendingGearItem;

	private bool m_WeaponSwitchInProgress;

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
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int CurrentWeaponID
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector2 Angle
	{
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
		get
		{
			return default(Vector2);
		}
		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_ambient_sway")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 2)]
	public static bool IsAmbientSwayDisabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetDisableAmbientSway(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public void SetUseRootOrientation(bool useRootOrientation)
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 70)]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "InitWeaponsArray")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 26)]
	[Calls(Type = typeof(vp_Component), Member = "Awake")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	protected new void Awake()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetGamepadCameraSensitivity")]
	[Calls(Type = typeof(InputManager), Member = "GetZoomSensitivity")]
	[Calls(Type = typeof(InputManager), Member = "GetMouseSensitivity")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected new void Start()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected override void Init()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Start")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Reset()
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateMouseLook")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ComputeJoystickInput")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetMouseDelta")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "HidePrevious")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "RestoreMainCameraPos")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "AreControlsLockedForIntro")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoCustomFixedUpdate")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
	protected new void Update()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CallsUnknownMethods(Count = 14)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public void InitWeaponsArray()
	{
	}

	[CallerCount(Count = 0)]
	public void SetUpdateForcesAndStrings(bool update)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeBlendToSyncBone")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "UpdateSyncPlayerToSyncBone")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CallsUnknownMethods(Count = 38)]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "UpdateCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[Calls(Type = typeof(Vector3), Member = "get_left")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_left")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	public void UpdateCameraRotation()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "UpdateMainCamera")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	protected void LateUpdate()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_left")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(RecoilSpring), Member = "Reset")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(RecoilSpring), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LateUpdate")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	private void DoLateUpdate()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "RestoreMainCameraPos")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	protected void FixedUpdate()
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "IsAmbientSwayDisabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateAmbientSway")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdate")]
	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	protected void FixedUpdateInternal(float fixedTime, float fixedDeltaTime)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateEarthQuake")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoBob")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DetectFallingImpact")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoSwaying")]
	protected void UpdateForces(float time, float smoothDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	public void RefreshCameraTransform()
	{
	}

	[CallerCount(Count = 0)]
	public void SetWasGroundedLastFrame(bool wasGroundedLastFrame)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	protected void DetectFallingImpact(float smoothDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 21)]
	protected void DoCameraCollision()
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "DoStumbleEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DetectFallingImpact")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "DoLimpAnimation")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "DoStumbleEffects")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Knockdown")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	public void ApplyFallImpact(float impact, bool weaponOnly)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddForce(Vector3 force)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void AddForce(float x, float y, float z)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddForce2(Vector3 force)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void AddForce2(float x, float y, float z)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void AddRollForce(float force)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void AddRotationForce(Vector3 force)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void AddRotationForce(float x, float y, float z)
	{
	}

	[CallerCount(Count = 0)]
	public void SetPitchLimit(Vector2 limit)
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnEnterConstrainedState")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterWaitForFirstClick")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterPrepareStruggle")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterOutro")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanToAfterFadeOutCommon")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "EnablePlayerFreeCameraMovement")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	public void SetYawLimit(Quaternion baseRotation, Vector2 limit)
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	public void SetPitchLimitFromBase(Quaternion baseRotation, Vector2 limit)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsRotationLimitLocked()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsFreeCameraLookEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	public void EnableFreeCameraLook(Vector2 pitchLimit, Vector2 yawLimit)
	{
	}

	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void DisableFreeCameraLook()
	{
	}

	[CallerCount(Count = 0)]
	public void LockRotationLimit()
	{
	}

	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "RestoreYawPitchLimits")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "DisablePlayerFreeCameraMovement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterDueToStruggle")]
	public void UnlockRotationLimit()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private Vector2 GetMouseDelta()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateMouseLook")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "AddToYaw")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private float CalculateClampedYaw(float delta, float orginalYaw, float yaw)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(RecoilSpring), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "CalculateClampedYaw")]
	public void UpdateMouseLook(Vector2 input)
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "CalculateClampedYaw")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	[CallerCount(Count = 1)]
	public void AddToYaw(float angle)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetAimingZoomBlend")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CallsUnknownMethods(Count = 7)]
	protected void UpdateZoom(float time)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "ToggleZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CancelZoom")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomStart")]
	[CallerCount(Count = 7)]
	public void ToggleZoom(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetUnzoomedFieldOfView()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Zoom()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetFOVFromOptions")]
	public void SnapZoom()
	{
	}

	[Calls(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	protected void UpdateShakes(float fixedTime)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateAmbientSway")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	private Vector2 RandomSway(float deltaTime, float speed)
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(Vector2), Member = "get_one")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "RandomSway")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void UpdateAmbientSway(float fixedDeltaTime)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(GameManager), Member = "IsMovementLockedBecauseOfLantern")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 3)]
	protected void DoBob(float speed, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 0)]
	protected void DetectBobStep(float speed, float upBob)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	protected void DoSwaying(Vector3 velocity)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_Explosion), Member = "Awake")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 4)]
	public void DoBomb(float force)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 2)]
	public void DoBomb(Vector3 positionForce, float minRollForce, float maxRollForce, Vector2 earthQuakeForce, float earthQuakeTime, float earthQuakeWeaponShakeFactor, float earthQuakeCameraRollFactor, Vector3 weaponPositionForce, Vector3 weaponRotationForce)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 2)]
	public void DoStomp(float force)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void DoAttackHit(float shakeForce, float rollForce)
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "Zoom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	public override void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	public void SetAngle(float yaw, float pitch)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	public void SnapSprings()
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	public void StopSprings()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void UnWieldCurrentWeapon()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Unequip")]
	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetWeaponAvailable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoSwitchWeapon")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetWeapon")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[Calls(Type = typeof(FirstPersonItem), Member = "PlayUnWieldAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "OnExtinguishComplete")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SwitchWeapon(int weaponID, GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "OnWeaponUnequipped")]
	private void DoSwitchWeapon()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_FPSShooter), Member = "PreventFiring")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "SnapPivot")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "SnapSprings")]
	private void HidePrevious()
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "HidePrevious")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void ShowNext()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "DoSwitchWeapon")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "PanViewCameraIsDetached")]
	[CallerCount(Count = 32)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool WeaponSwitchInProgress()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool UseUnscaledTime()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void ForceUnscaledTime(bool useUnscaleTime)
	{
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GameObject GetFPSMeshGameObject(int weaponID)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationComplete")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateWhenSilent")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void DeactivateAllWeapons()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 80)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalCompleteResetWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "HidePrevious")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 25)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	public void SetWeapon(int weaponID, GearItem gearItem)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsUnknownMethods(Count = 49)]
	[CallsDeduplicatedMethods(Count = 16)]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass228_0), Member = "<DeactivateWhenSilent>b__0")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(AudioSource), Member = "get_loop")]
	protected void DeactivateWhenSilent(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetWeaponLayer(int layer)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "TurnOnEffects")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "TurnOffEffects")]
	public void EnableEffectsForWeapon(int weaponID, bool enable, bool hardStop)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "Awake")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public FPSMeshID GetWeaponIDFromName(string name)
	{
		return default(FPSMeshID);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 21)]
	public vp_FPSWeapon GetWeaponFromID(int weaponID)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "GetFirstPersonWeaponCanSwitch")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	public bool PanViewCameraIsDetached()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
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
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_NearPlaneOverride), Member = "MaybeResetNearPlane")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeResetNearPlane")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(Action_NearPlaneOverride), Member = "OnStop")]
	[CallerCount(Count = 6)]
	public void StopNearPlaneOverride()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	private bool AnimatedCameraPathIsPlaying()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Vector2), Member = "Lerp")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[CallsUnknownMethods(Count = 16)]
	private Vector2 ComputeJoystickInput(float deltaTime)
	{
		return default(Vector2);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_drop_scatter_item_in_hands")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public void MaybeResetCurrentWeapon()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dump_weapon_ids")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void DumpWeaponIds()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void DoCustomFixedUpdate(Action<float, float> fixedUpdateAction, ref float accumulator)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(vp_Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 19)]
	[CallsDeduplicatedMethods(Count = 2)]
	public vp_FPSCamera()
	{
	}
}
