using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

public class MissionTrigger : MissionObjectIdentifier
{
	public MissionTriggerType m_Type;

	public string[] m_AssociatedData;

	public string m_RequiredTag;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "MissionTriggerRemoved")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(MissionTrigger), Member = "MatchesTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ObjectInTriggerInfo), Member = ".ctor")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnEnterMissionTrigger")]
	[CallsUnknownMethods(Count = 19)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnExitMissionTrigger")]
	[Calls(Type = typeof(ObjectInTriggerInfo), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(MissionTrigger), Member = "MatchesTag")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
	[CalledBy(Type = typeof(Condition_EnterMissionTrigger), Member = "OnCustomEvent")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public Dictionary<string, object>[] ParseAssociatedData()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerExit")]
	[CallsUnknownMethods(Count = 3)]
	private bool MatchesTag(Collider c)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MissionTrigger()
	{
	}
}
