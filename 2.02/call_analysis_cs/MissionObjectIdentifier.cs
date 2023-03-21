using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
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

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(Container), Member = "AssumeMissionObjectResponsibility")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "AssumeMissionObjectResponsibility")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetCurrentMissionFilterTags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static MissionObjectIdentifier AddMissionComponentForSaveManagedItem(GameObject smObject, string missionObjectSerialized)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyGearItemAfterMission")]
	[CalledBy(Type = typeof(Container), Member = "MaybeDestroyContainerAfterMission")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FiltersAllowObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FindMissionObjectsByTag")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FindMissionObjectsWithoutTag")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[CallsUnknownMethods(Count = 13)]
	public bool HasAnyTag(string[] tags)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsBlankId()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MissionObjectIdentifier()
	{
	}
}
