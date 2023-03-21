using System;
using System.Linq;
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
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	private DTNode sourceNode
	{
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(Jumper), Member = "OnExecute")]
		[CalledBy(Type = typeof(Jumper), Member = "OnExecute")]
		[CalledBy(Type = typeof(Jumper), Member = "get_name")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(Jumper), Member = "get_name")]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		set
		{
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

	public override bool requireActorSelection
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public override string name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Jumper), Member = "get_sourceNode")]
		[Calls(Type = typeof(Jumper), Member = "get_sourceNode")]
		[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Node), Member = "Error")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DialogueTree), Member = "EnterNode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(Jumper), Member = "get_sourceNode")]
	[Calls(Type = typeof(Jumper), Member = "get_sourceNode")]
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
