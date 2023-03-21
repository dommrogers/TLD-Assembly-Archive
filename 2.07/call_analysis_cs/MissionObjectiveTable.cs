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

		[CallerCount(Count = 263)]
		[DeduplicatedMethod]
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
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 4)]
	private MissionObjectiveLink GetLinkFromList(string objectiveId, List<MissionObjectiveLink> list)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "DoesLinkExists")]
	public void AddRuntimeLink(MissionObjectiveLink link)
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MissionObjectiveTable), Member = "AddRuntimeLink")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "RegisterGraphLink")]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool DoesLinkExists(MissionObjectiveLink link)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "UpdateLinksList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	public string[] GetMissionGraphOwnerList(string objectiveId)
	{
		return null;
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MissionObjectiveTable()
	{
	}
}
