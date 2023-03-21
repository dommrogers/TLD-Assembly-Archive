using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OwnershipManager : MonoBehaviour
{
	public static List<OwnershipVolume> m_PlayerInOwnershipVolumes;

	public static List<OwnershipVolume> m_OwnershipVolumes;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterOwnershipVolume(OwnershipVolume ownershipVolume)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnregisterOwnershipVolume(OwnershipVolume ownershipVolume)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleContainerTheft")]
	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleItemTheft")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "BreakDownFinished")]
	[CalledBy(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[CalledBy(Type = typeof(Container), Member = "OnContainerSearchComplete")]
	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleItemBreakdown")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OwnershipVolume), Member = "Contains")]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static string GetTrustId(GameObject item)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OwnershipVolume), Member = "Contains")]
	public static OwnershipVolume GetOwnershipVolumeContaining(GameObject item)
	{
		return null;
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "Break")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayTextState")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "EnableAfterDelay")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool IsUnowned(GameObject item)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void OnPlayerEnterOwnershipTrigger(OwnershipVolume ownershipVolume)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void OnPlayerExitOwnershipTrigger(OwnershipVolume ownershipVolume)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public OwnershipManager()
	{
	}
}
