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

		[CallerCount(Count = 265)]
		[DeduplicatedMethod]
		public OnOffTransitionInfo(PlayerClimbRope pcr)
		{
		}

		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
		[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
		[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
		[CallerCount(Count = 1)]
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

	private sealed class _003CPutPlayerOnRopeAfterDeserialize_003Ed__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerClimbRopeProxy saveProxy;

		public PlayerClimbRope _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CPutPlayerOnRopeAfterDeserialize_003Ed__125(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "PutPlayerOnRopeAfterDeserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[IteratorStateMachine(typeof(_003CPutPlayerOnRopeAfterDeserialize_003Ed__125))]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator PutPlayerOnRopeAfterDeserialize(PlayerClimbRopeProxy saveProxy)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "MaybeSlipOrFall")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "UpdateFatigue")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "UpdateStamina")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	public void UpdateClimbing()
	{
	}

	[Calls(Type = typeof(Spline), Member = "GetClosestPointParam")]
	[Calls(Type = typeof(Spline), Member = "GetTangentToSpline")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Utils), Member = "NearestPointInfinite")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Spring), Member = ".ctor")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "OnRopeTransition")]
	[CalledBy(Type = typeof(RopeClimbPoint), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(_003CPutPlayerOnRopeAfterDeserialize_003Ed__125), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 63)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Spring), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = "GetTangentToSpline")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "FindLowestValidTOnSpline")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "EnablePhysicsHelper")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CallsDeduplicatedMethods(Count = 36)]
	[CallerCount(Count = 2)]
	public void BeginClimbing(Rope r, float initialSplineT = -1f)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Spline), Member = "GetPositionInternal")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(RopeExitPoint), Member = "PerformInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public void RequestExitToPoint(Rope r, RopeExitPoint rep)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
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

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndSlipHandling")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	public void RequestExitAfterFall(Transform camT)
	{
	}

	[Calls(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
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

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[Calls(Type = typeof(RopeClimbPoint), Member = "OnRopeTransition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RopeLedge), Member = "OnRopeTransition")]
	private void OnRopeTransition(bool onRope)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	private void SetClimbingState()
	{
	}

	[Calls(Type = typeof(ODE3), Member = "Update2")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(ODE), Member = "Update2")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "RequestExitTopOrBottom")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateClimbing")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(ODE), Member = "Update2")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 31)]
	[Calls(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(OnOffTransitionInfo), Member = "Update")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "GetAdjustedViewAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "GetAdjustedViewAngles")]
	private void UpdatePosition()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "SlipBegin")]
	private Vector3 GetSlipStageParams(int i, float baseT, float limitT, float scalar, float splineLen)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "EnablePhysicsHelper")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "StopSounds")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SnapRope")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "EnablePhysicsHelper")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "RequestExitAfterFall")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "StopSounds")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(PlayerClimbRope), Member = "EnablePhysicsHelper")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Spline), Member = "GetClosestPointParam")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "StopSounds")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	private void HandleSlipStage(out float swayOffset, out float pitchOffset, out float rollOffset)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref swayOffset) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref pitchOffset) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref rollOffset) = null;
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopSounds(ref uint voId, ref uint soundId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerClimbRope), Member = "EnablePhysicsHelper")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "RequestExitAfterFall")]
	[CallsUnknownMethods(Count = 3)]
	private void EndSlipHandling()
	{
	}

	[CallerCount(Count = 0)]
	private ClimbingState GetClimbingState()
	{
		return default(ClimbingState);
	}

	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[Calls(Type = typeof(Spline), Member = "GetTangentToSpline")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "DeltaAngle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Spline), Member = "GetTangentToSpline")]
	[CallerCount(Count = 2)]
	private bool GetAdjustedViewAngles(ref Vector2 viewAngles, out float rollScalar)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref rollScalar) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "MaybePlaceFootstep")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "SlipBegin")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PlayerClimbRope), Member = "SetClimbSpeed")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Spline), Member = "GetTangentToSpline")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[Calls(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[Calls(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybePlaceFootstep(float oldPhase, float newPhase, float splineT, Vector3 splinePos)
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateClimbing")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetNormalizedSprintReduction")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateClimbing")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
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
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerClimbRope), Member = "GetSlipStageParams")]
	private void SlipBegin(float slipDistance)
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndSlipHandling")]
	[CallsUnknownMethods(Count = 6)]
	private void EnablePhysicsHelper(bool isFalling)
	{
	}

	[CallerCount(Count = 0)]
	public PlayerClimbRope()
	{
	}
}
