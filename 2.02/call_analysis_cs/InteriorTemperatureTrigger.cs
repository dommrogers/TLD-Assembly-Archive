using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InteriorTemperatureTrigger : MonoBehaviour
{
	public float m_Temperature;

	private float m_RestoreTemperature;

	public static bool m_PlayerInside;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpecialEvent), Member = "IgnoreInteriorTemperatureTriggers")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpecialEvent), Member = "IgnoreInteriorTemperatureTriggers")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public InteriorTemperatureTrigger()
	{
	}
}
