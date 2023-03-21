using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_Objective : ActionTask
{
	public BBParameter<string> locID;

	public Color textColor;

	public bool allowSkipFirstTime;

	public bool keepAlive;

	private PanelReference<Panel_HUD> m_HUD;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_Objective), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_Objective), Member = "DoWork")]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(Action_Objective), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_Objective), Member = "OnUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshMissionMessage")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsUnknownMethods(Count = 6)]
	public Action_Objective()
	{
	}
}
