using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BlockPlacement : MonoBehaviour
{
	public bool m_BlockBedrollPlacement;

	public bool m_BlockCampfirePlacement;

	public bool m_BlockBodyPlacement;

	public bool m_BlockSnowShelterPlacement;

	public bool m_BlockLeanToPlacement;

	public bool m_BlockGearItemPlacement;

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public BlockPlacement()
	{
	}
}
