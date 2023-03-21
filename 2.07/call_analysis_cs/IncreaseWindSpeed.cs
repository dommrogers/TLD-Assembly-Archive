using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class IncreaseWindSpeed : MonoBehaviour
{
	private float m_WindSpeedIncrease;

	private float m_SpeedIncreaseSeconds;

	private bool m_PlayerIsInside;

	private float m_CurrentWindSpeedIncrease;

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerExit(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public IncreaseWindSpeed()
	{
	}
}
