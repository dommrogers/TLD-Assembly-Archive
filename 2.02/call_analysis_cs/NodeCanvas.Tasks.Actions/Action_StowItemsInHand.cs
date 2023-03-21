using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_StowItemsInHand : ActionTask
{
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Action_StowItemsInHand), Member = "MaybeStowItemInHand")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CalledBy(Type = typeof(Action_StowItemsInHand), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 9)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_StowItemsInHand()
	{
	}
}
