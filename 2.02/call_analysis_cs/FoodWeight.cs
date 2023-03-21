using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FoodWeight : MonoBehaviour
{
	public float m_MinWeightKG;

	public float m_MaxWeightKG;

	public float m_CaloriesPerKG;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FoodWeight()
	{
	}
}
