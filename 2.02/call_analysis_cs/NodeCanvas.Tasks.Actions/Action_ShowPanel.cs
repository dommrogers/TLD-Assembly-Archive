using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_ShowPanel : ActionTask
{
	public enum Panel
	{
		BodyHarvest
	}

	public BBParameter<Panel> panel;

	public bool waitForClose;

	public bool triggerEndAnimation;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Action_ShowPanel), Member = "MaybeShowBodyHarvest")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetHipAndShoulderOffsetLayer")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(Action_ShowPanel), Member = "OnExecute")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void MaybeShowBodyHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetHipAndShoulderOffsetLayer")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeUpdateBodyHarvest()
	{
	}

	[CallerCount(Count = 0)]
	public Action_ShowPanel()
	{
	}
}
