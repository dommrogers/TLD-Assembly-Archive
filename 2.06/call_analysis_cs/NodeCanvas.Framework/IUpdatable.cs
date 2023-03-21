using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IUpdatable
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Update();
}
