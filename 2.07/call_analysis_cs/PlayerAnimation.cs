using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gameplay;
using TLD.Gear;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
	public class SerializedParams
	{
		public bool m_EnableFirstPersonHands;

		public string m_HandMeshState;

		public bool m_FirstPersonHandsHidden;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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

	private class AnimationCallbackDictionary<T> : Dictionary<AnimationCallbackEvent, T>
	{
		private class AnimationCallbackEventComparer : IEqualityComparer<AnimationCallbackEvent>
		{
			public static readonly AnimationCallbackEventComparer s_Comparer;

			[CallerCount(Count = 6)]
			[DeduplicatedMethod]
			private AnimationCallbackEventComparer()
			{
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			public bool Equals(AnimationCallbackEvent x, AnimationCallbackEvent y)
			{
				return default(bool);
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			public int GetHashCode(AnimationCallbackEvent animationCallbackEvent)
			{
				return default(int);
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public AnimationCallbackDictionary()
		{
			((Dictionary<TKey, TValue>)(object)this)._002Ector();
		}
	}

	private class AnimatorParametersCache
	{
		private Dictionary<Animator, Dictionary<int, bool>> m_ParametersCache;

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 6)]
		[CalledBy(Type = typeof(AnimatorParametersCache), Member = "DoesParameterExists")]
		[CalledBy(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
		[CallsUnknownMethods(Count = 5)]
		public Dictionary<int, bool> RefreshCache(Animator animator)
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void Clear()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(AnimatorParametersCache), Member = "RefreshCache")]
		[CallsUnknownMethods(Count = 1)]
		public bool DoesParameterExists(Animator animator, int paramHash)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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

	private PanelReference<Panel_HUD> m_HUD;

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

	private readonly AnimationCallbackDictionary<OnAnimationEvent> m_AnimationEventDictionary;

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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[CallsUnknownMethods(Count = 4)]
	private void OnEnvironmentChanged(bool isIndoor)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableAllClothing")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsDeduplicatedMethods(Count = 86)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Start")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public void RequestMotionFromRef(Vector3 refPosition, Quaternion refRotation)
	{
	}

	[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "IsMovementLockedBecauseOfLantern")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	private void MaybeFadeoutHipShoulder(Vector3 localVelocity)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(InputManager), Member = "GetSprintDown")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateAnimatorSpeed")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateLookAtTarget")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeUpdateCinematicFade")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ComputeDampedVelocity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	public void UpdateFreeCameraLook(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 11)]
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
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInjectComplete")]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableWeapon")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DisableWeapon")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
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
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_AnimatedInteractionComplete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_HiddenComplete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_PlacementMode_PlaceItem_Complete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Use_Complete")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetWeaponParams")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
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
	[CallerCount(Count = 53)]
	public bool FirstPersonHandsEnabled(GearItem gearItem)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool FirstPersonHandsEnabled(FPSItem itemData)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ClearParametersCache()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 57)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool TryGetFXObject(string name, out GameObject fxGameObject)
	{
		fxGameObject = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "PanViewCameraIsDetached")]
	[CallsUnknownMethods(Count = 1)]
	public bool GetFirstPersonWeaponCanSwitch()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	public void SaveCameraBasedHandPositioning(RuntimeAnimatorController controller)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LateUpdate")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "UpdateJoint")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	public void UpdateShoulderRotation()
	{
	}

	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	private void UpdateActiveJointPositioning()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
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

	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
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

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Recovering")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	public void SetParameterRecoverSpearMultiplier(float multiplier)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableWeapon")]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Struggle_End()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterPrepareStruggle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_AnimatedInteraction(int trigger, bool weaponSpace, OnAnimationEvent onCompleteCallback, AnimationLayerFlags layersDisabled)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[CallerCount(Count = 0)]
	public void DisableHipAndShoulderOffsetLayer()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ResetHipAndShoulderOffsetLayer()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ForceHipAndShoulderOffsetLayerWeigth(float weigth)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 29)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	private void UpdateHipAndShoulderOffsetLayerWeigth(float weigth)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	private void UpdateHipAndShoulderOffsetLayer(bool enabled)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	private void OnAnimationEvent_AnimatedInteractionComplete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Trigger_Breakdown_Intro(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Breakdown_StartLoop()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Trigger_Breakdown_Cancel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Breakdown_ExitLoop()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void Trigger_Limp()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Trigger_Stumble(int stumbleId)
	{
	}

	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlashlightItem), Member = "IsLit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Trigger_Generic_Equip(GearItem gearItem, bool immediate, OnAnimationEvent showItemEventCallback, OnAnimationEvent equepCompleteEventCallback)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnAnimationEvent_Generic_Equip_ShowItem()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallsUnknownMethods(Count = 3)]
	private void OnAnimationEvent_Generic_Equip_Complete()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsUnknownMethods(Count = 3)]
	public bool Trigger_Generic_Unequip(OnAnimationEvent extinguishFxCallback, OnAnimationEvent hideCallback, OnAnimationEvent completeCallback)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void OnMatchBurntOut()
	{
	}

	[Calls(Type = typeof(BowItem), Member = "OnDequip")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Hidden")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void DropCurrentItemInHand()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	public void OnAnimationEvent_Generic_Hidden()
	{
	}

	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetLightSources")]
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

	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_BearSpearStruggleAnimation(BearSpearStruggleOutcome outcome)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_WolfPassBite()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Trigger_Spray(OnAnimationEvent sprayCompleteCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Erase_Paint(OnAnimationEvent erasePaintCompleteCallback)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public void SetStruggleRevolverAvailableToFire(bool isAvailable)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CallerCount(Count = 1)]
	public void SetStruggleRevolverFired(bool hasFired, OnAnimationEvent onRevolverFired, OnAnimationEvent onRevolverFiredComplete)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void OnAnimationEvent_Generic_Unstow_Complete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[CalledBy(Type = typeof(TorchItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(MatchesItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOn")]
	[CalledBy(Type = typeof(FlareItem), Member = "IgniteDelayed")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	public void Trigger_Generic_Ignite(bool isFire)
	{
	}

	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateEffects")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOn")]
	public void Trigger_Generic_Ignite_Confirm(OnAnimationEvent ignite_FX_Callback, OnAnimationEvent ignite_Complete_Callback)
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "CancelIgnite")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "CancelIgnite")]
	[CalledBy(Type = typeof(MatchesItem), Member = "CancelIgnite")]
	[CalledBy(Type = typeof(FlareItem), Member = "CancelIgnite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	public void Trigger_Generic_Ignite_Cancel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Ignite()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_IgniteComplete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOff")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOffDelayed")]
	[CalledBy(Type = typeof(TorchItem), Member = "ExtinguishAfterDelayStarted")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Toggle")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public bool Trigger_Generic_Extinguish(OnAnimationEvent animationEventCallback)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_Generic_Extinguish_Cancel()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnAnimationEvent_Generic_Extinguish_FX()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnAnimationEvent_Generic_Extinguish_Complete()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceImmediately")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Update")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ReadyForPlacementDropAnimation")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnAnimationEvent_Generic_PlacementMode_PlaceItem_Complete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "SetFresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "SetFresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "SetFresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Update_Lightsource_Lit(bool lit, bool isFresh)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsAllowedToFire")]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsBowAllowedToFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_Generic_Fire(int roundsInClip, bool willJam, OnAnimationEvent fxEventCallback, OnAnimationEvent completeEventCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Fire_FX()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	private void OnAnimationEvent_Generic_Fire_Complete()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SetBulletsToReload")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UnJam")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void OnAnimationEvent_Generic_ShowReloadBulletInstance()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Struggle_Revolver_Fire()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Struggle_Revolver_Fire_Complete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GunItem), Member = "PlayCasingAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnAnimationEvent_Discharge_Shell_Event()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void OnAnimationEvent_Spray_Complete()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	private void OnAnimationEvent_Generic_Reload_Complete()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallerCount(Count = 1)]
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
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	public void Trigger_Generic_Aim(OnAnimationEvent onAnimationComplete)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	public void OnAnimationEvent_Generic_Aim_Complete()
	{
	}

	[CalledBy(Type = typeof(StoneItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(GunItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Recovering")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public void Trigger_Generic_Aim_Cancel(OnAnimationEvent onAnimationComplete, bool exhausted)
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BowItem), Member = "ForceReady")]
	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	public void Trigger_Generic_BowAim_Cancel(OnAnimationEvent onAnimationComplete)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	public void OnAnimationEvent_Generic_Aim_Cancel_Complete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_Generic_Use(OnAnimationEvent useNowEventCallback, OnAnimationEvent useCompleteEventCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Use_Now()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallerCount(Count = 0)]
	private void OnAnimationEvent_Generic_Use_Complete()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void OnAnimationEvent_Generic_LookAround_Complete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallsUnknownMethods(Count = 1)]
	private void OnAnimationEvent_Struggle_GetUp_Complete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void OnAnimationEvent_Struggle_Play_MauledMuffle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	private void OnAnimationEvent_Struggle_Stop_MauledMuffle()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerStunned), Member = "Begin")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWithMoose")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetStunnedDurationFromParter")]
	private void OnAnimationEvent_PlayerStunned_Begin()
	{
	}

	[CallerCount(Count = 0)]
	private void OnAnimationEvent_StartResumingFov()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public bool Trigger_Generic_Throw(OnAnimationEvent releaseItemCallback, OnAnimationEvent throwCompleteCallback)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnAnimationEvent_Generic_Throw_ReleaseItem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	public void Trigger_Generic_Kill(OnAnimationEvent killCompleteCallback)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Update_Aiming(bool aiming)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(Inventory), Member = "GetNumStones")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Update_HasUnloadedAmmo()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public void Update_IsLoaded(bool isLoaded)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Update_WeaponFatigue(float fatigue)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Spear_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(Action_ShowHideHands), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_hands")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ClothingSpawner), Member = "EnableActiveClothing")]
	[CalledBy(Type = typeof(ShowHands), Member = "DoAction")]
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
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_ShowHideHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_HiddenComplete")]
	[CalledBy(Type = typeof(ShowHands), Member = "DoAction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_hands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableAllClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingSpawner), Member = "EnableActiveClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	public void HideHands()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SetEquippedWeaponLeftHandVisible(bool visible)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[CallsUnknownMethods(Count = 3)]
	public void SetEquippedWeaponRightHandVisible(bool visible)
	{
	}

	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetEquippedWeaponShoulderVisible(bool visible)
	{
	}

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Deserialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fphands_mesh")]
	[CalledBy(Type = typeof(Action_SetFpHands), Member = "DoWork")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(ClothingSpawner), Member = "GetCurrentHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Action_SetFpHands), Member = "OnExecute")]
	public void SetHandMeshState(string name)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableActiveClothing")]
	[CallsUnknownMethods(Count = 2)]
	public void DisableAllClothing()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(AnimatorParametersCache), Member = "RefreshCache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 5)]
	private bool GetParamExists(Animator animator, int paramHash)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	private void SetTrigger(int trigger)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	private void SetBool(int boolVar, bool boolVal)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateReloadCount")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateReloadCount")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Fire_Complete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetInt(int intVar, int intVal)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_WeaponFatigue")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetFloat(int floatVar, float floatVal)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ResetTrigger(int trigger)
	{
	}

	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Equip_ShowItem")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Hidden")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Throw_ReleaseItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_PlacementMode_HideItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(Utils), Member = "UseHigherPrecisionTimestep")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void EnableEquipped(bool active)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableAllClothing")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void EnableActiveClothing()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Breakdown_Intro")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Struggle_Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(StruggleMeshTable), Member = "GetMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void EnableWeapon(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(StruggleMeshTable), Member = "GetMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public GameObject GetRevolverMuzzleFlashGO(StruggleBonus.StruggleWeaponType weaponType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Struggle_End")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
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
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	public static void SetLayerOnObjectRecursively(GameObject gameObject, int layer)
	{
	}

	[CallerCount(Count = 0)]
	public CameraLayer GetCameraLayer()
	{
		return default(CameraLayer);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Spear_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Breakdown_Intro")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_AnimatedInteractionComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[CalledBy(Type = typeof(global::CameraLayer), Member = "OnStateUpdate")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[CalledBy(Type = typeof(global::CameraLayer), Member = "OnStateEnter")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	public void SetCameraLayer(CameraLayer cameraLayer)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(global::CameraBasedHandPositioningMode), Member = "OnStateMachineEnter")]
	[CalledBy(Type = typeof(global::CameraBasedHandPositioningMode), Member = "OnStateMachineExit")]
	public void SetCameraBasedHandPositioningMode(CameraBasedHandPositioningMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CameraBasedHandPositioningMode GetCameraBasedPositioningMode()
	{
		return default(CameraBasedHandPositioningMode);
	}

	[CallerCount(Count = 42)]
	public void ClearOutstandingCallbacks()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(FlyMode), Member = "Enter")]
	[CalledBy(Type = typeof(FlyMode), Member = "Exit")]
	[CalledBy(Type = typeof(FlyMode), Member = "TeleportPlayerAndExit")]
	[CallsUnknownMethods(Count = 2)]
	public void ShowPlayer(bool show)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TriggerAnimationCallback), Member = "OnStateUpdate")]
	[CalledBy(Type = typeof(TriggerAnimationCallback), Member = "OnStateExit")]
	[CalledBy(Type = typeof(TriggerAnimationCallback), Member = "OnStateExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(TriggerAnimationCallback), Member = "OnStateEnter")]
	public bool TriggerCallback(AnimationCallbackEvent animationCallbackEvent)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DraggingAnimationEnd()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Hidden")]
	[Calls(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
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
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void UpdateLookAtTarget()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	public bool GetCinematicBlurValue(out float value)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref value) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioFade")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioFade")]
	private void MaybeUpdateCinematicFade()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsAnimationDrivenViewBobEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[CallsUnknownMethods(Count = 3)]
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
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[CallsUnknownMethods(Count = 5)]
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GunItem), Member = "IsAiming")]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
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
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "StartDetailSurvey")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Throw")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanTransitionToState(State state)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private Vector3 ComputeDampedVelocity(Vector3 newVelocity)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[CallsUnknownMethods(Count = 5)]
	public void Trigger_Knockdown()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public List<Animator> GetGlobalAnimationList()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void RegisterAnimator(Animator animator)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void UnregisterAnimator(Animator animator)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_HiddenComplete")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ResetLightSources()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Throw_ReleaseItem")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Hidden")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_AnimatedInteractionComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	public void TurnOffEffects()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CallerCount(Count = 0)]
	public void SetClimbing(bool value)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetHipLayerIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterNPC")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CallsUnknownMethods(Count = 2)]
	public CinematicManager GetFPCinematicManager()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	private void UpdateAnimatorSpeed()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallsUnknownMethods(Count = 5)]
	public void ResetStandardAimingMode()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	public void FullResetAimingModes()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetAimingModesForStruggle()
	{
	}

	[CallsUnknownMethods(Count = 83)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 81)]
	public PlayerAnimation()
	{
	}
}
