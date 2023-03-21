using System;
using System.Collections.Generic;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

			[DeduplicatedMethod]
			[CallerCount(Count = 6)]
			private AnimationCallbackEventComparer()
			{
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			public bool Equals(AnimationCallbackEvent x, AnimationCallbackEvent y)
			{
				return false;
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			public int GetHashCode(AnimationCallbackEvent animationCallbackEvent)
			{
				return 0;
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

		[CalledBy(Type = typeof(AnimatorParametersCache), Member = "DoesParameterExists")]
		[CalledBy(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 10)]
		public Dictionary<int, bool> RefreshCache(Animator animator)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
		[CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(AnimatorParametersCache), Member = "RefreshCache")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public bool DoesParameterExists(Animator animator, int paramHash)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
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
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void OnEnvironmentChanged(bool isIndoor)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Animator), Member = "GetLayerIndex")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableAllClothing")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraBasedHandPositioningMode")]
	[CallsDeduplicatedMethods(Count = 69)]
	[CallsUnknownMethods(Count = 216)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	[CallsUnknownMethods(Count = 1)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	private bool IsHipShoulderLayerDisabledPending()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void EnableHipAndShoulderOffsetLayerOverride(bool enable)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(GameManager), Member = "IsMovementLockedBecauseOfLantern")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 7)]
	private void MaybeFadeoutHipShoulder(Vector3 localVelocity)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ComputeDampedVelocity")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(InputManager), Member = "GetSprintDown")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateAnimatorSpeed")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateLookAtTarget")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeUpdateCinematicFade")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 15)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void SetFreeCameraLookLimits(Vector2 pitchLimit, Vector2 yawLimit)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableFreeCameraLook")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DisableFreeCameraLook")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "EnablePlayerFreeCameraMovement")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "DisablePlayerFreeCameraMovement")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateFreeCameraLook(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 13)]
	private void OnAnimatorMove()
	{
	}

	[CallerCount(Count = 0)]
	public void DisableMotionFromRef()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInject")]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInjectComplete")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableWeapon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ResetBoolIfExists(int hash)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DisableWeapon")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ResetWeaponParams()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_AnimatedInteractionComplete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_HiddenComplete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_PlacementMode_PlaceItem_Complete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Use_Complete")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetWeaponParams")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[CallsUnknownMethods(Count = 1)]
	private void ResetParams()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	public void ResetStruggleStartEnd()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 52)]
	public bool FirstPersonHandsEnabled(GearItem gearItem)
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[CallsUnknownMethods(Count = 3)]
	public bool FirstPersonHandsEnabled(FPSItem itemData)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearParametersCache()
	{
	}

	[CallerCount(Count = 56)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetFloat")]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[CallsUnknownMethods(Count = 3)]
	private bool MaybeSetState(State state)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public State GetState()
	{
		return default(State);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool GetAnimatorIsIdle()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsCurrentState(int fullPathHash)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[CallsUnknownMethods(Count = 1)]
	public bool TryGetFXObject(string name, out GameObject fxGameObject)
	{
		fxGameObject = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "PanViewCameraIsDetached")]
	[CallsUnknownMethods(Count = 1)]
	public bool GetFirstPersonWeaponCanSwitch()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[CallsUnknownMethods(Count = 1)]
	public void SaveCameraBasedHandPositioning(RuntimeAnimatorController controller)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[CallsUnknownMethods(Count = 1)]
	public void LoadCameraBasedHandPositioning(RuntimeAnimatorController controller)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[CallsUnknownMethods(Count = 1)]
	public void RestoreCameraBasedHandPositioning()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LateUpdate")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "UpdateJoint")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateShoulderRotation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateActiveJointPositioning()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool AnimIsPlaying(int id)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	public void CancelReload()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetParameterSetSpearMultiplier(float multiplier)
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Recovering")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetParameterRecoverSpearMultiplier(float multiplier)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableWeapon")]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Struggle_End()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool Trigger_Brandish(OnAnimationEvent brandishBegin, OnAnimationEvent midSwingEvent)
	{
		return false;
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
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoTriggerAnimation")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnBack")]
	[CalledBy(Type = typeof(Action_TriggerAnimatedInteraction), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnEnterPlaying")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterOutro")]
	[CallerCount(Count = 6)]
	public void Trigger_AnimatedInteraction(string trigger, bool weaponSpace, OnAnimationEvent onCompleteCallback, AnimationLayerFlags layersEnabled)
	{
	}

	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterPrepareStruggle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_AnimatedInteraction(int trigger, bool weaponSpace, OnAnimationEvent onCompleteCallback, AnimationLayerFlags layersDisabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
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

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateHipAndShoulderOffsetLayerWeigth(float weigth)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	private void UpdateHipAndShoulderOffsetLayer(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_AnimatedInteractionComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Breakdown_Intro(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Breakdown_StartLoop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Breakdown_Cancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Breakdown_ExitLoop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Limp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Stumble(int stumbleId)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "ShowNext")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(FlashlightItem), Member = "IsLit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 10)]
	public void Trigger_Generic_Equip(GearItem gearItem, bool immediate, OnAnimationEvent showItemEventCallback, OnAnimationEvent equepCompleteEventCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Equip_ShowItem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnAnimationEvent_Generic_Equip_Complete()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool Trigger_Generic_Unequip(OnAnimationEvent extinguishFxCallback, OnAnimationEvent hideCallback, OnAnimationEvent completeCallback)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void OnMatchBurntOut()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Hidden")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(BowItem), Member = "OnDequip")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DropCurrentItemInHand()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnAnimationEvent_Generic_Hidden()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetLightSources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnAnimationEvent_Generic_HiddenComplete()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StowItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_Generic_Stow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void OnAnimationEvent_Generic_Stow()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_Generic_Unstow()
	{
	}

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
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Spray(OnAnimationEvent sprayCompleteCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Trigger_Erase_Paint(OnAnimationEvent erasePaintCompleteCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public void SetStruggleRevolverAvailableToFire(bool isAvailable)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	public void SetStruggleRevolverFired(bool hasFired, OnAnimationEvent onRevolverFired, OnAnimationEvent onRevolverFiredComplete)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void OnAnimationEvent_Generic_Unstow_Complete()
	{
	}

	[CalledBy(Type = typeof(FlareItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOn")]
	[CalledBy(Type = typeof(MatchesItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(TorchItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void Trigger_Generic_Ignite(bool isFire)
	{
	}

	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOn")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateEffects")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_Generic_Ignite_Confirm(OnAnimationEvent ignite_FX_Callback, OnAnimationEvent ignite_Complete_Callback)
	{
	}

	[CalledBy(Type = typeof(FlareItem), Member = "CancelIgnite")]
	[CalledBy(Type = typeof(MatchesItem), Member = "CancelIgnite")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "CancelIgnite")]
	[CalledBy(Type = typeof(TorchItem), Member = "CancelIgnite")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "CancelAction")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Trigger_Generic_Ignite_Cancel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Ignite()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_IgniteComplete()
	{
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOff")]
	[CalledBy(Type = typeof(TorchItem), Member = "ExtinguishAfterDelayStarted")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOffDelayed")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool Trigger_Generic_Extinguish(OnAnimationEvent animationEventCallback)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_Generic_Extinguish_Cancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void OnAnimationEvent_Generic_Extinguish_FX()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void OnAnimationEvent_Generic_Extinguish_Complete()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceImmediately")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ReadyForPlacementDropAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
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
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnAnimationEvent_Generic_PlacementMode_PlaceItem_Complete()
	{
	}

	[CalledBy(Type = typeof(MatchesItem), Member = "PutOut")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "SetFresh")]
	[CallsUnknownMethods(Count = 1)]
	public void Update_Lightsource_Lit(bool lit, bool isFresh)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsBowAllowedToFire")]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsAllowedToFire")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[CallsUnknownMethods(Count = 1)]
	public void Trigger_Generic_Fire(int roundsInClip, bool willJam, OnAnimationEvent fxEventCallback, OnAnimationEvent completeEventCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Fire_FX()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Fire_Complete()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UnJam")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SetBulletsToReload")]
	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(GunItem), Member = "PlayCasingAudio")]
	[CallsUnknownMethods(Count = 2)]
	private void OnAnimationEvent_Discharge_Shell_Event()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void OnAnimationEvent_Spray_Complete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Erase_Paint_Complete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Explode_In_Hand_Complete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimationEvent_Generic_Reload_Complete()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetInt")]
	public void UpdateReloadCount(int bulletsToReload, int roundsLoaded, bool willJam)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public void UpdateJamParameters(bool willJam)
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[CalledBy(Type = typeof(GunItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(StoneItem), Member = "ZoomStart")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Trigger_Generic_Aim(OnAnimationEvent onAnimationComplete)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnAnimationEvent_Generic_Aim_Complete()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_Recovering")]
	[CalledBy(Type = typeof(GunItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(StoneItem), Member = "ZoomEnd")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void Trigger_Generic_Aim_Cancel(OnAnimationEvent onAnimationComplete, bool exhausted)
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CalledBy(Type = typeof(BowItem), Member = "ForceReady")]
	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Trigger_Generic_BowAim_Cancel(OnAnimationEvent onAnimationComplete)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	private void OnAnimationEvent_Struggle_Play_MauledMuffle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	private void OnAnimationEvent_Struggle_Stop_MauledMuffle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWithMoose")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetStunnedDurationFromParter")]
	[Calls(Type = typeof(PlayerStunned), Member = "Begin")]
	[CallsUnknownMethods(Count = 2)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Update_Aiming(bool aiming)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[Calls(Type = typeof(Inventory), Member = "GetNumStones")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Update_HasUnloadedAmmo()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public void Update_IsLoaded(bool isLoaded)
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 1)]
	public void Update_WeaponFatigue(float fatigue)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_hands")]
	[CalledBy(Type = typeof(ShowHands), Member = "DoAction")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Spear_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(Action_ShowHideHands), Member = "OnExecute")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingSpawner), Member = "EnableActiveClothing")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableActiveClothing")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void ShowHands()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_hands")]
	[CalledBy(Type = typeof(ShowHands), Member = "DoAction")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_HiddenComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[CalledBy(Type = typeof(Action_ShowHideHands), Member = "OnExecute")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingSpawner), Member = "EnableActiveClothing")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableAllClothing")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void HideHands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SetEquippedWeaponLeftHandVisible(bool visible)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SetEquippedWeaponRightHandVisible(bool visible)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SetEquippedWeaponShoulderVisible(bool visible)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fphands_mesh")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(Action_SetFpHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetFpHands), Member = "DoWork")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingSpawner), Member = "GetCurrentHands")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void SetHandMeshState(string name)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableActiveClothing")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	public void DisableAllClothing()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetBoolIfExists")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetWeaponParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetInt")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetFloat")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(AnimatorParametersCache), Member = "RefreshCache")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private bool GetParamExists(Animator animator, int paramHash)
	{
		return false;
	}

	[CallerCount(Count = 54)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void SetTrigger(int trigger)
	{
	}

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void SetBool(int boolVar, bool boolVal)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Fire_Complete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateReloadCount")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void SetInt(int intVar, int intVal)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_WeaponFatigue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void SetFloat(int floatVar, float floatVal)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetParams")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetStruggleStartEnd")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetParamExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void ResetTrigger(int trigger)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Equip_ShowItem")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Hidden")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_PlacementMode_HideItemInHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Throw_ReleaseItem")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "UseHigherPrecisionTimestep")]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void EnableEquipped(bool active)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableAllClothing")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	public void EnableActiveClothing()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Breakdown_Intro")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StruggleMeshTable), Member = "GetMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableWeapon(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StruggleMeshTable), Member = "GetMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public GameObject GetRevolverMuzzleFlashGO(StruggleBonus.StruggleWeaponType weaponType)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Struggle_End")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetWeaponParams")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DisableWeapon()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Stop")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public static void SetLayerOnObjectRecursively(GameObject gameObject, int layer)
	{
	}

	[CallerCount(Count = 0)]
	public CameraLayer GetCameraLayer()
	{
		return default(CameraLayer);
	}

	[CalledBy(Type = typeof(global::CameraLayer), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(global::CameraLayer), Member = "OnStateUpdate")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Spear_Struggle_Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_AnimatedInteractionComplete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Breakdown_Intro")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	public void SetCameraLayer(CameraLayer cameraLayer)
	{
	}

	[CalledBy(Type = typeof(global::CameraBasedHandPositioningMode), Member = "OnStateMachineEnter")]
	[CalledBy(Type = typeof(global::CameraBasedHandPositioningMode), Member = "OnStateMachineExit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void SetCameraBasedHandPositioningMode(CameraBasedHandPositioningMode mode)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CameraBasedHandPositioningMode GetCameraBasedPositioningMode()
	{
		return default(CameraBasedHandPositioningMode);
	}

	[CallerCount(Count = 41)]
	public void ClearOutstandingCallbacks()
	{
	}

	[CalledBy(Type = typeof(FlyMode), Member = "Enter")]
	[CalledBy(Type = typeof(FlyMode), Member = "Exit")]
	[CalledBy(Type = typeof(FlyMode), Member = "TeleportPlayerAndExit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ShowPlayer(bool show)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(TriggerAnimationCallback), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(TriggerAnimationCallback), Member = "OnStateExit")]
	[CalledBy(Type = typeof(TriggerAnimationCallback), Member = "OnStateUpdate")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool TriggerCallback(AnimationCallbackEvent animationCallbackEvent)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CallsUnknownMethods(Count = 1)]
	public void DraggingAnimationEnd()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[Calls(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void MaybeDropAndResetCurrentWeapon()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsLooking()
	{
		return false;
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateLookAtTarget()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool GetCinematicBlurValue(out float value)
	{
		value = default(float);
		return false;
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioFade")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeUpdateCinematicFade()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsAnimationDrivenViewBobEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public float GetAimingZoomBlend()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public bool CanInteract()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsDequipping()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsUnstowing()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsStowed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsAiming()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsEnteringAiming()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsAimingDownSight()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsReloading()
	{
		return false;
	}

	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public bool IsBowAllowedToFire()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsInteractionAllowed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsShowing()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(GunItem), Member = "IsAiming")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsAllowedToFire(bool allowHipFire)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool IsAllowedToAim()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "StartDetailSurvey")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Throw")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanTransitionToState(State state)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private Vector3 ComputeDampedVelocity(Vector3 newVelocity)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void Trigger_Knockdown()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public List<Animator> GetGlobalAnimationList()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterAnimator(Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterAnimator(Animator animator)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_HiddenComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetLightSources()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_AnimatedInteractionComplete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Hidden")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Throw_ReleaseItem")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[CallsUnknownMethods(Count = 1)]
	public void TurnOffEffects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[CallsUnknownMethods(Count = 1)]
	public void TurnOnEffects()
	{
	}

	[CallerCount(Count = 0)]
	public void SetItemEquippedByPlayer(bool equippedByPlayer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public void SetLimp(bool islimpingleft, bool islimpingright)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	public void SetClimbing(bool value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetHipLayerIndex()
	{
		return 0;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterNPC")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public CinematicManager GetFPCinematicManager()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateAnimatorSpeed()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void ResetStandardAimingMode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	[CallsUnknownMethods(Count = 1)]
	public void FullResetAimingModes()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetAimingModesForStruggle()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 81)]
	[CallsUnknownMethods(Count = 103)]
	public PlayerAnimation()
	{
	}
}
