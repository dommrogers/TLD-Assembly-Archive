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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCreditsSide")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public Action_ShowSideCredits()
	{
	}
}
