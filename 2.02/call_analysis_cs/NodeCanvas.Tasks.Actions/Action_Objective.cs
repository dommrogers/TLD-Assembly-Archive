using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_Objective : ActionTask
{
	public BBParameter<string> locID;

	public Color textColor;

	public bool allowSkipFirstTime;

	public bool keepAlive;

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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_Objective), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_Objective), Member = "OnExecute")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionMessage")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshMissionMessage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public Action_Objective()
	{
	}
}
