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
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCreditsSide")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsUnknownMethods(Count = 2)]
	public Action_ShowSideCredits()
	{
	}
}
