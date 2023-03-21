using Cpp2ILInjected.CallAnalysis;

public interface IPrioritizable
{
	int m_Priority
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}
}
