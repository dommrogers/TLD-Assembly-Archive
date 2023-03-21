using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Serialization;
using UnityEngine;

public class MissionObjectiveTable : ScriptableObject
{
	[Serializable]
	public class MissionObjectiveLink
	{
		public string m_ObjectiveName;

		public string m_MissionGraphNameOwner;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public MissionObjectiveLink()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 224)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	private MissionObjectiveLink GetLinkFromList(string objectiveId, List<MissionObjectiveLink> list)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateLinkListFromList(string objectiveId, List<MissionObjectiveLink> list, List<MissionObjectiveLink> resultlist)
	{
	}

	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "GetMissionGraphOwnerList")]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "DoesLinkExists")]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinkListFromList")]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinkListFromList")]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinkListFromList")]
	[CallerCount(Count = 2)]
	private void UpdateLinksList(string objectiveId, List<MissionObjectiveLink> resultList)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "DoesLinkExists")]
	[CallsUnknownMethods(Count = 2)]
	public void AddRuntimeLink(MissionObjectiveLink link)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "AddRuntimeLink")]
	[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "RegisterGraphLink")]
	[CallsUnknownMethods(Count = 5)]
	private bool DoesLinkExists(MissionObjectiveLink link)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	public string[] GetMissionGraphOwnerList(string objectiveId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public MissionObjectiveTable()
	{
	}
}
