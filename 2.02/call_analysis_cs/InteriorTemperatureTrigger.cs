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

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SpecialEvent), Member = "IgnoreInteriorTemperatureTriggers")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Calls(Type = typeof(SpecialEvent), Member = "IgnoreInteriorTemperatureTriggers")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnTriggerExit(Collider c)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public InteriorTemperatureTrigger()
	{
	}
}
