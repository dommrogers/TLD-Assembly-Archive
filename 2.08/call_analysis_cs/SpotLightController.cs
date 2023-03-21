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
	[Calls(Type = typeof(SpotlightAimer), Member = "GetLightSourceOrigin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	private void SetDetectionStage(DetectionStageState newStage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	private void PlayEnterStageSound()
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void DRAW_TEMP_SPHERE_INDICATOR(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 14)]
	private void MaybeRandomBulletShots()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
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

	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySound")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Condition), Member = "PlayerDeath")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybeRandomBulletShots")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlayVO")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateDetectionStage()
	{
	}

	[CallerCount(Count = 0)]
	private bool WasDetected()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateSpotLight()
	{
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "MaybeTrackPlayer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 15)]
	private bool IsWithinPathConstraints()
	{
		return false;
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpotLightController), Member = "IsWithinPathConstraints")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeTrackPlayer()
	{
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "MoveToValue")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateTarget()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayerInLight()
	{
		return false;
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayerInLinkedSpotlight()
	{
		return false;
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "SetDetectionStage")]
	[CalledBy(Type = typeof(SpotLightController), Member = "PlayEnterStageSound")]
	[CalledBy(Type = typeof(SpotLightController), Member = "MaybeRandomBulletShots")]
	[CalledBy(Type = typeof(SpotLightController), Member = "MaybeBulletDamage")]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybePlaySound(string soundName)
	{
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[CalledBy(Type = typeof(SpotLightController), Member = "MaybePlaySearchSound")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybePlayVO(string voName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SpotLightController), Member = "IsPlayerInLinkedSpotlight")]
	[Calls(Type = typeof(SpotLightController), Member = "UpdateTarget")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlaySearchSound")]
	[Calls(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybeTrackPlayer")]
	[Calls(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SpotLightController), Member = "MaybePlayVO")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybePlaySearchSound()
	{
	}

	[CallerCount(Count = 0)]
	public SpotLightController()
	{
	}
}
