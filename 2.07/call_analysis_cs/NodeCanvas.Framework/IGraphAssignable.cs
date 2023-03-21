using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IGraphAssignable
{
	Graph nestedGraph
	{
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		set;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	Graph[] GetInstances();
}
