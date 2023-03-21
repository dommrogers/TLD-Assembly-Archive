using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IUpdatable
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Update();
}
