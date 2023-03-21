using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface ISubTasksContainer
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	Task[] GetSubTasks();
}
