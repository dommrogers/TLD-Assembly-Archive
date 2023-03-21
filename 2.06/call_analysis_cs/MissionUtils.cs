using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using UnityEngine;

public class MissionUtils
{
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public static void PostObjectEvent(GameObject obj, MissionObjectEvent eventType)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AfflictionDiagnosed")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public static void PostAfflictionEvent(GameObject obj, AfflictionType afflictionType, AfflictionEventType eventType)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public MissionUtils()
	{
	}
}
