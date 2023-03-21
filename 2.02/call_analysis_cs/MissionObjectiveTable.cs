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
		[CallerCount(Count = 2)]
		public MissionObjectiveLink()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 83)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	private MissionObjectiveLink GetLinkFromList(string objectiveId, List<MissionObjectiveLink> list)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	private void UpdateLinkListFromList(string objectiveId, List<MissionObjectiveLink> list, List<MissionObjectiveLink> resultlist)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinkListFromList")]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinkListFromList")]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinkListFromList")]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "DoesLinkExists")]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "GetMissionGraphOwnerList")]
	private void UpdateLinksList(string objectiveId, List<MissionObjectiveLink> resultList)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "DoesLinkExists")]
	[CallsUnknownMethods(Count = 1)]
	public void AddRuntimeLink(MissionObjectiveLink link)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "AddRuntimeLink")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "RegisterGraphLink")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[CallsUnknownMethods(Count = 5)]
	private bool DoesLinkExists(MissionObjectiveLink link)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	public string[] GetMissionGraphOwnerList(string objectiveId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public MissionObjectiveTable()
	{
	}
}
