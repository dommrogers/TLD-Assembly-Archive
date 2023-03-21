using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using SuperSplines;
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SpotlightAimer), Member = "GetLightSourceOrigin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	[CallsDeduplicatedMethods(Count = 10)]
	private void DRAW_TEMP_SPHERE_INDICATOR(Vector3 position)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeRandomBulletShots()
	{
	}

	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	private void MaybeBulletDamage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	[CallsUnknownMethods(Count = 2)]
	private void MissionFailure()
	{
	}

	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlayVO")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpotLightController), Member = "MaybeRandomBulletShots")]
	private void UpdateDetectionStage()
	{
	}

	[CallerCount(Count = 0)]
	private bool WasDetected()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void UpdateSpotLight()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(SpotLightController), Member = "MaybeTrackPlayer")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private bool IsWithinPathConstraints()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpotLightController), Member = "IsWithinPathConstraints")]
	private void MaybeTrackPlayer()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "MoveToValue")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateTarget()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsPlayerInLight()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsPlayerInLinkedSpotlight()
	{
		return default(bool);
	}

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybePlaySound(string soundName)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SpotLightController), Member = "MaybePlaySearchSound")]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	private void MaybePlayVO(string voName)
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybeTrackPlayer")]
	[Calls(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySearchSound")]
	[Calls(Type = typeof(SpotLightController), Member = "UpdateTarget")]
	[Calls(Type = typeof(SpotLightController), Member = "IsPlayerInLinkedSpotlight")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlayVO")]
	[CallerCount(Count = 1)]
	private void MaybePlaySearchSound()
	{
	}

	[CallerCount(Count = 0)]
	public SpotLightController()
	{
	}
}
