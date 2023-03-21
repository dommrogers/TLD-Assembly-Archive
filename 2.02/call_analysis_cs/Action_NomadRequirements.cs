using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
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

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "Restart")]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "Restart")]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "UpdateTimeForCurrentScene")]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "GetCurrentSceneKey")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	private void UpdateTimeForCurrentScene()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateMissionInfo()
	{
	}

	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private string GetCurrentSceneKey()
	{
		return null;
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "UpdateTimeForCurrentScene")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetChecklistNameForKey(string key)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 31)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public Action_NomadRequirements()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
