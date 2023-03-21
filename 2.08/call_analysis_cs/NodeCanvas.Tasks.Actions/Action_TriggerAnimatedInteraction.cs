using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

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

	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CalledBy(Type = typeof(Action_TriggerAnimatedInteraction), Member = "OnExecute")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[DeduplicatedMethod]
	private void OnWorkDone()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_TriggerAnimatedInteraction()
	{
	}
}
