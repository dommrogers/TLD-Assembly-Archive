using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using Steamworks;
using TLD.Gameplay;
using UnityEngine;
using UnityEngine.AddressableAssets;

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
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
		public void Update(vp_FPSCamera cam)
		{
		}

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
		public void Reset()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass224_0
	{
		public vp_FPSCamera _003C_003E4__this;

		public Transform t;

		public vp_Timer.Callback _003C_003E9__0;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass224_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateWhenSilent")]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 34)]
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
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_ambient_sway")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAmbientSwayDisabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static void SetDisableAmbientSway(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public void SetUseRootOrientation(bool useRootOrientation)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_Component), Member = "Awake")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 27)]
	protected override void Awake()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetMouseSensitivity")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetZoomSensitivity")]
	[Calls(Type = typeof(InputManager), Member = "GetGamepadCameraSensitivity")]
	protected override void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Camera GetCameraComponent()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected override void Init()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Start")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Reset()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ComputeJoystickInput")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetMouseDelta")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateMouseLook")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "HidePrevious")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "AreControlsLockedForIntro")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "RestoreMainCameraPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoCustomFixedUpdate")]
	protected override void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void SetUpdateForcesAndStrings(bool update)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeBlendToSyncBone")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "UpdateSyncPlayerToSyncBone")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "UpdateCamera")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	public void UpdateCameraRotation()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "UpdateMainCamera")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	protected void LateUpdate()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(RecoilSpring), Member = "Reset")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(RecoilSpring), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void DoLateUpdate()
	{
	}

	[Calls(Type = typeof(PlayerCameraAnim), Member = "RestoreMainCameraPos")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	protected void FixedUpdate()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateAmbientSway")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "IsAmbientSwayDisabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	protected void FixedUpdateInternal(float fixedTime, float fixedDeltaTime)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoBob")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DetectFallingImpact")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateEarthQuake")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	protected void UpdateForces(float time, float smoothDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	public void RefreshCameraTransform()
	{
	}

	[CallerCount(Count = 0)]
	public void SetWasGroundedLastFrame(bool wasGroundedLastFrame)
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[CallerCount(Count = 1)]
	protected void DetectFallingImpact(float smoothDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsUnknownMethods(Count = 22)]
	protected void DoCameraCollision()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DetectFallingImpact")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Knockdown")]
	[CalledBy(Type = typeof(PlayerManager), Member = "KnockedDownByAI")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "DoStumbleEffects")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "DoStumbleEffects")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "DoLimpAnimation")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void ApplyFallImpact(float impact, bool weaponOnly)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
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
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
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
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void AddRotationForce(float x, float y, float z)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPitchLimit(Vector2 limit)
	{
	}

	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterWaitForFirstClick")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterOutro")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterPrepareStruggle")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnEnterConstrainedState")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanToAfterFadeOutCommon")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "EnablePlayerFreeCameraMovement")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public void SetYawLimit(Quaternion baseRotation, Vector2 limit)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void EnableFreeCameraLook(Vector2 pitchLimit, Vector2 yawLimit)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void DisableFreeCameraLook()
	{
	}

	[CallerCount(Count = 0)]
	public void LockRotationLimit()
	{
	}

	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "RestoreYawPitchLimits")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "DisablePlayerFreeCameraMovement")]
	public void UnlockRotationLimit()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private Vector2 GetMouseDelta()
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "AddToYaw")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateMouseLook")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	private float CalculateClampedYaw(float delta, float orginalYaw, float yaw)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "CalculateClampedYaw")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateMouseLook(Vector2 input)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "CalculateClampedYaw")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	public void AddToYaw(float angle)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetAimingZoomBlend")]
	[CallerCount(Count = 1)]
	protected void UpdateZoom(float time)
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CancelZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ToggleZoom(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	public float GetUnzoomedFieldOfView()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Zoom()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetFOVFromOptions")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	public void SnapZoom()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	protected void UpdateShakes(float fixedTime)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateAmbientSway")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private Vector2 RandomSway(float deltaTime, float speed)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "RandomSway")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void UpdateAmbientSway(float fixedDeltaTime)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsMovementLockedBecauseOfLantern")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 7)]
	protected void DoBob(float speed, float time)
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void DetectBobStep(float speed, float upBob)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 3)]
	protected void DoSwaying(Vector3 velocity)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CalledBy(Type = typeof(vp_Explosion), Member = "Awake")]
	public void DoBomb(float force)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public void DoBomb(Vector3 positionForce, float minRollForce, float maxRollForce, Vector2 earthQuakeForce, float earthQuakeTime, float earthQuakeWeaponShakeFactor, float earthQuakeCameraRollFactor, Vector3 weaponPositionForce, Vector3 weaponRotationForce)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void DoStomp(float force)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void DoAttackHit(float shakeForce, float rollForce)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public override void Refresh()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallerCount(Count = 0)]
	public void SetAngle(float yaw, float pitch)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
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

	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Unequip")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoSwitchWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UnWieldCurrentWeapon")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetWeaponAvailable")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "OnExtinguishComplete")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SwitchWeapon(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "OnWeaponUnequipped")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	private void DoSwitchWeapon()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	private void HidePrevious()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool UseUnscaledTime()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void ForceUnscaledTime(bool useUnscaleTime)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateFXTransform")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	public GameObject GetFPSItemGameObject(FPSItem item)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateWhenSilent")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 6)]
	public void DeactivateAllWeapons()
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "TurnOffEffects")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalCompleteResetWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "TotalCasingsInClip")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void SetWeapon(GearItem gearItem)
	{
	}

	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(AudioSource), Member = "get_loop")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass224_0), Member = "<DeactivateWhenSilent>b__0")]
	[CallsUnknownMethods(Count = 9)]
	protected void DeactivateWhenSilent(Transform t)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetWeaponLayer(int layer)
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "TurnOnEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "TurnOffEffects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void EnableEffectsForWeapon(FPSItem itemData, bool enable, bool hardStop)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 2)]
	public vp_FPSWeapon GetWeaponFromItemData(FPSItem itemData)
	{
		return null;
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeBuildRuntimeHierarchy")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	private void RegisterWeaponItem(FPSItem itemData)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "GetFirstPersonWeaponCanSwitch")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 1)]
	public bool PanViewCameraIsDetached()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
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

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_NearPlaneOverride), Member = "MaybeResetNearPlane")]
	[CalledBy(Type = typeof(Action_NearPlaneOverride), Member = "OnStop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeResetNearPlane")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	public void StopNearPlaneOverride()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private bool AnimatedCameraPathIsPlaying()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Vector2), Member = "get_normalized")]
	[Calls(Type = typeof(Vector2), Member = "get_normalized")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	private Vector2 ComputeJoystickInput(float deltaTime)
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_drop_scatter_item_in_hands")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 4)]
	public void MaybeResetCurrentWeapon()
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeBuildRuntimeHierarchy")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 19)]
	[CallerCount(Count = 1)]
	private void LoadAllFPSWeapons()
	{
	}

	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dump_weapon_ids")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallerCount(Count = 1)]
	public void DumpWeaponIds()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	public static void DoCustomFixedUpdate(Action<float, float> fixedUpdateAction, ref float accumulator)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public vp_FPSCamera()
	{
	}
}
