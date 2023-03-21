using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface ISubTasksContainer
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	Task[] GetSubTasks();
}
