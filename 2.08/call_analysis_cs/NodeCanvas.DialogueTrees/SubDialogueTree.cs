using System;
using System.Collections.Generic;
using System.Linq;
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
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 6)]
	private BBParameter[] NodeCanvas_002EFramework_002EISubParametersContainer_002EGetSubParameters()
	{
		return null;
	}

	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(SubDialogueTree), Member = "SetVariablesMapping")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(SubDialogueTree), Member = "CheckInstance")]
	[Calls(Type = typeof(NCUtils), Member = "AddBlackboardMembersIfRequired")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubDialogueTree), Member = "SetActorParametersMapping")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Calls(Type = typeof(DialogueTree.ActorParameter), Member = "get_actor")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[Calls(Type = typeof(DialogueTree), Member = "SetActorReference")]
	[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
	[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
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

	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnGraphPaused()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsInstance(DialogueTree dt)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	private void CheckInstance()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public SubDialogueTree()
	{
	}
}
