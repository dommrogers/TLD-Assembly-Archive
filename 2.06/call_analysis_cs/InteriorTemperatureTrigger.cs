using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InteriorTemperatureTrigger : MonoBehaviour
{
	public float m_Temperature;

	private float m_RestoreTemperature;

	public static bool m_PlayerInside;

	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SpecialEvent), Member = "IgnoreInteriorTemperatureTriggers")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SpecialEvent), Member = "IgnoreInteriorTemperatureTriggers")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public InteriorTemperatureTrigger()
	{
	}
}
