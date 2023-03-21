using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CustomManagedObject : MonoBehaviour
{
	private MissionObjectIdentifier m_MissionObjectIdentifier;

	private bool m_DefaultActiveState;

	private bool m_IsRegistered;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(CustomManagedObject), Member = "UpdateManagedObject")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void PersistState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomManagedObject), Member = "UpdateManagedObject")]
	public void PersistState(bool state)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TLD_ActivationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(CustomManagedObject), Member = "PersistState")]
	[CalledBy(Type = typeof(CustomManagedObject), Member = "PersistState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "AddCustomManagedObject")]
	private void UpdateManagedObject(bool managedState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CustomManagedObject()
	{
	}
}
