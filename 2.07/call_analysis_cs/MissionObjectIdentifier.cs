using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class MissionObjectIdentifier : MonoBehaviour
{
	public string m_Id;

	public MissionObjectClass m_ObjectClass;

	public string m_ActivityTags;

	public bool m_DestroyAfterMission;

	public bool m_BaseAiOnlySerializeIfActive;

	public bool m_IsUnique;

	public int m_NumTags;

	public bool m_SkipSaveManagedItemTest;

	private bool m_SkipUnregister;

	private static MissionObjectIdentifierSaveProxy m_MissionObjectIdentifierSaveProxy;

	private bool m_IsBlankId;

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Container), Member = "AssumeMissionObjectResponsibility")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "AssumeMissionObjectResponsibility")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetCurrentMissionFilterTags")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public static MissionObjectIdentifier AddMissionComponentForSaveManagedItem(GameObject smObject, string missionObjectSerialized)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyGearItemAfterMission")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FindMissionObjectsWithoutTag")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FindMissionObjectsByTag")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FiltersAllowObject")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Container), Member = "MaybeDestroyContainerAfterMission")]
	[CallsUnknownMethods(Count = 3)]
	public bool HasAnyTag(string[] tags)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsBlankId()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MissionObjectIdentifier()
	{
	}
}
