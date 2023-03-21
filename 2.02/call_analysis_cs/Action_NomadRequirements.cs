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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "Restart")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "GetCurrentSceneKey")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "UpdateTimeForCurrentScene")]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "Restart")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 19)]
	private void UpdateTimeForCurrentScene()
	{
	}

	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 25)]
	private void UpdateMissionInfo()
	{
	}

	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private string GetCurrentSceneKey()
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "UpdateTimeForCurrentScene")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	private string GetChecklistNameForKey(string key)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = ".ctor")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 31)]
	public Action_NomadRequirements()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
