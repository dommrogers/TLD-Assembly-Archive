using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_ShowCenterCredit : ActionTask
{
	public BBParameter<string> message;

	public BBParameter<bool> messageIsLocID;

	public BBParameter<float> tweenDuration;

	public BBParameter<float> waitDuration;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCreditsCenter")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 14)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	public Action_ShowCenterCredit()
	{
	}
}
