using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SpotLightController : MonoBehaviour
{
	private enum DetectionStageState
	{
		Stage0,
		Stage1,
		Stage2,
		Stage3,
		Stage4,
		StageDead
	}

	public SpotlightAimer m_Aimer;

	public Transform m_SpotLight;

	public Spline m_PathSpline;

	public float m_PathPeriodSeconds;

	public float m_PathOffsetPercent;

	public bool m_StartReversed;

	public float m_DetectionDistance;

	public float m_DetectionTimer_Stage0;

	public float m_DetectionTimer_Stage1;

	public float m_DetectionTimer_Stage2;

	public float m_DetectionTimer_Stage3;

	public float m_ResetDetectionTimer;

	public string m_Sound_EnterStage0;

	public string m_Sound_EnterStage1;

	public string m_Sound_EnterStage2;

	public string m_Sound_EnterStage3;

	public string m_Sound_EnterStage4;

	public NPCVoice m_Voice;

	public string m_VO_OnDetection;

	public string m_VO_FirstSearch;

	public string m_VO_SubsequentSearch;

	public float m_VO_PlaySearchMinTime;

	public float m_VO_PlaySearchMaxTime;

	public float m_VO_TriggerRange;

	public string m_RifleFireSound;

	public float m_Stage2BulletDistanceMin;

	public float m_Stage2BulletDistanceMax;

	public float m_Stage2BulletSideDistance;

	public int m_Stage2ShotsMin;

	public int m_Stage2ShotsMax;

	public float m_Stage2BulletShotDelayTimer;

	public GameObject m_Stage2BulletImpactFX;

	public float m_Stage2BulletFirstShotDelayTimer;

	public float m_Stage2BulletShotMinTimer;

	public float m_Stage2BulletShotMaxTimer;

	public bool m_Stage3AllowMultipleShots;

	public float m_Stage3BulletDamage;

	public LocalizedString m_Stage3BloodLossFromBullet;

	public float m_Stage3BulletShotMinTimer;

	public float m_Stage3BulletShotMaxTimer;

	public float m_Stage4BulletSoundThreshold;

	public LocalizedString m_FailureMessage;

	public float m_NoDetectionTimer;

	public float m_BlendBackTimeSeconds;

	public float m_MaxTrackingSpeed;

	public float m_TrackingBlendTimeSeconds;

	public List<Transform> m_PathConstraintPoints;

	public float m_MaxPathDistance;

	public List<SpotLightController> m_LinkedSpotlights;

	public bool m_RedetectionJumpToStage3;

	private Vector3 m_MovingTargetPosition;

	private float m_CurrentMoveBlend;

	private float m_CurrentTrackBlend;

	private float m_StageTime;

	private float m_ReturnTime;

	private float m_ResetDetectionTime;

	private float m_BulletShotTime;

	private float m_MasterTimer;

	private bool m_IsDetected;

	private bool m_WasEverDetected;

	private float m_PlayLostSightSoundTimer;

	private int m_ShotCounter;

	private static List<GameObject> s_BulletImpactList;

	private static int s_BulletImpactIndex;

	private static int s_MaxBulletImpactFX;

	public static bool s_Debug;

	private DetectionStageState m_CurrentDetectionStage;

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(SpotlightAimer), Member = "GetLightSourceOrigin")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 4)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	private void SetDetectionStage(DetectionStageState newStage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	private void PlayEnterStageSound()
	{
	}

	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 11)]
	private void DRAW_TEMP_SPHERE_INDICATOR(Vector3 position)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "set_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void MaybeRandomBulletShots()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[CallsUnknownMethods(Count = 8)]
	private void MaybeBulletDamage()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MissionFailure()
	{
	}

	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlayVO")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybeRandomBulletShots")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybeBulletDamage")]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateDetectionStage()
	{
	}

	[CallerCount(Count = 0)]
	private bool WasDetected()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[CallerCount(Count = 2)]
	private void UpdateSpotLight()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(SpotLightController), Member = "MaybeTrackPlayer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	private bool IsWithinPathConstraints()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpotLightController), Member = "IsWithinPathConstraints")]
	private void MaybeTrackPlayer()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "MoveToValue")]
	[Calls(Type = typeof(Mathf), Member = "PingPong")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTarget()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool IsPlayerInLight()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayerInLinkedSpotlight()
	{
		return default(bool);
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybePlaySound(string soundName)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SpotLightController), Member = "MaybePlaySearchSound")]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	private void MaybePlayVO(string voName)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(SpotLightController), Member = "UpdateSpotLight")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybeTrackPlayer")]
	[Calls(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[Calls(Type = typeof(SpotLightController), Member = "UpdateSpotLight")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySearchSound")]
	[Calls(Type = typeof(SpotLightController), Member = "UpdateTarget")]
	[Calls(Type = typeof(SpotLightController), Member = "IsPlayerInLinkedSpotlight")]
	[Calls(Type = typeof(SpotLightController), Member = "IsPlayerInLight")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlayVO")]
	private void MaybePlaySearchSound()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SpotLightController()
	{
	}
}
