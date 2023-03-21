using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.StateMachines;

public interface IState
{
	string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	string tag
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	float elapsedTime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	FSM FSM
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	FSMConnection[] GetTransitions();

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	bool CheckTransitions();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Finish(bool success);
}
