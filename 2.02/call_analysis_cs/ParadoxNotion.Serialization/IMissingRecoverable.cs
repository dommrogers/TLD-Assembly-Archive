using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization;

public interface IMissingRecoverable
{
	string missingType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}

	string recoveryState
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}
}
