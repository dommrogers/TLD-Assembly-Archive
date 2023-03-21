using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay;

public interface IShouldDisableForCurrentMode
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	bool ShouldDisableForCurrentMode();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void Update();
}
