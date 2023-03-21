using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_StowItemsInHand : ActionTask
{
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_StowItemsInHand), Member = "MaybeStowItemInHand")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CalledBy(Type = typeof(Action_StowItemsInHand), Member = "OnExecute")]
	private bool MaybeStowItemInHand()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private void OnItemInHandStowed()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_StowItemsInHand()
	{
	}
}
