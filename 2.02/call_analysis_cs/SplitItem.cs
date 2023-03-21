using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SplitItem : MonoBehaviour
{
	public GearItem[] m_SplitGear;

	public int[] m_SplitGearUnits;

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SplitItem()
	{
	}
}
