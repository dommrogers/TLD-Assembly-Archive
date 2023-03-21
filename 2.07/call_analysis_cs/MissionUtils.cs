using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using UnityEngine;

public class MissionUtils
{
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Utils), Member = "GetComponentOnSelfOrParent")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void PostObjectEvent(GameObject obj, MissionObjectEvent eventType)
	{
	}

	[CalledBy(Type = typeof(NPCAfflictions), Member = "AfflictionDiagnosed")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetComponentOnSelfOrParent")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 1)]
	public static void PostAfflictionEvent(GameObject obj, AfflictionType afflictionType, AfflictionEventType eventType)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public MissionUtils()
	{
	}
}
