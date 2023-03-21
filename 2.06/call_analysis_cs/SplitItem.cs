using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SplitItem : MonoBehaviour
{
	public GearItem[] m_SplitGear;

	public int[] m_SplitGearUnits;

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SplitItem()
	{
	}
}
