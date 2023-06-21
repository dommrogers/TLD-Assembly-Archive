using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class ExecutionPriorityAttribute : Attribute
{
	public readonly int priority;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ExecutionPriorityAttribute(int priority)
	{
	}
}
