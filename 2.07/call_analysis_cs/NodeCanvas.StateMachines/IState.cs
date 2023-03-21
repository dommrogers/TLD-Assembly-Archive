using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.StateMachines;

public interface IState
{
	string name
	{
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		get;
	}

	string tag
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	float elapsedTime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	FSM FSM
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	FSMConnection[] GetTransitions();

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	bool CheckTransitions();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void Finish(bool success);
}
