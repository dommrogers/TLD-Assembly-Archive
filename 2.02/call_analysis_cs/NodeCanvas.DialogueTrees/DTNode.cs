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
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(DialogueTree), Member = "get_definedActorParameterNames")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Node), Member = "get_name")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
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
			return default(bool);
		}
	}

	public override int maxInConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public override int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public sealed override Type outConnectionType
	{
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return default(bool);
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
		[CallerCount(Count = 54)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	protected string actorName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(DialogueTree), Member = "GetParameterByName")]
		[Calls(Type = typeof(DialogueTree.ActorParameter), Member = "get_ID")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	protected IDialogueActor finalActor
	{
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
		[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected DTNode()
	{
	}
}
