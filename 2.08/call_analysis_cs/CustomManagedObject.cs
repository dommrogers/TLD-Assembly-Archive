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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomManagedObject), Member = "UpdateManagedObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void PersistState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomManagedObject), Member = "UpdateManagedObject")]
	public void PersistState(bool state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(CustomManagedObject), Member = "PersistState")]
	[CalledBy(Type = typeof(CustomManagedObject), Member = "PersistState")]
	[CalledBy(Type = typeof(TLD_ActivationTrack), Member = "Stop")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "AddCustomManagedObject")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateManagedObject(bool managedState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CustomManagedObject()
	{
	}
}
