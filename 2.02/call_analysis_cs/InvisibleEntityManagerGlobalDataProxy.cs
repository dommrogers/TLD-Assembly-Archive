using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InvisibleEntityManagerGlobalDataProxy
{
	public float m_AttackMovementSpeed;

	public float m_MovementSpeedOverride;

	public float m_AttackTime;

	public Vector3 m_EntityToPlayerPosition;

	public float m_EntityToPlayerOrientation;

	public float m_StartMovementDelayTimeSeconds;

	public int m_BehaviorIndex;

	public float m_AccumulatedTimeSeconds;

	public float m_AccumulatedRealTimeSeconds;

	public List<IndoorWardData> m_IndoorWardLocations;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public InvisibleEntityManagerGlobalDataProxy()
	{
	}
}
