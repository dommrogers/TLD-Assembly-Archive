using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class FSMConnection : Connection, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	private ConditionTask _condition;

	public ConditionTask condition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public Task task
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[CallsUnknownMethods(Count = 2)]
	public void PerformTransition()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FSMConnection()
	{
	}
}
