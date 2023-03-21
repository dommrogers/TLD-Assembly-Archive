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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 20)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(SubDialogueTree), Member = "NodeCanvas.Framework.IGraphAssignable.set_nestedGraph")]
		[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
		[CalledBy(Type = typeof(SubDialogueTree), Member = "CheckInstance")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	private Graph NodeCanvas_002EFramework_002EIGraphAssignable_002EnestedGraph
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SubDialogueTree), Member = "set_subTree")]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private BBParameter[] NodeCanvas_002EFramework_002EISubParametersContainer_002EGetSubParameters()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(SubDialogueTree), Member = "SetVariablesMapping")]
	[Calls(Type = typeof(SubDialogueTree), Member = "SetActorParametersMapping")]
	[Calls(Type = typeof(SubDialogueTree), Member = "set_subTree")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(SubDialogueTree), Member = "IsInstance")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(NCUtils), Member = "AddBlackboardMembersIfRequired")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Calls(Type = typeof(DialogueTree), Member = "SetActorReference")]
	[Calls(Type = typeof(DialogueTree.ActorParameter), Member = "get_actor")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
	private void SetActorParametersMapping()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(Graph), Member = "get_blackboard")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 7)]
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
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(SubDialogueTree), Member = "IsInstance")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnGraphStoped()
	{
	}

	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(SubDialogueTree), Member = "IsInstance")]
	[CallerCount(Count = 0)]
	public override void OnGraphPaused()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnGraphStoped")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnGraphPaused")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "CheckInstance")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsInstance(DialogueTree dt)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SubDialogueTree), Member = "set_subTree")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[Calls(Type = typeof(SubDialogueTree), Member = "IsInstance")]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubDialogueTree), Member = "get_subTree")]
	private void CheckInstance()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 24)]
	public SubDialogueTree()
	{
	}
}
