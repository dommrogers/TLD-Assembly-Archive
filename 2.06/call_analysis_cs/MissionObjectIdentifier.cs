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
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Container), Member = "AssumeMissionObjectResponsibility")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "AssumeMissionObjectResponsibility")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetCurrentMissionFilterTags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	public static MissionObjectIdentifier AddMissionComponentForSaveManagedItem(GameObject smObject, string missionObjectSerialized)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 2)]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FindMissionObjectsWithoutTag")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FindMissionObjectsByTag")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FiltersAllowObject")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyGearItemAfterMission")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Container), Member = "MaybeDestroyContainerAfterMission")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MissionObjectIdentifier()
	{
	}
}
