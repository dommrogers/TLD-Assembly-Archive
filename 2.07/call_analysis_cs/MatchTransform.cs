using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MatchTransform : MonoBehaviour
{
	public GameObject m_Target;

	private static List<MatchTransform> s_MatchTransformList;

	private static List<MatchTransform> s_DeadWildlife;

	private static int s_CollidersEnabledCount;

	private BaseAi m_BaseAi;

	private Collider m_Collider;

	private Transform m_CachedThisTransform;

	private Transform m_CachedTargetTransform;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MatchTransform), Member = "UpdateColliderState")]
	public void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDisable()
	{
	}

	[CalledBy(Type = typeof(MatchTransform), Member = "LateUpdateAll")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	private int DoLateUpdate()
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MatchTransform), Member = "AreColliderEnabled")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CalledBy(Type = typeof(MatchTransform), Member = "OnEnable")]
	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateColliderState()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MatchTransform), Member = "DoLateUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	public static int LateUpdateAll()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(MatchTransform), Member = "UpdateColliderState")]
	public static bool AreColliderEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "UseHigherPrecisionTimestep")]
	[Calls(Type = typeof(MatchTransform), Member = "LateUpdateAll")]
	[Calls(Type = typeof(MatchTransform), Member = "UpdateColliderState")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallerCount(Count = 6)]
	public static void EnableCollidersForAllActive(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MatchTransform()
	{
	}
}
