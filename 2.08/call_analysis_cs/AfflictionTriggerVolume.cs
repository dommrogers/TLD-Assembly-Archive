using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AfflictionTriggerVolume : MonoBehaviour
{
	public AfflictionType m_AfflictionType;

	public bool m_StopAfflictionOnExit;

	public bool m_BlockSuffocating;

	public SuffocatingSettings m_SuffocatingSettingsPrefab;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[Calls(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerExit(Collider collider)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AfflictionTriggerVolume()
	{
	}
}
