using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.UI.Generics;

namespace NodeCanvas.Tasks.Actions;

public class Action_ShowCenterCredit : ActionTask
{
	public BBParameter<string> message;

	public BBParameter<bool> messageIsLocID;

	public BBParameter<float> tweenDuration;

	public BBParameter<float> waitDuration;

	private PanelReference<Panel_HUD> m_HUD;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCreditsCenter")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsUnknownMethods(Count = 4)]
	public Action_ShowCenterCredit()
	{
	}
}
