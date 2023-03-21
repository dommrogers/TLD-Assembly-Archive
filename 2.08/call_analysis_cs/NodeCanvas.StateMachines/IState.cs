using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.StateMachines;

public interface IState
{
	string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	string tag
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	float elapsedTime
	{
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		get;
	}

	FSM FSM
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	FSMConnection[] GetTransitions();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	bool CheckTransitions();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void Finish(bool success);
}
