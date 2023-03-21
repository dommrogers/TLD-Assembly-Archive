using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HuntedPart2WaypointController : MonoBehaviour
{
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

	private bool m_DoneInit;

	private bool m_StartHasBeenCalled;

	private HuntedPart2WaypointControllerState m_State;

	private static HuntedPart2WaypointControllerSaveData m_HuntedPart2WaypointControllerSaveData;

	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "IgnoreAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "UseFixedStalkingSpeed")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BloodTrail), Member = "GetDecalProjectorType")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "IsHuntedBear2ChallengeEnd")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(BaseAi), Member = "IsDamageFatal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateWounds")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	public static bool IsHuntedBear(BaseAi bai)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static int GetCurrentWaypoint(string text)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "PlayEnterFleeAudio")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ProcessHitByPlayer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "WaypointsInitialize")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "WaypointsInitialize")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "GoToCurrentWaypoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "SetCurrentWaypoint")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "Deserialize")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	public bool GoToCurrentWaypoint()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ProcessHitByPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "GoToCurrentWaypoint")]
	[Calls(Type = typeof(WeatherSet), Member = "ForceStep")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(WeatherSet), Member = "ForceStep")]
	public void IncrementWaypoint()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 12)]
	public bool InRangeOfTargetWaypoint()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public HuntedPart2Waypoint.WaypointType GetCurrentWaypointType()
	{
		return default(HuntedPart2Waypoint.WaypointType);
	}

	[CallerCount(Count = 0)]
	public bool FinalAmbushStarted()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool AwaitingFinalAmbush()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CallsUnknownMethods(Count = 1)]
	public void WinChallenge()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hunted2_endgame")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	public void ForceEndGame()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 6)]
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

	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "Start")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	private void WaypointsInitialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool SkipWaypointFollowingBasedOnAiMode()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeDisableDuplicateBear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HuntedPart2WaypointController()
	{
	}
}
