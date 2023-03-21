using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization;

public interface IMissingRecoverable
{
	string missingType
	{
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		get;
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		set;
	}

	string recoveryState
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		set;
	}
}
