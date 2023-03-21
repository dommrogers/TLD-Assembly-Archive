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
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BodyHarvestItem()
	{
	}
}
