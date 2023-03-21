using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization;

public interface IMissingRecoverable
{
	string missingType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		set;
	}

	string recoveryState
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		set;
	}
}
