using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using UnityEngine;

public class MissionUtils
{
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public static void PostObjectEvent(GameObject obj, MissionObjectEvent eventType)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AfflictionDiagnosed")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[CallsUnknownMethods(Count = 9)]
	public static void PostAfflictionEvent(GameObject obj, AfflictionType afflictionType, AfflictionEventType eventType)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public MissionUtils()
	{
	}
}
