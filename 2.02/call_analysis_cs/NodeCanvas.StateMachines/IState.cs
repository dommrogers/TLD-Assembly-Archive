using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.StateMachines;

public interface IState
{
	string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	string tag
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	float elapsedTime
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}

	FSM FSM
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	FSMConnection[] GetTransitions();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool CheckTransitions();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Finish(bool success);
}
