using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IGraphElement
{
	Graph graph
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}
}
