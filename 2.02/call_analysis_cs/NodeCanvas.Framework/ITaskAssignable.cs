using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface ITaskAssignable
{
	Task task
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}
}
public interface ITaskAssignable<T> : ITaskAssignable where T : Task
{
}
