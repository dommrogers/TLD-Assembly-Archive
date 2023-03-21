using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ForageItem : MonoBehaviour
{
	public float m_TinderUnitsPerHourOutdoor;

	public float m_TinderUnitsPerHourIndoor;

	public float m_SoftwoodUnitsPerHour;

	public float m_HardwoodUnitsPerHour;

	public float m_ReclaimedWoodUnitsPerHour;

	public float m_HPDecreasePerHourForaging;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ForageItem()
	{
	}
}
