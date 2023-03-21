using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MoveOverlappingGearToPlayer : MonoBehaviour
{
	private Bounds m_Bounds;

	private static Collider[] s_Results;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 11)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MoveOverlappingGearToPlayer()
	{
	}
}
