using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class IceFishingHoleSaveData
{
	public Vector3 m_Position;

	public float m_HoursPlayed;

	public float m_MinutesSinceLastClearing;

	public float m_NormalizedFrozen;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public IceFishingHoleSaveData()
	{
	}
}
