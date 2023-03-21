using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class MissionObjectiveTable : ScriptableObject
{
	[Serializable]
	public class MissionObjectiveLink
	{
		public string m_ObjectiveName;

		public string m_MissionGraphNameOwner;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public MissionObjectiveLink()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 88)]
		public MissionObjectiveLink(string objectiveName, string missionGraphNameOwner)
		{
		}
	}

	public List<MissionObjectiveLink> m_GeneratedLinks;

	public List<MissionObjectiveLink> m_AuthoredLinks;

	[NonSerialized]
	public List<MissionObjectiveLink> m_RuntimeLinks;

	private static List<MissionObjectiveLink> s_TmpLinksList;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private MissionObjectiveLink GetLinkFromList(string objectiveId, List<MissionObjectiveLink> list)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateLinkListFromList(string objectiveId, List<MissionObjectiveLink> list, List<MissionObjectiveLink> resultlist)
	{
	}

	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "DoesLinkExists")]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "GetMissionGraphOwnerList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinkListFromList")]
	private void UpdateLinksList(string objectiveId, List<MissionObjectiveLink> resultList)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "DoesLinkExists")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddRuntimeLink(MissionObjectiveLink link)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "AddRuntimeLink")]
	[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "RegisterGraphLink")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private bool DoesLinkExists(MissionObjectiveLink link)
	{
		return false;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public string[] GetMissionGraphOwnerList(string objectiveId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public MissionObjectiveTable()
	{
	}
}
