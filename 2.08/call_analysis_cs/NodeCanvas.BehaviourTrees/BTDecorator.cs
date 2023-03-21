using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.BehaviourTrees;

public abstract class BTDecorator : BTNode
{
	public sealed override int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
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

	protected Connection decoratedConnection
	{
		[CalledBy(Type = typeof(BTDecorator), Member = "get_decoratedNode")]
		[CalledBy(Type = typeof(ConditionalEvaluator), Member = "OnExecute")]
		[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
		[CalledBy(Type = typeof(Guard), Member = "OnExecute")]
		[CalledBy(Type = typeof(Interruptor), Member = "OnExecute")]
		[CalledBy(Type = typeof(Inverter), Member = "OnExecute")]
		[CalledBy(Type = typeof(Iterator), Member = "OnExecute")]
		[CalledBy(Type = typeof(Monitor), Member = "OnExecute")]
		[CalledBy(Type = typeof(Optional), Member = "OnExecute")]
		[CalledBy(Type = typeof(Remapper), Member = "OnExecute")]
		[CalledBy(Type = typeof(Repeater), Member = "OnExecute")]
		[CalledBy(Type = typeof(Setter), Member = "OnExecute")]
		[CalledBy(Type = typeof(Timeout), Member = "OnExecute")]
		[CalledBy(Type = typeof(WaitUntil), Member = "OnExecute")]
		[CallerCount(Count = 39)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	protected Node decoratedNode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	protected BTDecorator()
	{
	}
}
