using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IGraphAssignable
{
	Graph nestedGraph
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	Graph[] GetInstances();
}
