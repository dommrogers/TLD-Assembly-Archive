using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
	public class SerializedParams
	{
		public bool m_EnableFirstPersonHands;

		public string m_HandMeshState;

		public bool m_FirstPersonHandsHidden;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public SerializedParams()
		{
		}
	}

	public enum AnimationLayerFlags
	{
		Hip = 1,
		Shoulder
	}

	public delegate void OnAnimationEvent();

	public enum CameraLayer
	{
		Weapon,
		World
	}

	public enum CameraBasedHandPositioningMode
	{
		Standard,
		Aiming,
		Frozen,
		None
	}

	public enum State
	{
		Hidden,
		ToAiming,
		Aiming,
		FromAiming,
		Equipping,
		Showing,
		Dequipping,
		Brandishing,
		Igniting,
		Stowing,
		Stowed,
		Unstowing,
		Extinguishing,
		PickingUp,
		Placing,
		Firing,
		Reloading,
		Using,
		LookAround,
		AnimatedInteraction,
		Throwing,
		Killing,
		Spray,
		Explode
	}

	public enum StateFlags
	{
		Hidden = 1,
		ToAiming = 2,
		Aiming = 4,
		FromAiming = 8,
		Equipping = 0x10,
		Showing = 0x20,
		Dequipping = 0x40,
		Brandishing = 0x80,
		Igniting = 0x100,
		Stowing = 0x200,
		Stowed = 0x400,
		Unstowing = 0x800,
		Extinguishing = 0x1000,
		PickingUp = 0x2000,
		Placing = 0x4000,
		Firing = 0x8000,
		Reloading = 0x10000,
		Using = 0x20000,
		LookAround = 0x40000,
		AnimatedInteraction = 0x80000,
		Throwing = 0x100000,
		Killing = 0x200000,
		Spray = 0x400000,
		Explode = 0x800000
	}

	public enum AnimationCallbackEvent
	{
		DoNothing,
		AnimatedInteractionComplete,
		Brandish_Begin,
		Brandish_Complete,
		Brandish_MidSwing,
		Generic_Aim_Complete,
		Generic_Aim_Cancel_Complete,
		Generic_Equip_ShowItem,
		Generic_Equipped_Complete,
		Generic_Fire_FX,
		Generic_Fire_Complete,
		Generic_Hidden,
		Generic_Hidden_Complete,
		Generic_Stow_Complete,
		Generic_Unstow_Complete,
		Generic_Ignite_FX,
		Generic_Ignite_Complete,
		Generic_Extinguish_FX,
		Generic_Extinguish_Complete,
		Generic_LookAround_Complete,
		Generic_PlacementMode_PlaceItem_SpawnItemInWorld,
		Generic_PlacementMode_PlaceItem_HideItemInHands,
		Generic_PlacementMode_PlaceItem_Complete,
		Generic_Reload_RoundLoaded,
		Generic_Reload_ClipLoaded,
		Generic_Reload_Complete,
		Generic_Throw_ReleaseItem,
		Generic_Use_Now,
		Generic_Use_Complete,
		Struggle_GetUp_Complete,
		Struggle_Play_MauledMuffled,
		Struggle_Stop_MauledMuffled,
		PlayerStunned_Begin,
		StartResumingFov,
		Generic_Reload_RoundsUnloaded,
		Generic_Reload_ShowReloadBulletInstance,
		Struggle_Revolver_Fire,
		Struggle_Revolver_Fire_Complete,
		Discharge_Shell_Event,
		Spray_Complete,
		Erase_Paint_Complete,
		NoiseMaker_Explode_In_Hand_Complete
	}

	private class AnimatorParametersCache
	{
		private Dictionary<Animator, Dictionary<int, bool>> m_ParametersCache;

		[CalledBy(Type = typeof(AnimatorParametersCache), Member = "DoesParameterExists")]
		[CalledBy(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
		[CallsUnknownMethods(Count = 18)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 7)]
		public Dictionary<int, bool> RefreshCache(Animator animator)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(AnimatorParametersCache), Member = "RefreshCache")]
		[CallsUnknownMethods(Count = 2)]
		public bool DoesParameterExists(Animator animator, int paramHash)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 8)]
		[CalledBy(Type = typeof(PlayerAnimation), Member = ".ctor")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		public AnimatorParametersCache()
		{
		}
	}

	public bool m_EnableAnimationDrivenViewBob;

	public GameObject m_Root;

	public GameObject m_WorldSpaceView;

	public GameObject m_WeaponSpaceView;

	public ClothingSpawner m_ClothingSpawner;

	public SerializedParams m_SerializedParams;

	public Camera m_WeaponCamera;

	public Camera m_InspectCamera;

	public float m_WeaponCameraFOV;

	public float m_InspectCameraFOV;

	public GameObject m_CameraSpaceObject;

	public GameObject m_CameraBone;

	public GameObject m_CameraFOV;

	public bool m_DebugOverrideCameraFov;

	public Vector3 m_OverrideCameraFOV;

	public float m_MaxBlurSize;

	public Animator m_Animator;

	public StruggleMeshTable m_StruggleMeshTable;

	public GameObject m_FPMesh_MaleHands;

	public GameObject m_FPMesh_FemaleHands;

	public GameObject[] m_ClothingItems;

	public GameObject[] m_ActiveTorsoClothing;

	public GameObject[] m_ActiveHandsClothing;

	public GameObject[] m_ActiveStoryTorsoClothing;

	public GameObject[] m_ActiveStoryHandsClothing;

	public GameObject m_RightPropPoint;

	public GameObject m_LeftPropPoint;

	public GameObject m_ShoulderPropPoint;

	public GameObject m_ArrowSpawnPropPoint;

	public GameObject m_ArrowFirePropPoint;

	public GameObject m_ShoulderJoint;

	public GameObject m_CameraWeaponOffset;

	public GameObject m_GAMEDATA;

	public float m_LookDegreesPerSecond;

	public CameraBasedHandPositioningMode m_CameraBasedHandPositioningMode;

	public bool m_DisableCameraTracking;

	public CameraBasedJointPositioning m_CameraTracking_Standard;

	public CameraBasedJointPositioning m_CameraTracking_Aiming;

	public CameraBasedJointPositioning m_CameraTracking_None;

	public float m_DampedVelocitySeconds;

	[NonSerialized]
	public bool m_CameraRelativeToHands;

	private int m_FingersLayerIndex;

	private int m_HipLayerIndex;

	private int m_ShoulderOffsetLayerIndex;

	private bool m_ItemEquippedByPlayer;

	public const AnimationLayerFlags DEFAULT_INTERACT_DISABLED_LAYERS = (AnimationLayerFlags)3;

	public static readonly int NumStates;

	private PlayerStateTransitions m_PlayerStateTransitions;

	private GameObject m_HandsMesh;

	private GameObject m_EnabledWeapon;

	private List<Animator> m_GlobalAnimators;

	private Dictionary<AnimationCallbackEvent, OnAnimationEvent> m_AnimationEventDictionary;

	private FirstPersonWeapon m_EquippedFirstPersonWeaponRightHand;

	private FirstPersonWeapon m_EquippedFirstPersonWeaponLeftHand;

	private FirstPersonWeapon m_EquippedFirstPersonWeaponShoulder;

	private Vector3 m_LookAtTarget;

	private Vector2 m_StartCameraAngles;

	private bool m_LookAtActive;

	private bool m_StartHasBeenCalled;

	private State m_State;

	private State m_PriorState;

	private Vector3[] m_LastVelocities;

	private float[] m_LastVelocitiesTimestamps;

	private int m_DampedVelocityIndex;

	private OnAnimationEvent m_AnimationEvent_Generic_Aim_Complete;

	private OnAnimationEvent m_AnimationEvent_Generic_Aim_Cancel_Complete;

	private OnAnimationEvent m_AnimationEvent_Generic_AnimatedInteractionComplete;

	private OnAnimationEvent m_AnimationEvent_Generic_BrandishBegin;

	private OnAnimationEvent m_AnimationEvent_Generic_BrandishMidSwing;

	private OnAnimationEvent m_AnimationEvent_Generic_Ignite;

	private OnAnimationEvent m_AnimationEvent_Generic_IgniteComplete;

	private OnAnimationEvent m_AnimationEvent_Generic_Equip_ShowItem;

	private OnAnimationEvent m_AnimationEvent_Generic_Equip_Complete;

	private OnAnimationEvent m_AnimationEvent_Generic_Fire_FX;

	private OnAnimationEvent m_AnimationEvent_Generic_Fire_Complete;

	private OnAnimationEvent m_AnimationEvent_Generic_Hidden;

	private OnAnimationEvent m_AnimationEvent_Generic_HiddenComplete;

	private OnAnimationEvent m_AnimationEvent_Generic_ExtinguishFX;

	private OnAnimationEvent m_AnimationEvent_Generic_PlacementMode_PlaceItem;

	private OnAnimationEvent m_AnimationEvent_Generic_PlacementMode_PlaceComplete;

	private OnAnimationEvent m_AnimationEvent_Generic_RoundLoaded;

	private OnAnimationEvent m_AnimationEvent_Generic_ClipLoaded;

	private OnAnimationEvent m_AnimationEvent_Generic_RoundsUnloaded;

	private OnAnimationEvent m_AnimationEvent_Generic_ReloadComplete;

	private OnAnimationEvent m_AnimationEvent_Generic_Throw_ReleaseItem;

	private OnAnimationEvent m_AnimationEvent_Generic_UseNow;

	private OnAnimationEvent m_AnimationEvent_Generic_UseComplete;

	private OnAnimationEvent m_AnimationEvent_Generic_StruggleRevolverFired;

	private OnAnimationEvent m_AnimationEvent_Generic_StruggleRevolverFiredComplete;

	private OnAnimationEvent m_AnimationEvent_Spray_Complete;

	private OnAnimationEvent m_AnimationEvent_Erase_Paint_Complete;

	private OnAnimationEvent m_AnimationEvent_NoiseMaker_Explode_In_Hand_Complete;

	private int m_AnimParameter_CameraPitch;

	private int m_AnimParameter_HasUnloadedAmmo;

	private int m_AnimParameter_IsAiming;

	private int m_AnimParameter_IsBurnedOut;

	private int m_AnimParameter_IsEquipped;

	private int m_AnimParameter_IsJammed;

	private int m_AnimParameter_IsLightSource;

	private int m_AnimParameter_Is_Limping_Left;

	private int m_AnimParameter_Is_Limping_Right;

	private int m_AnimParameter_Is_Climbing;

	private int m_AnimParameter_IsLoaded;

	private int m_AnimParameter_IsSurvivor;

	private int m_AnimParameter_IsWeapon;

	private int m_AnimParameter_Lightsource_IgniterIsFire;

	private int m_AnimParameter_Lightsource_Lit;

	private int m_AnimParameter_MovementForward;

	private int m_AnimParameter_MovementForwardDamped;

	private int m_AnimParameter_MovementSideways;

	private int m_AnimParameter_MovementSidewaysDamped;

	private int m_AnimParameter_MovementSpeed;

	private int m_AnimParameter_MovementInput;

	private int m_AnimParameter_ReloadCount;

	private int m_AnimParameter_RoundsLoaded;

	private int m_AnimParameter_SprintInput;

	private int m_AnimParameter_Stamina;

	private int m_AnimParameter_StumbleId;

	private int m_AnimParameter_Trigger_Breakdown_Intro;

	private int m_AnimParameter_Trigger_Breakdown_Cancel;

	private int m_AnimParameter_Trigger_Breakdown_StartLoop;

	private int m_AnimParameter_Trigger_Breakdown_ExitLoop;

	private int m_AnimParameter_Trigger_Generic_Aim;

	private int m_AnimParameter_Trigger_Generic_Aim_Cancel;

	private int m_AnimParameter_Trigger_Generic_Brandish;

	private int m_AnimParameter_Trigger_Generic_Equip;

	private int m_AnimParameter_Trigger_Generic_Equip_Immediate;

	private int m_AnimParameter_Trigger_Generic_Extinguish;

	private int m_AnimParameter_Trigger_Generic_Extinguish_Cancel;

	private int m_AnimParameter_Trigger_Generic_Fire;

	private int m_AnimParameter_Trigger_Generic_Hip_Fire;

	private int m_AnimParameter_Trigger_Generic_Ignite;

	private int m_AnimParameter_Trigger_Generic_Ignite_Confirm;

	private int m_AnimParameter_Trigger_Generic_Ignite_Cancel;

	private int m_AnimParameter_Trigger_Generic_Kill;

	private int m_AnimParameter_Trigger_Generic_PlacementMode_Pickup;

	private int m_AnimParameter_Trigger_Generic_PlacementMode_Place;

	private int m_AnimParameter_Trigger_Generic_Reload_Single;

	private int m_AnimParameter_Trigger_Generic_Stow;

	private int m_AnimParameter_Trigger_Generic_Throw;

	private int m_AnimParameter_Trigger_Generic_Unstow;

	private int m_AnimParameter_Trigger_Generic_Unequip;

	private int m_AnimParameter_Trigger_Limp;

	private int m_AnimParameter_Trigger_Struggle_Start;

	private int m_AnimParameter_Trigger_Struggle_End;

	private int m_AnimParameter_Trigger_Stumble;

	private int m_AnimParameter_Trigger_Generic_Use;

	private int m_AnimParameter_WeaponId;

	private int m_AnimParameter_WeaponId_Float;

	private int m_AnimParameter_WeaponFatigue;

	private int m_AnimParameter_WildlifeId;

	private int m_AnimParameter_SetSpearMultiplier;

	private int m_AnimParameter_RecoverSpearMultiplier;

	private int m_AnimParameter_PlaybackSpeedMultiplier;

	private int m_AnimParameter_AimStaminaDepleted;

	private float m_DefaultPlaybackSpeedMultiplier;

	private int m_AnimParameter_Trigger_Spear_Struggle_Entry;

	private int m_AnimParameter_Trigger_Spear_Exit_Success;

	private int m_AnimParameter_Trigger_Spear_Exit_Fail;

	private int m_AnimParameter_Trigger_Spear_Exit_Success_Death;

	private int m_AnimParameter_Struggle_Revolver_Available;

	private int m_AnimParameter_Struggle_Fire_Revolver;

	private int m_AnimParameter_Trigger_WolfPassBite;

	private int m_AnimParameter_Spray;

	private int m_AnimParameter_Erase_Paint;

	private int m_AnimParameter_NoiseMaker_Explode_In_Hand;

	private int m_AnimParameter_CameraLookPitch;

	private int m_AnimParameter_CameraLookYaw;

	private int m_AnimParameter_Trigger_Free_Look;

	private int m_AnimParameter_Trigger_Free_Look_End;

	private int m_AnimState_Idle;

	private int m_AnimState_FreeLook;

	private float m_FadeAudioCinematicGoal;

	private CameraLayer m_CameraLayer;

	private int m_HipAndShoulderOffsetLayerDisableCount;

	private float m_HipAndShoulderOffsetLayerTimer;

	private bool m_HipAndShoulderOffsetLayerFadeOutRequested;

	private bool m_HipAndShoulderOffsetLayerOverride;

	private AnimatorParametersCache m_AnimatorParametersCache;

	private CinematicManager m_FPCinematicManager;

	private bool m_CinematicRefPotsitionInitialized;

	private Vector3 m_WorldSpaceViewRefPosition;

	private Quaternion m_WorldSpaceViewRefRotation;

	private bool m_EnableMotionFromRef;

	private AnimationLayerFlags m_AnimatedInteractionLayersDisabled;

	private Vector2 m_FreeLookCameraYawLimit;

	private Vector2 m_FreeLookCameraPitchLimit;

	private float m_FreeLookCameraYaw;

	private float m_FreeLookCameraPitch;

	private Vector3 m_FrozenPosition;

	private Quaternion m_FrozenRotation;

	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	private void OnEnvironmentChanged(bool isIndoor)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "DisableAllClothing")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraBasedHandPositioningMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 349)]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "GetLayerIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(Animator), Member = "GetLayerIndex")]
	[Calls(Type = typeof(Animator), Member = "GetLayerIndex")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 50)]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Start")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public void RequestMotionFromRef(Vector3 refPosition, Quaternion refRotation)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsMotionFromRefEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool IsHipShoulderLayerDisabledPending()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void EnableHipAndShoulderOffsetLayerOverride(bool enable)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsMovementLockedBecauseOfLantern")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private void MaybeFadeoutHipShoulder(Vector3 localVelocity)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(InputManager), Member = "GetSprintDown")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateAnimatorSpeed")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateLookAtTarget")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeUpdateCinematicFade")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetSprintStaminaRemainingAsPercentage")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ComputeDampedVelocity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void SetFreeCameraLookLimits(Vector2 pitchLimit, Vector2 yawLimit)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DisableFreeCameraLook")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "EnablePlayerFreeCameraMovement")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableFreeCameraLook")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "DisablePlayerFreeCameraMovement")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	public void UpdateFreeCameraLook(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 22)]
	private void OnAnimatorMove()
	{
	}

	[CallerCount(Count = 0)]
	public void DisableMotionFromRef()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInjectComplete")]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInject")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearParametersCache")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableWeapon")]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	private void ResetBoolIfExists(int hash)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "DisableWeapon")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	private void ResetWeaponParams()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_AnimatedInteractionComplete")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_HiddenComplete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_PlacementMode_PlaceItem_Complete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Use_Complete")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetWeaponParams")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	private void ResetParams()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	public void ResetStruggleStartEnd()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 51)]
	public bool FirstPersonHandsEnabled(GearItem gearItem)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "HidePrevious")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	public bool FirstPersonHandsEnabled(int weaponID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ClearParametersCache()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool MaybeSetState(State state)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public State GetState()
	{
		return default(State);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public bool GetAnimatorIsIdle()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsCurrentState(int fullPathHash)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool TryGetFXObject(string name, out GameObject fxGameObject)
	{
		fxGameObject = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "PanViewCameraIsDetached")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool GetFirstPersonWeaponCanSwitch()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[CallsUnknownMethods(Count = 4)]
	public void SaveCameraBasedHandPositioning(RuntimeAnimatorController controller)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void LoadCameraBasedHandPositioning(RuntimeAnimatorController controller)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[CallsUnknownMethods(Count = 1)]
	public void RestoreCameraBasedHandPositioning()
	{
	}

	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LateUpdate")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "UpdateJoint")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[CallsUnknownMethods(Count = 19)]
	public void UpdateShoulderRotation()
	{
	}

	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	private void UpdateActiveJointPositioning()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool AnimIsPlaying(int id)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	public void CancelReload()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	public void Trigger_Struggle_Start(StruggleBonus.StruggleWeaponType weaponType, WildlifeType wildlifeType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Spear_Struggle_Start()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[CallsUnknownMethods(Count = 2)]
	public void SetParameterSetSpearMultiplier(float multiplier)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Recovering")]
	[CallsUnknownMethods(Count = 2)]
	public void SetParameterRecoverSpearMultiplier(float multiplier)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableWeapon")]
	[CallerCount(Count = 0)]
	public void Trigger_Struggle_End()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsUnknownMethods(Count = 3)]
	public bool Trigger_Brandish(OnAnimationEvent brandishBegin, OnAnimationEvent midSwingEvent)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_BrandishMidSwing()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void OnAnimationEvent_BrandishComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_BrandishBegin()
	{
	}

	[CallerCount(Count = 0)]
	public bool BrandishIsPlaying()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoTriggerAnimation")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[CalledBy(Type = typeof(Action_TriggerAnimatedInteraction), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_TriggerAnimatedInteraction), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnEnterPlaying")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterOutro")]
	public void Trigger_AnimatedInteraction(string trigger, bool weaponSpace, OnAnimationEvent onCompleteCallback, AnimationLayerFlags layersEnabled)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterPrepareStruggle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	public void Trigger_AnimatedInteraction(int trigger, bool weaponSpace, OnAnimationEvent onCompleteCallback, AnimationLayerFlags layersDisabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	public void DisableHipAndShoulderOffsetLayer()
	{
	}

	[CalledBy(Type = typeof(Action_ShowPanel), Member = "MaybeUpdateBodyHarvest")]
	[CalledBy(Type = typeof(Action_ShowPanel), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnOutroComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_AnimatedInteractionComplete")]
	[CalledBy(Type = typeof(Action_ResetHitAndShoulderOffsetLayer), Member = "OnExecute")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnSpearStruggleEnd")]
	[CallerCount(Count = 10)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void ResetHipAndShoulderOffsetLayer()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ForceHipAndShoulderOffsetLayerWeigth(float weigth)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "DisableHipAndShoulderOffsetLayer")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayer")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayer")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggleIntro), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnEnterPlaying")]
	[CalledBy(Type = typeof(Action_ShowPanel), Member = "MaybeShowBodyHarvest")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoTriggerAnimation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnSpearHit")]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	private void UpdateHipAndShoulderOffsetLayerWeigth(float weigth)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[CallerCount(Count = 0)]
	private void UpdateHipAndShoulderOffsetLayer(bool enabled)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "ResetHipAndShoulderOffsetLayer")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallsUnknownMethods(Count = 3)]
	private void OnAnimationEvent_AnimatedInteractionComplete()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Trigger_Breakdown_Intro(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Breakdown_StartLoop()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Trigger_Breakdown_Cancel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Breakdown_ExitLoop()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Trigger_Limp()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Trigger_Stumble(int stumbleId)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlashlightItem), Member = "IsLit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Equip_Complete")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(FirstPersonItem), Member = "PlayWieldAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	public void Trigger_Generic_Equip(GearItem gearItem, bool immediate, OnAnimationEvent showItemEventCallback, OnAnimationEvent equepCompleteEventCallback)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnAnimationEvent_Generic_Equip_ShowItem()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CallsUnknownMethods(Count = 7)]
	private void OnAnimationEvent_Generic_Equip_Complete()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	public bool Trigger_Generic_Unequip(OnAnimationEvent extinguishFxCallback, OnAnimationEvent hideCallback, OnAnimationEvent completeCallback)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void OnMatchBurntOut()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Hidden")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BowItem), Member = "OnDequip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	public void DropCurrentItemInHand()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	public void OnAnimationEvent_Generic_Hidden()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetLightSources")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnAnimationEvent_Generic_HiddenComplete()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	public void Trigger_Generic_Stow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void OnAnimationEvent_Generic_Stow()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	public void Trigger_Generic_Unstow()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_BearSpearStruggleAnimation(BearSpearStruggleOutcome outcome)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_WolfPassBite()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Spray(OnAnimationEvent sprayCompleteCallback)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	public void Trigger_Erase_Paint(OnAnimationEvent erasePaintCompleteCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_NoiseMaker_Explode_In_Hand(OnAnimationEvent completeCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_Free_Look()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_Free_Look_End()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CallerCount(Count = 0)]
	public void SetStruggleRevolverAvailableToFire(bool isAvailable)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	public void SetStruggleRevolverFired(bool hasFired, OnAnimationEvent onRevolverFired, OnAnimationEvent onRevolverFiredComplete)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void OnAnimationEvent_Generic_Unstow_Complete()
	{
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOn")]
	[CalledBy(Type = typeof(TorchItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(MatchesItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(FlareItem), Member = "IgniteDelayed")]
	public void Trigger_Generic_Ignite(bool isFire)
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateEffects")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOn")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	public void Trigger_Generic_Ignite_Confirm(OnAnimationEvent ignite_FX_Callback, OnAnimationEvent ignite_Complete_Callback)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(FlareItem), Member = "CancelIgnite")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(MatchesItem), Member = "CancelIgnite")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "CancelIgnite")]
	[CalledBy(Type = typeof(TorchItem), Member = "CancelIgnite")]
	[CallsUnknownMethods(Count = 1)]
	public void Trigger_Generic_Ignite_Cancel()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnAnimationEvent_Generic_Ignite()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsUnknownMethods(Count = 1)]
	private void OnAnimationEvent_Generic_IgniteComplete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOffDelayed")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOff")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(TorchItem), Member = "ExtinguishAfterDelayStarted")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallerCount(Count = 3)]
	public bool Trigger_Generic_Extinguish(OnAnimationEvent animationEventCallback)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	public void Trigger_Generic_Extinguish_Cancel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	private void OnAnimationEvent_Generic_Extinguish_FX()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void OnAnimationEvent_Generic_Extinguish_Complete()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceImmediately")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ReadyForPlacementDropAnimation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallerCount(Count = 2)]
	public void Trigger_Generic_PlacementMode_Place(OnAnimationEvent placementPlaceAnimationEventCallback, OnAnimationEvent placementCompleteAnimationEventCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	private void OnAnimationEvent_Generic_PlacementMode_HideItemInHands()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_PlacementMode_SpawnItemInWorld()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CallsUnknownMethods(Count = 6)]
	private void OnAnimationEvent_Generic_PlacementMode_PlaceItem_Complete()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "SetFresh")]
	[CalledBy(Type = typeof(MatchesItem), Member = "PutOut")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "SetFresh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "SetFresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Update_Lightsource_Lit(bool lit, bool isFresh)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsAllowedToFire")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsBowAllowedToFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	public void Trigger_Generic_Fire(int roundsInClip, bool willJam, OnAnimationEvent fxEventCallback, OnAnimationEvent completeEventCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Fire_FX()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	private void OnAnimationEvent_Generic_Fire_Complete()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SetBulletsToReload")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UnJam")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public void Trigger_Generic_Reload(int bulletsToReload, int roundsLoaded, bool willJam, OnAnimationEvent roundLoadedEventCallback, OnAnimationEvent clipLoadedEventCallback, OnAnimationEvent reloadCompleteEventCallback, OnAnimationEvent roundsUnloadedEventCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Round_Loaded()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Clip_Loaded()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Rounds_Unloaded()
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private void OnAnimationEvent_Generic_ShowReloadBulletInstance()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnAnimationEvent_Struggle_Revolver_Fire()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Struggle_Revolver_Fire_Complete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(GunItem), Member = "PlayCasingAudio")]
	[CallsUnknownMethods(Count = 6)]
	private void OnAnimationEvent_Discharge_Shell_Event()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void OnAnimationEvent_Spray_Complete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsUnknownMethods(Count = 1)]
	private void OnAnimationEvent_Erase_Paint_Complete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Explode_In_Hand_Complete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsUnknownMethods(Count = 4)]
	private void OnAnimationEvent_Generic_Reload_Complete()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	public void UpdateReloadCount(int bulletsToReload, int roundsLoaded, bool willJam)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public void UpdateJamParameters(bool willJam)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(StoneItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(GunItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_Generic_Aim(OnAnimationEvent onAnimationComplete)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnAnimationEvent_Generic_Aim_Complete()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Recovering")]
	[CalledBy(Type = typeof(GunItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(StoneItem), Member = "ZoomEnd")]
	public void Trigger_Generic_Aim_Cancel(OnAnimationEvent onAnimationComplete, bool exhausted)
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "ForceReady")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	public void Trigger_Generic_BowAim_Cancel(OnAnimationEvent onAnimationComplete)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsUnknownMethods(Count = 1)]
	public void OnAnimationEvent_Generic_Aim_Cancel_Complete()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	public void Trigger_Generic_Use(OnAnimationEvent useNowEventCallback, OnAnimationEvent useCompleteEventCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Use_Now()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CallsUnknownMethods(Count = 4)]
	private void OnAnimationEvent_Generic_Use_Complete()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void OnAnimationEvent_Generic_LookAround_Complete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Struggle_GetUp_Complete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 3)]
	private void OnAnimationEvent_Struggle_Play_MauledMuffle()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnAnimationEvent_Struggle_Stop_MauledMuffle()
	{
	}

	[Calls(Type = typeof(PlayerStunned), Member = "Begin")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWithMoose")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetStunnedDurationFromParter")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetStunnedDurationFromParter")]
	[CallsUnknownMethods(Count = 6)]
	private void OnAnimationEvent_PlayerStunned_Begin()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnAnimationEvent_StartResumingFov()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	public bool Trigger_Generic_Throw(OnAnimationEvent releaseItemCallback, OnAnimationEvent throwCompleteCallback)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	private void OnAnimationEvent_Generic_Throw_ReleaseItem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_Generic_Kill(OnAnimationEvent killCompleteCallback)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Update_Aiming(bool aiming)
	{
	}

	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(Inventory), Member = "GetNumStones")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 15)]
	public void Update_HasUnloadedAmmo()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CallerCount(Count = 0)]
	public void Update_IsLoaded(bool isLoaded)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Update_WeaponFatigue(float fatigue)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_ShowHideHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Spear_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_hands")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(ShowHands), Member = "DoAction")]
	[Calls(Type = typeof(ClothingSpawner), Member = "EnableActiveClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableActiveClothing")]
	public void ShowHands()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_ShowHideHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_HiddenComplete")]
	[CalledBy(Type = typeof(ShowHands), Member = "DoAction")]
	[Calls(Type = typeof(ClothingSpawner), Member = "EnableActiveClothing")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableAllClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_hands")]
	public void HideHands()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[CallsUnknownMethods(Count = 5)]
	public void SetEquippedWeaponLeftHandVisible(bool visible)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetEquippedWeaponRightHandVisible(bool visible)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[CallsUnknownMethods(Count = 5)]
	public void SetEquippedWeaponShoulderVisible(bool visible)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_SetFpHands), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_SetFpHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fphands_mesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ClothingSpawner), Member = "GetCurrentHands")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	public void SetHandMeshState(string name)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableActiveClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void DisableAllClothing()
	{
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatorParametersCache), Member = "RefreshCache")]
	[CallsUnknownMethods(Count = 8)]
	private bool GetParamExists(Animator animator, int paramHash)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 51)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	private void SetTrigger(int trigger)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	private void SetBool(int boolVar, bool boolVal)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Fire_Complete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateReloadCount")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateReloadCount")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	private void SetInt(int intVar, int intVal)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_WeaponFatigue")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetFloat(int floatVar, float floatVal)
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	private void ResetTrigger(int trigger)
	{
	}

	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Equip_ShowItem")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Hidden")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Throw_ReleaseItem")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_PlacementMode_HideItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(Utils), Member = "UseHigherPrecisionTimestep")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	private void EnableEquipped(bool active)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableAllClothing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EnableActiveClothing()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Breakdown_Intro")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Struggle_Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StruggleMeshTable), Member = "GetMesh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void EnableWeapon(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StruggleMeshTable), Member = "GetMesh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GameObject GetRevolverMuzzleFlashGO(StruggleBonus.StruggleWeaponType weaponType)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Struggle_End")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetWeaponParams")]
	public void DisableWeapon()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Stop")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 9)]
	public static void SetLayerOnObjectRecursively(GameObject gameObject, int layer)
	{
	}

	[CallerCount(Count = 0)]
	public CameraLayer GetCameraLayer()
	{
		return default(CameraLayer);
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Spear_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Breakdown_Intro")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(global::CameraLayer), Member = "OnStateUpdate")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_AnimatedInteractionComplete")]
	[CalledBy(Type = typeof(global::CameraLayer), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	public void SetCameraLayer(CameraLayer cameraLayer)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(global::CameraBasedHandPositioningMode), Member = "OnStateMachineExit")]
	[CalledBy(Type = typeof(CellToilet), Member = "OnGottenUp")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(global::CameraBasedHandPositioningMode), Member = "OnStateMachineEnter")]
	public void SetCameraBasedHandPositioningMode(CameraBasedHandPositioningMode mode)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CameraBasedHandPositioningMode GetCameraBasedPositioningMode()
	{
		return default(CameraBasedHandPositioningMode);
	}

	[CallerCount(Count = 40)]
	public void ClearOutstandingCallbacks()
	{
	}

	[CalledBy(Type = typeof(FlyMode), Member = "TeleportPlayerAndExit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FlyMode), Member = "Enter")]
	[CalledBy(Type = typeof(FlyMode), Member = "Exit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public void ShowPlayer(bool show)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TriggerAnimationCallback), Member = "OnStateExit")]
	[CalledBy(Type = typeof(TriggerAnimationCallback), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(TriggerAnimationCallback), Member = "OnStateExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(TriggerAnimationCallback), Member = "OnStateUpdate")]
	public bool TriggerCallback(AnimationCallbackEvent animationCallbackEvent)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "WinHunted2Challenge")]
	public void DraggingAnimationEnd()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallerCount(Count = 1)]
	public void MaybeDropAndResetCurrentWeapon()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsLooking()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void LookAt(Vector3 target)
	{
	}

	[CallerCount(Count = 0)]
	public void CancelLookAt()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Vector3), Member = "RotateTowards")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void UpdateLookAtTarget()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 4)]
	public bool GetCinematicBlurValue(out float value)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref value) = null;
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioFade")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioFade")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "SetCinematicBlackout")]
	[CallsDeduplicatedMethods(Count = 5)]
	private void MaybeUpdateCinematicFade()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsAnimationDrivenViewBobEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[CallsUnknownMethods(Count = 4)]
	public float GetAimingZoomBlend()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public bool CanInteract()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsDequipping()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsUnstowing()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsStowed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsAiming()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsEnteringAiming()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsAimingDownSight()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsReloading()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[CallsUnknownMethods(Count = 6)]
	public bool IsBowAllowedToFire()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsInteractionAllowed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsShowing()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[CalledBy(Type = typeof(GunItem), Member = "IsAiming")]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	public bool IsAllowedToFire(bool allowHipFire)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool IsAllowedToAim()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "StartDetailSurvey")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Throw")]
	[CallsUnknownMethods(Count = 4)]
	public bool CanTransitionToState(State state)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private Vector3 ComputeDampedVelocity(Vector3 newVelocity)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[CalledBy(Type = typeof(PlayerManager), Member = "KnockedDownByAI")]
	[CallsUnknownMethods(Count = 8)]
	public void Trigger_Knockdown()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public List<Animator> GetGlobalAnimationList()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void RegisterAnimator(Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterAnimator(Animator animator)
	{
	}

	[Calls(Type = typeof(FirstPersonLightSource), Member = "Reset")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_HiddenComplete")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ResetLightSources()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Hidden")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Throw_ReleaseItem")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_AnimatedInteractionComplete")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	public void TurnOffEffects()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void TurnOnEffects()
	{
	}

	[CallerCount(Count = 0)]
	public void SetItemEquippedByPlayer(bool equippedByPlayer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public void SetLimp(bool islimpingleft, bool islimpingright)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public void SetClimbing(bool value)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetHipLayerIndex()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterNPC")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 7)]
	public CinematicManager GetFPCinematicManager()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateAnimatorSpeed()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Reset")]
	[CallerCount(Count = 0)]
	public void ResetStandardAimingMode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	[CallsUnknownMethods(Count = 1)]
	public void FullResetAimingModes()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "ResetForStruggle")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "ResetForStruggle")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetAimingModesForStruggle()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 81)]
	[Calls(Type = typeof(AnimatorParametersCache), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 101)]
	public PlayerAnimation()
	{
	}
}
