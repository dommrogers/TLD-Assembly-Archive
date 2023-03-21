using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BearHuntAiReduxSaveData
{
	public bool m_BearEarGiven;

	public bool m_UseForceBearFleePosition;

	public Vector3 m_ForceBearFleePosition;

	public BearEncounter.PostStruggleBehavior m_PostStruggleBehavior;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public BearHuntAiReduxSaveData()
	{
	}
}
