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
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		get
		{
			return default(int);
		}
	}

	public sealed override Alignment2x2 commentsAlignment
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Alignment2x2);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	protected BTComposite()
	{
	}
}
