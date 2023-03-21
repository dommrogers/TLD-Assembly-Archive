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

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 15)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public Action_ChallengeNowhereToHideRequirements()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
