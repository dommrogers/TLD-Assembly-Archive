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

	[CalledBy(Type = typeof(Action_Objective), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_Objective), Member = "OnUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshMissionMessage")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = ".ctor")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public Action_Objective()
	{
	}
}
