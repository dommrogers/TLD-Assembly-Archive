using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IGraphAssignable
{
	Graph nestedGraph
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		set;
	}

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	Graph[] GetInstances();
}
