using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BodyHarvestItem : MonoBehaviour
{
	public float m_HarvestMeatMinutesPerKG;

	public float m_HarvestFrozenMeatMinutesPerKG;

	public float m_HarvestHideMinutesPerUnit;

	public float m_HarvestGutMinutesPerUnit;

	public float m_HPDecreasePerHourUse;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BodyHarvestItem()
	{
	}
}
