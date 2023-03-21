using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FoodWeight : MonoBehaviour
{
	public float m_MinWeightKG;

	public float m_MaxWeightKG;

	public float m_CaloriesPerKG;

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public FoodWeight()
	{
	}
}
