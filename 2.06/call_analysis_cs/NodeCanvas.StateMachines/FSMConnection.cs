using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class FSMConnection : Connection, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	private ConditionTask _condition;

	public ConditionTask condition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 61)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 38)]
		set
		{
		}
	}

	public Task task
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 61)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
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
