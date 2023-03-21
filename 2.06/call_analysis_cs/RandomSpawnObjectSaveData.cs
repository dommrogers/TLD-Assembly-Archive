using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RandomSpawnObjectSaveData
{
	public string m_ObjectName;

	public Vector3 m_Position;

	public float m_ElapsedHoursAtLastReroll;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public RandomSpawnObjectSaveData()
	{
	}
}
