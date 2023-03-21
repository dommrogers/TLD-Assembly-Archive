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

	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MatchTransform), Member = "UpdateColliderState")]
	public void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnDisable()
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(MatchTransform), Member = "LateUpdateAll")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 1)]
	private int DoLateUpdate()
	{
		return default(int);
	}

	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CalledBy(Type = typeof(MatchTransform), Member = "OnEnable")]
	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MatchTransform), Member = "AreColliderEnabled")]
	private void UpdateColliderState()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(MatchTransform), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	public static int LateUpdateAll()
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MatchTransform), Member = "UpdateColliderState")]
	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	public static bool AreColliderEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ExitDead")]
	[Calls(Type = typeof(Utils), Member = "UseHigherPrecisionTimestep")]
	[Calls(Type = typeof(MatchTransform), Member = "LateUpdateAll")]
	[Calls(Type = typeof(MatchTransform), Member = "UpdateColliderState")]
	[Calls(Type = typeof(MatchTransform), Member = "AreColliderEnabled")]
	[Calls(Type = typeof(MatchTransform), Member = "AreColliderEnabled")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	public static void EnableCollidersForAllActive(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public MatchTransform()
	{
	}
}
