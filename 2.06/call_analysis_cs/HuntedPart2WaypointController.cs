using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.Serialization;
using UnityEngine;

public class HuntedPart2WaypointController : MonoBehaviour
{
	private ChallengeConfig m_HuntedPart2Config;

	private MissionObjectIdentifier m_WaypointMissionObject;

	private MissionObjectIdentifier m_WaypointSetMissionObject;

	private HuntedPart2Waypoint[] m_Waypoints;

	private int m_CurrentWaypoint;

	private int m_CurrentWeatherStage;

	private float m_WaypointIncrementTimer;

	private float m_WaypointWanderPauseTimer;

	private bool m_WanderPaused;

	private bool m_WanderingAroundPoint;

	private BaseAi m_BaseAI;

	private float m_DetectionRangeOrig;

	private float m_DetectionFOVOrig;

	private float m_HearFootstepsRangeOrig;

	private float m_HearRifleRangeOrig;

	private float m_HearCarAlarmRangeOrig;

	private float m_SmellRangeOrig;

	private bool m_StartHasBeenCalled;

	private HuntedPart2WaypointControllerState m_State;

	private static ChallengeConfig s_HuntedPart2Config;

	private static readonly HuntedPart2WaypointControllerSaveData m_HuntedPart2WaypointControllerSaveData;

	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "IsHuntedBear2ChallengeEnd")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "IsDamageFatal")]
	[CalledBy(Type = typeof(BloodTrail), Member = "GetDecalProjectorType")]
	[CalledBy(Type = typeof(BaseAi), Member = "UseFixedStalkingSpeed")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "IgnoreAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsDamageFatal")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateWounds")]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "InRequiredGameMode")]
	public static bool IsHuntedBear(BaseAi bai)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static int GetCurrentWaypoint(string text)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "PlayEnterFleeAudio")]
	[CallsUnknownMethods(Count = 2)]
	public void ProcessHitByPlayer()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "WaypointsInitialize")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "Start")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "GoToCurrentWaypoint")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "GoToCurrentWaypoint")]
	public void SetCurrentWaypoint(int waypoint)
	{
	}

	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "Deserialize")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "SetCurrentWaypoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public bool GoToCurrentWaypoint()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ProcessHitByPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "GoToCurrentWaypoint")]
	[Calls(Type = typeof(WeatherSetData), Member = "ForceStep")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(WeatherSetData), Member = "ForceStep")]
	public void IncrementWaypoint()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public bool InRangeOfTargetWaypoint()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public HuntedPart2Waypoint.WaypointType GetCurrentWaypointType()
	{
		return default(HuntedPart2Waypoint.WaypointType);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool FinalAmbushStarted()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool AwaitingFinalAmbush()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CallsUnknownMethods(Count = 1)]
	public void WinChallenge()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hunted2_endgame")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	public void ForceEndGame()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[CallsUnknownMethods(Count = 1)]
	private static bool InRequiredGameMode()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetPlayerEyePosition")]
	private bool ShouldDoWanderPause()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void ToggleDetection(bool enableDetection)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "Start")]
	private void WaypointsInitialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool SkipWaypointFollowingBasedOnAiMode()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool MaybeDisableDuplicateBear()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public HuntedPart2WaypointController()
	{
	}
}
