using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

public class Action_ChallengeNowhereToHideRequirements : ActionTask<GraphOwner>
{
	public string ChallengeListHeaderLocId;

	public string ChallengeListDescLocId;

	public string ChallengeObjectiveLocId;

	public BBParameter<int> ObjectiveCurrentCount;

	public BBParameter<int> ObjectiveTotalCount;

	public string metRequirements;

	public string notMetRequirements;

	private string m_ChecklistHeader;

	private string m_ChecklistDesc;

	private string m_ChallengeObjective;

	private List<string> m_ChecklistNames;

	private List<string> m_ChecklistVals;

	private List<bool> m_ChecklistBools;

	private string m_RequirementString;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 31)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	public Action_ChallengeNowhereToHideRequirements()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
