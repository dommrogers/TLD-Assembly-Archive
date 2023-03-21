using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using UnityEngine;

public class MissionUtils
{
	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 3)]
	public static void PostObjectEvent(GameObject obj, MissionObjectEvent eventType)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AfflictionDiagnosed")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void PostAfflictionEvent(GameObject obj, AfflictionType afflictionType, AfflictionEventType eventType)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public MissionUtils()
	{
	}
}
