using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface ISubTasksContainer
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	Task[] GetSubTasks();
}
