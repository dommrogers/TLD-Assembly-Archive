using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_ShowSideCredits : ActionTask
{
	public BBParameter<string> messageTop;

	public BBParameter<string> messageCenter;

	public BBParameter<string> messageBottom;

	public BBParameter<float> waitDuration;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCreditsSide")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 6)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[CallerCount(Count = 0)]
	public Action_ShowSideCredits()
	{
	}
}
