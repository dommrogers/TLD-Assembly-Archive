using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_StowItemsInHand : ActionTask
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_StowItemsInHand), Member = "MaybeStowItemInHand")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_StowItemsInHand), Member = "OnExecute")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private bool MaybeStowItemInHand()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	private void OnItemInHandStowed()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_StowItemsInHand()
	{
	}
}
