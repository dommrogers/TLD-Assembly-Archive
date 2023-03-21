using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Condition_CheckPanelRequirements : ConditionTask
{
	public BBParameter<Action_ShowPanel.Panel> panel;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[CallsUnknownMethods(Count = 2)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Condition_CheckPanelRequirements()
	{
	}
}
