using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BodyHarvestItem : MonoBehaviour
{
	public float m_HarvestMeatMinutesPerKG;

	public float m_HarvestFrozenMeatMinutesPerKG;

	public float m_HarvestHideMinutesPerUnit;

	public float m_HarvestGutMinutesPerUnit;

	public float m_HPDecreasePerHourUse;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BodyHarvestItem()
	{
	}
}
