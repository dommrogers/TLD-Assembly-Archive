using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class Jumper : DTNode
{
	private string _sourceNodeUID;

	private object _sourceNode;

	private string sourceNodeUID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	private DTNode sourceNode
	{
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(Jumper), Member = "get_name")]
		[CalledBy(Type = typeof(Jumper), Member = "get_name")]
		[CalledBy(Type = typeof(Jumper), Member = "OnExecute")]
		[CalledBy(Type = typeof(Jumper), Member = "OnExecute")]
		[CallsUnknownMethods(Count = 16)]
		get
		{
			return null;
		}
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public override int maxOutConnections
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	public override bool requireActorSelection
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public override string name
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Jumper), Member = "get_sourceNode")]
		[Calls(Type = typeof(Jumper), Member = "get_sourceNode")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(DialogueTree), Member = "EnterNode")]
	[Calls(Type = typeof(Jumper), Member = "get_sourceNode")]
	[Calls(Type = typeof(Jumper), Member = "get_sourceNode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	public Jumper()
	{
	}
}
