using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class SubDialogueTree : DTNode, IGraphAssignable, ISubParametersContainer
{
	public BBParameter<bool> trustDialogue;

	private BBParameter<DialogueTree> _subTree;

	private Dictionary<string, string> actorParametersMap;

	private Dictionary<string, BBObjectParameter> variablesMap;

	private Dictionary<DialogueTree, DialogueTree> instances;

	public override int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public DialogueTree subTree
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	private Graph NodeCanvas_002EFramework_002EIGraphAssignable_002EnestedGraph
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private BBParameter[] NodeCanvas_002EFramework_002EISubParametersContainer_002EGetSubParameters()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(SubDialogueTree), Member = "SetActorParametersMapping")]
	[Calls(Type = typeof(SubDialogueTree), Member = "SetVariablesMapping")]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
	[Calls(Type = typeof(NCUtils), Member = "AddBlackboardMembersIfRequired")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SubDialogueTree), Member = "CheckInstance")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Calls(Type = typeof(DialogueTree), Member = "SetActorReference")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[Calls(Type = typeof(DialogueTree.ActorParameter), Member = "get_actor")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
	private void SetActorParametersMapping()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Graph), Member = "get_blackboard")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 9)]
	private void SetVariablesMapping()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	private void OnSubDialogueFinish(bool success)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 3)]
	public override void OnGraphStoped()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 3)]
	public override void OnGraphPaused()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsInstance(DialogueTree dt)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void CheckInstance()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 16)]
	public SubDialogueTree()
	{
	}
}
