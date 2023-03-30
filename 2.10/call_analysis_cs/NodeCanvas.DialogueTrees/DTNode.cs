using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.DialogueTrees;

public abstract class DTNode : Node
{
	private string _actorName;

	private string _actorParameterID;

	public override string name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Node), Member = "get_name")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(DialogueTree), Member = "get_definedActorParameterNames")]
		[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public virtual bool requireActorSelection
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public override int maxInConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		get
		{
			return 0;
		}
	}

	public override int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	public sealed override Type outConnectionType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	public sealed override bool allowAsPrime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public sealed override Alignment2x2 commentsAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Alignment2x2);
		}
	}

	public sealed override Alignment2x2 iconAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Alignment2x2);
		}
	}

	protected DialogueTree DLGTree
	{
		[CallerCount(Count = 43)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	protected string actorName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(DialogueTree), Member = "GetParameterByName")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	protected IDialogueActor finalActor
	{
		[CalledBy(Type = typeof(ActionListNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
		[CalledBy(TypeFullName = "NodeCanvas.DialogueTrees.ParlayChooseResponseNode.<CountDown>d__13", Member = "MoveNext")]
		[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnOptionSelected")]
		[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(ActionNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(ConditionNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnOptionSelected")]
		[CalledBy(Type = typeof(MultipleConditionNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(ProbabilitySelector), Member = "OnExecute")]
		[CalledBy(Type = typeof(StatementNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
		[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	protected DTNode()
	{
	}
}
