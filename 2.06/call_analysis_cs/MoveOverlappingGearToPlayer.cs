using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MoveOverlappingGearToPlayer : MonoBehaviour
{
	private Bounds m_Bounds;

	private static Collider[] s_Results;

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MoveOverlappingGearToPlayer()
	{
	}
}
