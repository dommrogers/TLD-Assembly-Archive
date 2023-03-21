using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MoveOverlappingGearToPlayer : MonoBehaviour
{
	private Bounds m_Bounds;

	private static Collider[] s_Results;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[CallsUnknownMethods(Count = 18)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MoveOverlappingGearToPlayer()
	{
	}
}
