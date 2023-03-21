using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AfflictionTriggerVolume : MonoBehaviour
{
	public AfflictionType m_AfflictionType;

	public bool m_StopAfflictionOnExit;

	public bool m_BlockSuffocating;

	public SuffocatingSettings m_SuffocatingSettingsPrefab;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CallsUnknownMethods(Count = 7)]
	private void OnTriggerExit(Collider collider)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AfflictionTriggerVolume()
	{
	}
}
