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
	[Calls(Type = typeof(FootStepSounds), Member = "SetPlayerVelocityRTPC")]
	[Calls(Type = typeof(FootStepSounds), Member = "SetPlayerInclineRTPC")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(SprainedAnkle), Member = "DoLimpAnimation")]
	[Calls(Type = typeof(SprainedAnkle), Member = "MaybeLimpOrStumbleWithFootStep")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(EffectPool<>), Member = "SpawnUntilParticlesDone")]
	[Calls(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
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
	[CallerCount(Count = 0)]
	public void UseFastFootsteps(bool fast)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool UsingFastFootsteps()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(EffectPool<>), Member = "SpawnUntilParticlesDone")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void PlayWaterSplashVFX(Vector3 footPos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	public void PlayFootStepSound(Vector3 footPos, string tag)
	{
	}

	[CalledBy(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "MaybePlaceFootstep")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetPlayerGroundMaterialSwitch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void PlayFootStepSound(Vector3 footPos, string tag, State state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	public void LeaveFootPrint(Vector3 footPos, bool isLeft, bool bothFeet = false, float forceDeepFrac = 0f)
	{
	}

	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "LeaveFootPrint")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "MaybePlaceFootstep")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "IsFootprintPositionValid")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void MaybeLeaveFootPrint(Vector3 footPos, bool bothFeet = false, float forceDeepFrac = 0f)
	{
	}

	[CalledBy(Type = typeof(FootStepSounds), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void SetPlayerVelocityRTPC()
	{
	}

	[CalledBy(Type = typeof(FootStepSounds), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	private void SetPlayerInclineRTPC()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FootStepSounds()
	{
	}
}
