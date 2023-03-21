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

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
		public void SetTarget(float pitch, float yaw)
		{
		}

		[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
		[CallAnalysisFailed]
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
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 34)]
		set
		{
		}
	}

	public bool IsZoomed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_ambient_sway")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 27)]
	[Calls(Type = typeof(vp_Component), Member = "Awake")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "LoadAllFPSWeapons")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(vp_Spring), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	protected override void Awake()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetGamepadCameraSensitivity")]
	[Calls(Type = typeof(InputManager), Member = "GetMouseSensitivity")]
	[Calls(Type = typeof(InputManager), Member = "GetZoomSensitivity")]
	protected override void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected override void Init()
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Start")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(Time), Member = "get_fixedTime")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetMouseDelta")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ComputeJoystickInput")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateMouseLook")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "HidePrevious")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "AreControlsLockedForIntro")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoCustomFixedUpdate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "RestoreMainCameraPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	protected override void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void SetUpdateForcesAndStrings(bool update)
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeBlendToSyncBone")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "UpdateSyncPlayerToSyncBone")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "UpdateCamera")]
	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public void UpdateCameraRotation()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoLateUpdate")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "UpdateMainCamera")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	protected void LateUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(RecoilSpring), Member = "Update")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(RecoilSpring), Member = "Reset")]
	private void DoLateUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "RestoreMainCameraPos")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected void FixedUpdate()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateAmbientSway")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdate")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "IsAmbientSwayDisabled")]
	protected void FixedUpdateInternal(float fixedTime, float fixedDeltaTime)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DetectFallingImpact")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoBob")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateEarthQuake")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	protected void UpdateForces(float time, float smoothDeltaTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void RefreshCameraTransform()
	{
	}

	[CallerCount(Count = 0)]
	public void SetWasGroundedLastFrame(bool wasGroundedLastFrame)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected void DetectFallingImpact(float smoothDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsUnknownMethods(Count = 22)]
	[CallsDeduplicatedMethods(Count = 19)]
	protected void DoCameraCollision()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DetectFallingImpact")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "DoStumbleEffects")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "DoLimpAnimation")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Knockdown")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "DoStumbleEffects")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "KnockedDownByAI")]
	public void ApplyFallImpact(float impact, bool weaponOnly)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void AddForce(Vector3 force)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void AddForce(float x, float y, float z)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void AddRollForce(float force)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	public void AddRotationForce(Vector3 force)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddRotationForce(float x, float y, float z)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetPitchLimit(Vector2 limit)
	{
	}

	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanToAfterFadeOutCommon")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterOutro")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterPrepareStruggle")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterWaitForFirstClick")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnEnterConstrainedState")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "EnablePlayerFreeCameraMovement")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
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

	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(BearSpearItem), Member = "RestoreYawPitchLimits")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "DisablePlayerFreeCameraMovement")]
	public void UnlockRotationLimit()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private Vector2 GetMouseDelta()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "AddToYaw")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateMouseLook")]
	private float CalculateClampedYaw(float delta, float orginalYaw, float yaw)
	{
		return default(float);
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "CalculateClampedYaw")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateMouseLook(Vector2 input)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "CalculateClampedYaw")]
	public void AddToYaw(float angle)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetAimingZoomBlend")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	protected void UpdateZoom(float time)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CancelZoom")]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	public void ToggleZoom(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	public float GetUnzoomedFieldOfView()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void Zoom()
	{
	}

	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetFOVFromOptions")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	public void SnapZoom()
	{
	}

	[Calls(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected void UpdateShakes(float fixedTime)
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateAmbientSway")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 5)]
	private Vector2 RandomSway(float deltaTime, float speed)
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "RandomSway")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	protected void UpdateAmbientSway(float fixedDeltaTime)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsMovementLockedBecauseOfLantern")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	protected void DoBob(float speed, float time)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void DetectBobStep(float speed, float upBob)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected void DoSwaying(Vector3 velocity)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[Calls(Type = typeof(vp_Component), Member = "get_Delta")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
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
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CalledBy(Type = typeof(vp_Explosion), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void DoBomb(float force)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public void DoBomb(Vector3 positionForce, float minRollForce, float maxRollForce, Vector2 earthQuakeForce, float earthQuakeTime, float earthQuakeWeaponShakeFactor, float earthQuakeCameraRollFactor, Vector3 weaponPositionForce, Vector3 weaponRotationForce)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void DoStomp(float force)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void DoAttackHit(float shakeForce, float rollForce)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	public override void Refresh()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallerCount(Count = 0)]
	public void SetAngle(float yaw, float pitch)
	{
	}

	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Unequip")]
	[Calls(Type = typeof(PlayerManager), Member = "OnExtinguishComplete")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoSwitchWeapon")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UnWieldCurrentWeapon")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetWeaponAvailable")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SwitchWeapon(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "OnWeaponUnequipped")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	private void DoSwitchWeapon()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	private void HidePrevious()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "PanViewCameraIsDetached")]
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
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateFXTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	public GameObject GetFPSItemGameObject(FPSItem item)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateWhenSilent")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 6)]
	public void DeactivateAllWeapons()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(GunItem), Member = "TotalCasingsInClip")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalCompleteResetWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
	[CallsDeduplicatedMethods(Count = 25)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
	public void SetWeapon(GearItem gearItem)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass224_0), Member = "<DeactivateWhenSilent>b__0")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(AudioSource), Member = "get_loop")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	protected void DeactivateWhenSilent(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetWeaponLayer(int layer)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "TurnOnEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "TurnOffEffects")]
	public void EnableEffectsForWeapon(FPSItem itemData, bool enable, bool hardStop)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 22)]
	public vp_FPSWeapon GetWeaponFromItemData(FPSItem itemData)
	{
		return null;
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeBuildRuntimeHierarchy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	private void RegisterWeaponItem(FPSItem itemData)
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "GetFirstPersonWeaponCanSwitch")]
	public bool PanViewCameraIsDetached()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_NearPlaneOverride), Member = "MaybeResetNearPlane")]
	[CalledBy(Type = typeof(Action_NearPlaneOverride), Member = "OnStop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeResetNearPlane")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public void StopNearPlaneOverride()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private bool AnimatedCameraPathIsPlaying()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Vector2), Member = "get_normalized")]
	[Calls(Type = typeof(Vector2), Member = "get_normalized")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	private Vector2 ComputeJoystickInput(float deltaTime)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_drop_scatter_item_in_hands")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeResetCurrentWeapon()
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeBuildRuntimeHierarchy")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	private void LoadAllFPSWeapons()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dump_weapon_ids")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
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

	[Calls(Type = typeof(vp_Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public vp_FPSCamera()
	{
	}
}
