using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetSkillPoints : ActionTask
{
	public SkillType skillType;

	public BBParameter<int> skillpoints;

	public SkillsManager.PointAssignmentMode assignmentMode;

	protected override string info
	{
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowLevelUp")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowPointIncrease")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetSkillPoints()
	{
	}
}
