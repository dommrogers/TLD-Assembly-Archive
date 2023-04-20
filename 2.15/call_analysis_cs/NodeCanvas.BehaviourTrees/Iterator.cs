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
		[CalledBy(Type = typeof(Iterator), Member = "OnExecute")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[Calls(Type = typeof(Iterator), Member = "get_list")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
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
