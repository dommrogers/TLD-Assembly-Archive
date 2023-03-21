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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 12)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "AssumeMissionObjectResponsibility")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "AssumeMissionObjectResponsibility")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetCurrentMissionFilterTags")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static MissionObjectIdentifier AddMissionComponentForSaveManagedItem(GameObject smObject, string missionObjectSerialized)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyGearItemAfterMission")]
	[CalledBy(Type = typeof(Container), Member = "MaybeDestroyContainerAfterMission")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FiltersAllowObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FindMissionObjectsByTag")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FindMissionObjectsWithoutTag")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasAnyTag(string[] tags)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsBlankId()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MissionObjectIdentifier()
	{
	}
}
