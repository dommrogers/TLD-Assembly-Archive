using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class IncreaseTemperatureTrigger : MonoBehaviour
{
	public float m_TempIncrease;

	private bool m_PlayerIsInside;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerExit(Collider c)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public IncreaseTemperatureTrigger()
	{
	}
}
