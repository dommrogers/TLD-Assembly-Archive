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
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AfflictionDiagnosed")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	public static void PostAfflictionEvent(GameObject obj, AfflictionType afflictionType, AfflictionEventType eventType)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public MissionUtils()
	{
	}
}
