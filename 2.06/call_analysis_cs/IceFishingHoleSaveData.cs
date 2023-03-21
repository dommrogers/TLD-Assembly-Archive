using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class IceFishingHoleSaveData
{
	public Vector3 m_Position;

	public float m_HoursPlayed;

	public float m_MinutesSinceLastClearing;

	public float m_NormalizedFrozen;

	public string m_Guid;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public IceFishingHoleSaveData()
	{
	}
}
