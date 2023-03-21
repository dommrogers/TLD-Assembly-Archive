using System.Collections;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class Iterator : BTDecorator
{
	public enum TerminationConditions
	{
		None,
		FirstSuccess,
		FirstFailure
	}

	public BBParameter<IList> targetList;

	public BBObjectParameter current;

	public BBParameter<int> storeIndex;

	public BBParameter<int> maxIteration;

	public TerminationConditions terminationCondition;

	public bool resetIndex;

	private int currentIndex;

	private IList list
	{
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(Iterator), Member = "OnExecute")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(Iterator), Member = "get_list")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public Iterator()
	{
	}
}
