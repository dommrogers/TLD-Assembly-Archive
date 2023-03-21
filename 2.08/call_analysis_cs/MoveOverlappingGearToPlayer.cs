using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MoveOverlappingGearToPlayer : MonoBehaviour
{
	private Bounds m_Bounds;

	private static Collider[] s_Results;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[CallsUnknownMethods(Count = 11)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MoveOverlappingGearToPlayer()
	{
	}
}
