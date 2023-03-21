using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.UI.Generics;

namespace NodeCanvas.Tasks.Actions;

public class Action_ShowSideCredits : ActionTask
{
	public BBParameter<string> messageTop;

	public BBParameter<string> messageCenter;

	public BBParameter<string> messageBottom;

	public BBParameter<float> waitDuration;

	private PanelReference<Panel_HUD> m_HUD;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCreditsSide")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallsUnknownMethods(Count = 24)]
	public Action_ShowSideCredits()
	{
	}
}
