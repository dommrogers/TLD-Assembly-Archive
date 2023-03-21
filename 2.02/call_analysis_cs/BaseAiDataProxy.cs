using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BaseAiDataProxy
{
	public float m_HoursPlayed;

	public float m_TimeInModeSeconds;

	public float m_TimeInModeTODHours;

	public AiMode m_StartMode;

	public AiMode m_CurrentMode;

	public AiMode m_PreviousMode;

	public Vector3 m_SpawnPos;

	public float m_CurrentHP;

	public bool m_BleedingOut;

	public float m_ElapsedBleedingOutMinutes;

	public float m_DeathAfterBleeingOutMinutes;

	public Vector3[] m_Waypoints;

	public int m_TargetWaypointIndex;

	public float m_SleepTimeHours;

	public bool m_Wounded;

	public float m_ElapsedWoundedMinutes;

	public float m_SuppressFootStepDetectionAndSmellSecondsRemaining;

	public bool m_CurrentTargetIsPlayer;

	public DamageSource m_DamageSource;

	public string m_ScriptedSequenceAnimTrigger;

	public string m_Hunted2WaypointControllerSerialized;

	public string m_BearHuntAiSerialized;

	public string m_BearHuntAiReduxSerialized;

	public string m_PackAnimalDataSerialized;

	public bool m_FakeFeeding;

	public Vector3 m_FakeFeedingPos;

	public float m_FakeFeedingDurationHours;

	public bool m_UseForcedFleePos;

	public Vector3 m_ForcedFleePos;

	public bool m_UseWanderDestinationAfterStruggle;

	public Vector3 m_WanderDestinationAfterStruggle;

	public string m_MissionIdSerialized;

	public Vector3 m_FleeFromPos;

	public int m_FleeReason;

	public BaseAi.PointOfInterest[] m_PointsOfInterest;

	public int m_TargetPointOfInterestIndex;

	public bool m_RandomizePointsOfInterest;

	public AiMode m_DefaultMode;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public BaseAiDataProxy()
	{
	}
}
