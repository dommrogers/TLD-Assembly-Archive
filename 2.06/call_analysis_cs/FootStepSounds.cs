using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FootStepSounds : MonoBehaviour
{
	private enum State
	{
		Normal,
		Limp
	}

	public float m_CrouchWalkStepDistance;

	public float m_WalkStepDistance;

	public float m_StrideStepDistance;

	public float m_SprintStepDistance;

	public float m_FastStepsMultiplier;

	public float m_EncumberedMultiplier;

	public float m_FootPrintSideOffset;

	public float m_FootPrintBackOffset;

	public Vector3 m_DecalProjectorScale;

	public bool m_SupressFoostepAudio;

	private float m_MovedDistance;

	private string m_MaterialTagLastFootstep;

	private bool m_UseFastFootsteps;

	private bool m_LeftFootStep;

	private bool m_IgnoreNextFootStep;

	private float m_LastPlayerSpeedRTPC;

	private float m_LastPlayerInclineRTPC;

	private float m_NextUpdateTimeforPlayerInclineRTPC;

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FootStepSounds), Member = "SetPlayerVelocityRTPC")]
	[Calls(Type = typeof(FootStepSounds), Member = "SetPlayerInclineRTPC")]
	public void Update()
	{
	}

	[Calls(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[Calls(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(SprainedAnkle), Member = "DoLimpAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SprainedAnkle), Member = "MaybeLimpOrStumbleWithFootStep")]
	public void AddMoveDistance(float dist, float stepDistanceMultiplier, bool wasStopped, bool isSprinting, bool isCrouched, bool isEncumbered, Vector3 footPos)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	public string GetMaterialTagForLastFootstep()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void UseFastFootsteps(bool fast)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool UsingFastFootsteps()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void PlayWaterSplashVFX(Vector3 footPos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	public void PlayFootStepSound(Vector3 footPos, string tag)
	{
	}

	[CalledBy(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "MaybePlaceFootstep")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetPlayerGroundMaterialSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	private void PlayFootStepSound(Vector3 footPos, string tag, State state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	public void LeaveFootPrint(Vector3 footPos, bool isLeft, bool bothFeet = false, float forceDeepFrac = 0f)
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "LeaveFootPrint")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[Calls(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "MaybePlaceFootstep")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "IsFootprintPositionValid")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void MaybeLeaveFootPrint(Vector3 footPos, bool bothFeet = false, float forceDeepFrac = 0f)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(FootStepSounds), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	private void SetPlayerVelocityRTPC()
	{
	}

	[CalledBy(Type = typeof(FootStepSounds), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void SetPlayerInclineRTPC()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FootStepSounds()
	{
	}
}
