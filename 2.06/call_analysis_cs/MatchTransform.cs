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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MatchTransform), Member = "UpdateColliderState")]
	[CallsUnknownMethods(Count = 2)]
	public void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MatchTransform), Member = "LateUpdateAll")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private int DoLateUpdate()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CalledBy(Type = typeof(MatchTransform), Member = "OnEnable")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MatchTransform), Member = "AreColliderEnabled")]
	private void UpdateColliderState()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[Calls(Type = typeof(MatchTransform), Member = "DoLateUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	public static int LateUpdateAll()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(MatchTransform), Member = "UpdateColliderState")]
	[CallerCount(Count = 1)]
	public static bool AreColliderEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MatchTransform), Member = "UpdateColliderState")]
	[Calls(Type = typeof(MatchTransform), Member = "LateUpdateAll")]
	[Calls(Type = typeof(Utils), Member = "UseHigherPrecisionTimestep")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitDead")]
	[CalledBy(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsUnknownMethods(Count = 5)]
	public static void EnableCollidersForAllActive(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MatchTransform()
	{
	}
}
