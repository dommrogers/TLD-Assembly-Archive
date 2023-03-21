using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

public class MissionTrigger : MissionObjectIdentifier
{
	public const string ON_ENTER_EVENT_NAME = "MissionTrigger_OnEnter";

	public const string ON_EXIT_EVENT_NAME = "MissionTrigger_OnExit";

	public MissionTriggerType m_Type;

	public string[] m_AssociatedData;

	public string m_RequiredTag;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "MissionTriggerRemoved")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "OnEnterMissionTrigger")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ObjectInTriggerInfo), Member = ".ctor")]
	[Calls(Type = typeof(MissionTrigger), Member = "MatchesTag")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(MissionTrigger), Member = "MatchesTag")]
	[Calls(Type = typeof(ObjectInTriggerInfo), Member = ".ctor")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnExitMissionTrigger")]
	[CallsUnknownMethods(Count = 7)]
	private void OnTriggerExit(Collider c)
	{
	}

	[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
	[CalledBy(Type = typeof(Condition_EnterMissionTrigger), Member = "OnCustomEvent")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Split")]
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
	public MissionTrigger()
	{
	}
}
