using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface ITaskAssignable
{
	Task task
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		set;
	}
}
public interface ITaskAssignable<T> : ITaskAssignable where T : Task
{
}
