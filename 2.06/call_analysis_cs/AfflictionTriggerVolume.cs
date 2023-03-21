using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AfflictionTriggerVolume : MonoBehaviour
{
	public AfflictionType m_AfflictionType;

	public bool m_StopAfflictionOnExit;

	public bool m_BlockSuffocating;

	public SuffocatingSettings m_SuffocatingSettingsPrefab;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[Calls(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerExit(Collider collider)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AfflictionTriggerVolume()
	{
	}
}
