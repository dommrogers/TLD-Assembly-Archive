using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BearHuntReduxSettings : ScriptableObject
{
	public float m_PlayerConditionLossPercentAfterMauling;

	public float m_BearDespawnRadius;

	public GameObject m_BearEarPrefab;

	public float m_MaxInitialStalkTimeSeconds;

	public float m_MaxStalkTimeSeconds;

	public float m_PlayerStunnnedDuration;

	public float m_MinDistanceForSpearDrop;

	public float m_MaxDistanceForSpearDrop;

	public float m_StruggleLengthMaxSeconds;

	public float m_SpearStruggleDamagePerSecondToPlayer;

	public float m_StruggleStartDamageAfterSeconds;

	public float m_SpearStruggleSecondsPerAttackMin;

	public float m_SpearStruggleSecondsPerAttackMax;

	public float m_FleeDistanceForWanderAround;

	public float m_WanderAroundRadiusAfterFlee;

	public float m_IgnorePlayerAfterFleeWanderAroundDelaySeconds;

	public float m_SpearStruggleStaminaCost;

	public float m_MaulingStruggleStaminaCost;

	public float m_UnreachableTargetFleeTimeoutSeconds;

	public float m_WanderRadiusAfterUnreachableTargetFleeTimeout;

	public float m_WanderDurationAfterUnreachableTargetFleeTimeout;

	public float m_StruggleTapStrengthScale;

	public float m_StrugglePlayerDamageReceivedIntervalScale;

	public float m_StrugglePlayerDamageReceivedScale;

	public float m_StrugglePlayerClothingDamageScale;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public BearHuntReduxSettings()
	{
	}
}
