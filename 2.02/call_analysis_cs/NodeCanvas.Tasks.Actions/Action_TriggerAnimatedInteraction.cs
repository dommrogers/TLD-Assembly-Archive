using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_TriggerAnimatedInteraction : ActionTask
{
	public BBParameter<string> parameter;

	public BBParameter<bool> waitForComplete;

	public BBParameter<bool> worldSpace;

	public BBParameter<bool> unequipItem;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_TriggerAnimatedInteraction), Member = "DoWork")]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_TriggerAnimatedInteraction), Member = "OnExecute")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	private void DoWork()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnWorkDone()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_TriggerAnimatedInteraction()
	{
	}
}
