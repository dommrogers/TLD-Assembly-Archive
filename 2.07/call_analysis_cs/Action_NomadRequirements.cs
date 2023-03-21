using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Serialization;
using UnityEngine.SceneManagement;

public class Action_NomadRequirements : ActionTask<GraphOwner>
{
	public List<string> scenesRequired;

	public float daysToSpendInEach;

	public string metRequirements;

	public float updateIntervalMinutes;

	public BBParameter<string> nomadDataSerialized;

	public BBParameter<bool> usingNewDataFormat;

	private ulong m_RequirementInMilliseconds;

	private HighResolutionTimer m_Timer;

	private Dictionary<string, ulong> m_NomadDataDict;

	private string m_CurrentSceneKey;

	private string[] m_CheckListNames;

	private string[] m_CheckListValues;

	private bool[] m_CheckListBools;

	private bool m_IsCompleted;

	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CallsDeduplicatedMethods(Count = 6)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "GetCurrentSceneKey")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "UpdateTimeForCurrentScene")]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "Restart")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateTimeForCurrentScene()
	{
	}

	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnExecute")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void UpdateMissionInfo()
	{
	}

	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private string GetCurrentSceneKey()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "UpdateTimeForCurrentScene")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	private string GetChecklistNameForKey(string key)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Action_NomadRequirements()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
