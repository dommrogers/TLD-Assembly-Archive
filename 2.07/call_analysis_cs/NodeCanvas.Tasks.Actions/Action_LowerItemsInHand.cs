using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_LowerItemsInHand : ActionTask
{
	public bool dropLitItemWhenStowed;

	public bool keepItemInInventoryWhenDropped;

	public bool deleteDroppedItemWhenTimelineEnds;

	private bool m_HasStowedItem;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "StowItem")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	private void OnItemInHandStowed()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_LowerItemsInHand()
	{
	}
}
