using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class Action_FilterTopicChoice : DTNode
{
	public bool clearFilter;

	public List<DialogueOptionTopic> filter;

	public override string name
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	public Action_FilterTopicChoice()
	{
	}
}
