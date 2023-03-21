using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_4DONObjective : ActionTask
{
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionMessage")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshMissionMessage")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_4DONObjective()
	{
	}
}
