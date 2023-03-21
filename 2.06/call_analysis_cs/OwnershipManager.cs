using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OwnershipManager : MonoBehaviour
{
	public static List<OwnershipVolume> m_PlayerInOwnershipVolumes;

	public static List<OwnershipVolume> m_OwnershipVolumes;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void RegisterOwnershipVolume(OwnershipVolume ownershipVolume)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void UnregisterOwnershipVolume(OwnershipVolume ownershipVolume)
	{
	}

	[CalledBy(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleItemBreakdown")]
	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleItemTheft")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "BreakDownFinished")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleContainerTheft")]
	[Calls(Type = typeof(OwnershipVolume), Member = "Contains")]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string GetTrustId(GameObject item)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OwnershipVolume), Member = "Contains")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static OwnershipVolume GetOwnershipVolumeContaining(GameObject item)
	{
		return null;
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ShowFeedFire")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Break")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayTextState")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static bool IsUnowned(GameObject item)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 2)]
	public static void OnPlayerEnterOwnershipTrigger(OwnershipVolume ownershipVolume)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void OnPlayerExitOwnershipTrigger(OwnershipVolume ownershipVolume)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public OwnershipManager()
	{
	}
}
