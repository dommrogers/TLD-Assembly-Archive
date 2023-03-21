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

	[Calls(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerExit(Collider collider)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AfflictionTriggerVolume()
	{
	}
}
