using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using SuperSplines;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class PlayerClimbRope : MonoBehaviour
{
	private class OnOffTransitionInfo
	{
		private PlayerClimbRope m_PCR;

		public bool m_IsGetOn;

		public bool m_IsExitFromFall;

		public RopeTransitionPoint m_Type;

		public float m_TimeFull;

		public float m_TimePart;

		public Vector3 m_Pivot;

		public Quaternion m_Rot;

		public float m_ViewLen;

		public Vector3 m_ViewAngles;

		public Vector3 m_FromAngles;

		public Vector3 m_FromPos;

		public float Frac
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(float);
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 279)]
		public OnOffTransitionInfo(PlayerClimbRope pcr)
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
		[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
		[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
		[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
		[CallsUnknownMethods(Count = 7)]
		public Vector3 Update(Vector3 camPos, Vector3 splinePos, Vector3 splineTan, Vector3 splineNorm, float yaw, ref float roll, ref Vector2 viewAngles)
		{
			return default(Vector3);
		}

		[CallerCount(Count = 0)]
		public bool IsComplete()
		{
			return default(bool);
		}
	}

	private sealed class _003CPutPlayerOnRopeAfterDeserialize_003Ed__125 : IDisposable, IEnumerator<object>, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerClimbRopeProxy saveProxy;

		public PlayerClimbRope _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003CPutPlayerOnRopeAfterDeserialize_003Ed__125(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
		[Calls(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public float m_ClimbSpeedUpFullyRested;

	public float m_ClimbSpeedUpExhausted;

	public float m_ClimbSpeedDownFullyRested;

	public float m_ClimbSpeedDownExhausted;

	public float m_LowStaminaSpeedScaleThreshold;

	public float m_LowestStaminaSpeedScale;

	public float m_StaminaDrainPerSecondClimbingUp;

	public float m_StaminaDrainPerSecondClimbingDown;

	public float m_StaminaDrainPerSecondClimbingHolding;

	public float m_FatigueDrainPerSecondClimbingUp;

	public float m_FatigueDrainPerSecondClimbingDown;

	public float m_FatigueDrainPerSecondClimbingHolding;

	public Vector2 m_PitchLimitDegrees;

	public Vector2 m_YawLimitDegrees;

	public float m_SlipRollMinSeconds;

	public float m_SlipRollMaxSeconds;

	public float m_SlipChanceInitial;

	public float m_SlipChanceIncreasePerRoll;

	public float m_SlipDropDistanceMin;

	public float m_SlipDropDistanceMax;

	public float m_FallChanceInitial;

	public float m_FallChanceIncreasePerRoll;

	public float m_FallDeathThreshold;

	public float m_FallBelowGroundLiftedPositionOffset;

	public bool m_Anim_ConstrainPitchDuringClimb;

	public float m_Anim_ConstrainedPitchAngle;

	public float m_Anim_GetOnDuration;

	public float m_Anim_GetOnTopTimePerMeter;

	public float m_Anim_GetOffDuration;

	public float m_Anim_GetUpAfterFallDuration;

	public float m_Anim_ClimbSpeedToAnimScalar;

	public float m_Anim_UnitMotion;

	public float m_Anim_DirectionTransitionTime;

	public float m_Anim_SplineBasisBlendTime;

	public float m_Anim_SplineRollBlendTime;

	public float m_Anim_ProjectionSineOffset;

	public Vector2 m_Anim_ProjectionDistances;

	public Vector2 m_Anim_PitchRanges;

	public float m_Anim_SideSwaySineOffset;

	public Vector2 m_Anim_SideSwayDistances;

	public float m_Anim_DropBackSineOffset;

	public Vector2 m_Anim_DropBackDistances;

	public float m_Anim_OvershootSineOffset;

	public Vector2 m_Anim_OvershootDistances;

	public float m_Anim_FootOffset;

	public float m_Anim_ClimbUpLookaheadDistance;

	public float m_Anim_TopStepToSideDistance;

	public Vector3 m_Anim_HeadPosSpringStiffness;

	public Vector3 m_Anim_HeadPosSpringDampening;

	public float m_Anim_PitchSpringStiffness;

	public float m_Anim_PitchSpringDampening;

	public float m_Anim_RollSpringStiffness;

	public float m_Anim_RollSpringDampening;

	public string m_Audio_GetOn;

	public string m_Audio_GetOff;

	public string m_Audio_AboutToSlip;

	public string m_Audio_FallStart;

	public string m_Audio_FallStop;

	public string m_Audio_SlipStart;

	public string m_Audio_SlipStop;

	public string m_Audio_AboutToSlip_VO;

	public string m_Audio_FallStart_VO;

	public string m_Audio_FallStop_VO;

	public string m_Audio_SlipStart_VO;

	public string m_Audio_SlipStop_VO;

	public string m_Audio_ClimbExertion_VO;

	public string m_Audio_RopeSnap;

	public bool m_BlockCameraPitch;

	public bool m_BlockCameraYaw;

	public bool m_IsFalling;

	private Rope m_Rope;

	private float m_ClimbSpeed;

	private float m_CurrentSplineParameter;

	private ClimbingState m_ClimbingState;

	private bool m_FallWillRecover;

	private float m_FallHeight;

	private float m_SpeedScaleByStamina;

	private Vector2 m_StartPitchLimit;

	private Vector2 m_StartYawLimit;

	private float m_GroundOffset;

	private float m_MinSplineTAtTop;

	private float m_MaxSplineTAtBottom;

	private int m_FindGroundCollisionLayer;

	private float m_SplineTBeforeEdge;

	private float m_Anim_Phase;

	private float m_Anim_Direction;

	private Vector3 m_Anim_SplineNormal;

	private Vector3 m_Anim_SplineLat;

	private float m_Anim_RequestSlip;

	private float m_Anim_SlipTargetT;

	private float m_Anim_SlipBaseT;

	private float m_Anim_SlipTimer;

	private Vector3[] m_Anim_SlipStageParams;

	private int m_Anim_SlipStageIndex;

	private float m_Anim_SlipScalar;

	private float m_Anim_LastSlipPitch;

	private float m_Anim_LastSlipRoll;

	private float m_Anim_LastSlipSwayOffset;

	private Vector3 m_Anim_FallRestPos;

	private float m_Anim_CameraPitch;

	private float m_Anim_CameraRoll;

	private const float ROPE_TOP_T = 0.2f;

	private const float ROPE_BASE_T = 0.6f;

	private float m_NoStaminaTimerSeconds;

	private float m_NextSlipRollSeconds;

	private float m_NextSlipChance;

	private float m_NextFallChance;

	private Transform m_RopePhysicsHelper;

	private Transform m_RopePhysicsHelper_Head;

	private bool m_ForceBlendedValues;

	private Spring3 m_HeadSpring;

	private Spring m_PitchSpring;

	private Spring m_RollSpring;

	private uint m_SlipAudioId;

	private uint m_SlipVOId;

	private uint m_FallAudioId;

	private uint m_FallVOId;

	private bool m_HasPlayedSnapAudio;

	private OnOffTransitionInfo m_OnOffTransition;

	private bool m_StartHasBeenCalled;

	private static PlayerClimbRopeProxy m_PlayerClimbRopeProxy;

	private const int NUM_SLIP_STAGES = 4;

	private const int NUM_FALL_STAGES = 6;

	public bool IsSlipping
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(_003CPutPlayerOnRopeAfterDeserialize_003Ed__125))]
	private IEnumerator PutPlayerOnRopeAfterDeserialize(PlayerClimbRopeProxy saveProxy)
	{
		return null;
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "UpdateStamina")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "UpdateFatigue")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "MaybeSlipOrFall")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateClimbing()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Utils), Member = "NearestPointInfinite")]
	[Calls(Type = typeof(Spring), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = "GetTangentToSpline")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "OnRopeTransition")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(RopeClimbPoint), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(_003CPutPlayerOnRopeAfterDeserialize_003Ed__125), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 55)]
	[Calls(Type = typeof(Spring), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = "GetClosestPointParam")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = "GetTangentToSpline")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 38)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "EnablePhysicsHelper")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "FindLowestValidTOnSpline")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	public void BeginClimbing(Rope r, float initialSplineT = -1f)
	{
	}

	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[Calls(Type = typeof(Spline), Member = "GetPositionInternal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Spline), Member = "RecalculateParameter")]
	private float FindLowestValidTOnSpline()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshSpringSettings()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(RopeExitPoint), Member = "PerformInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public void RequestExitToPoint(Rope r, RopeExitPoint rep)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public void RequestExitTopOrBottom(Transform camT)
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndSlipHandling")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	public void RequestExitAfterFall(Transform camT)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "OnRopeTransition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	public void EndClimbing(Vector3 endPos, Quaternion endRot)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsInOnOffTransition()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool FallingWithoutRecovery()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[Calls(Type = typeof(RopeLedge), Member = "OnRopeTransition")]
	[Calls(Type = typeof(RopeClimbPoint), Member = "OnRopeTransition")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	private void OnRopeTransition(bool onRope)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	private void SetClimbingState()
	{
	}

	[Calls(Type = typeof(ODE), Member = "Update2")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(ODE3), Member = "Update2")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "RequestExitTopOrBottom")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateClimbing")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(Utils), Member = "ExpFilterWeight")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "GetAdjustedViewAngles")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "GetAdjustedViewAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(OnOffTransitionInfo), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(ODE), Member = "Update2")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 1)]
	private void UpdatePosition()
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "SlipBegin")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private Vector3 GetSlipStageParams(int i, float baseT, float limitT, float scalar, float splineLen)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "EnablePhysicsHelper")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "LookupAnchorPointFromRope")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SnapRope")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "EnablePhysicsHelper")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "RequestExitAfterFall")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "StopSounds")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(PlayerClimbRope), Member = "EnablePhysicsHelper")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Spline), Member = "GetClosestPointParam")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "StopSounds")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "StopSounds")]
	private void HandleSlipStage(out float swayOffset, out float pitchOffset, out float rollOffset)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref swayOffset) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref pitchOffset) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref rollOffset) = null;
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	private void StopSounds(ref uint voId, ref uint soundId)
	{
	}

	[Calls(Type = typeof(PlayerClimbRope), Member = "RequestExitAfterFall")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerClimbRope), Member = "EnablePhysicsHelper")]
	private void EndSlipHandling()
	{
	}

	[CallerCount(Count = 0)]
	private ClimbingState GetClimbingState()
	{
		return default(ClimbingState);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[Calls(Type = typeof(Spline), Member = "GetTangentToSpline")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Spline), Member = "GetTangentToSpline")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "DeltaAngle")]
	private bool GetAdjustedViewAngles(ref Vector2 viewAngles, out float rollScalar)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref rollScalar) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "SlipBegin")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "MaybePlaceFootstep")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Spline), Member = "GetTangentToSpline")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "SetClimbSpeed")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallerCount(Count = 2)]
	private Vector3 GetPositionOnRope(bool allowMotion, out Vector3 splinePos, out Vector3 splineTan, out Vector3 splineNorm, out Vector3 splineLat, out float splinePitch, out float splineRoll)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref splinePos) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref splineTan) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref splineNorm) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref splineLat) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref splinePitch) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref splineRoll) = null;
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[Calls(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	private void MaybePlaceFootstep(float oldPhase, float newPhase, float splineT, Vector3 splinePos)
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateClimbing")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "GetNormalizedSprintReduction")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallerCount(Count = 1)]
	private void UpdateStamina()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateClimbing")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateFatigue()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[CallerCount(Count = 1)]
	private void SetClimbSpeed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeFallDueToRopeBreak()
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateClimbing")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	private void MaybeSlipOrFall()
	{
	}

	[CallerCount(Count = 0)]
	private void RequestFall()
	{
	}

	[CallerCount(Count = 0)]
	private void RequestSlip(float slipDistance)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "GetSlipStageParams")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	private void SlipBegin(float slipDistance)
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndSlipHandling")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	private void EnablePhysicsHelper(bool isFalling)
	{
	}

	[CallerCount(Count = 0)]
	public PlayerClimbRope()
	{
	}
}
