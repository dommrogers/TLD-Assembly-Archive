using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IGraphAssignable
{
	Graph nestedGraph
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		set;
	}

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	Graph[] GetInstances();
}
