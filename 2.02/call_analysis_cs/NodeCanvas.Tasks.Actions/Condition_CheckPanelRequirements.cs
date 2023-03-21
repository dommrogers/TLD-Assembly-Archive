using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Condition_CheckPanelRequirements : ConditionTask
{
	public BBParameter<Action_ShowPanel.Panel> panel;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_CheckPanelRequirements()
	{
	}
}
