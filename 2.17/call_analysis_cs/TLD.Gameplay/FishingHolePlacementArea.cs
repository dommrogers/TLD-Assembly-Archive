using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public class FishingHolePlacementArea : MonoBehaviour
{
	public FishingHolePlacementSettings m_FishingHolePlacementSettings;

	private static List<FishingHolePlacementArea> s_ActiveFishingHolePlacementAreaList;

	private Collider m_Collider;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnPlaceIceFishingHole")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "CanBuildFishingHole")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static FishingHolePlacementSettings GetActivePlacementSettings()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsPointInside(Vector3 point)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FishingHolePlacementArea()
	{
	}
}
