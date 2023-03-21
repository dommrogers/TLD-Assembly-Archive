using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.BehaviourTrees;

public abstract class BTComposite : BTNode
{
	public override string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Node), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public sealed override int maxOutConnections
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	protected BTComposite()
	{
	}
}
