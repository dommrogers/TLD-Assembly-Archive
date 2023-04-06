using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class RunForever : ActionTask
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RunForever()
	{
	}
}
