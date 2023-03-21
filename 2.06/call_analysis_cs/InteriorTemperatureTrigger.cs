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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpecialEvent), Member = "IgnoreInteriorTemperatureTriggers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpecialEvent), Member = "IgnoreInteriorTemperatureTriggers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public InteriorTemperatureTrigger()
	{
	}
}
