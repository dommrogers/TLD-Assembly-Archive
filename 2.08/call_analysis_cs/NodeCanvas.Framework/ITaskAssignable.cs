using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface ITaskAssignable
{
	Task task
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		set;
	}
}
public interface ITaskAssignable<T> : ITaskAssignable where T : Task
{
}
