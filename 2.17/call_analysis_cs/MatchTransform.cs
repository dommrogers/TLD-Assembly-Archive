using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AI;
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
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MatchTransform), Member = "UpdateColliderState")]
	[CallsUnknownMethods(Count = 2)]
	public void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDisable()
	{
	}

	[CalledBy(Type = typeof(MatchTransform), Member = "LateUpdateAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private int DoLateUpdate()
	{
		return 0;
	}

	[CalledBy(Type = typeof(MatchTransform), Member = "OnEnable")]
	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MatchTransform), Member = "AreColliderEnabled")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateColliderState()
	{
	}

	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MatchTransform), Member = "DoLateUpdate")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static int LateUpdateAll()
	{
		return 0;
	}

	[CalledBy(Type = typeof(MatchTransform), Member = "UpdateColliderState")]
	[CallerCount(Count = 1)]
	public static bool AreColliderEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitDead")]
	[CalledBy(Type = typeof(GearItem), Member = "DisablePhysics")]
	[CalledBy(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CalledBy(Type = typeof(AiPtarmigan), Member = "SetFlying")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MatchTransform), Member = "UpdateColliderState")]
	[Calls(Type = typeof(MatchTransform), Member = "LateUpdateAll")]
	[Calls(Type = typeof(Utils), Member = "UseHigherPrecisionTimestep")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static void EnableCollidersForAllActive(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MatchTransform()
	{
	}
}
