using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CustomManagedObject : MonoBehaviour
{
	private MissionObjectIdentifier m_MissionObjectIdentifier;

	private bool m_DefaultActiveState;

	private bool m_IsRegistered;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CustomManagedObject), Member = "UpdateManagedObject")]
	[CallsUnknownMethods(Count = 3)]
	public void PersistState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomManagedObject), Member = "UpdateManagedObject")]
	public void PersistState(bool state)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "AddCustomManagedObject")]
	[CalledBy(Type = typeof(CustomManagedObject), Member = "PersistState")]
	[CalledBy(Type = typeof(CustomManagedObject), Member = "PersistState")]
	[CalledBy(Type = typeof(TLD_ActivationTrack), Member = "Stop")]
	private void UpdateManagedObject(bool managedState)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CustomManagedObject()
	{
	}
}
