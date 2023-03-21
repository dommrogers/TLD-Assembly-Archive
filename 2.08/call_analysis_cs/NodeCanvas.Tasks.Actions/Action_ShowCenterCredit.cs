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

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCreditsCenter")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public Action_ShowCenterCredit()
	{
	}
}
