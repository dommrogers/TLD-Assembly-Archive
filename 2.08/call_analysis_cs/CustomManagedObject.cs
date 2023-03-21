using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CustomManagedObject : MonoBehaviour
{
	private MissionObjectIdentifier m_MissionObjectIdentifier;

	private bool m_DefaultActiveState;

	private bool m_IsRegistered;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
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

	[CalledBy(Type = typeof(TLD_ActivationTrack), Member = "Stop")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CustomManagedObject), Member = "PersistState")]
	[Calls(Type = typeof(MissionServicesManager), Member = "AddCustomManagedObject")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(CustomManagedObject), Member = "PersistState")]
	private void UpdateManagedObject(bool managedState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CustomManagedObject()
	{
	}
}
