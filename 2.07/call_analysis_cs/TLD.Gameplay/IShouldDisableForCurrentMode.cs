using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay;

public interface IShouldDisableForCurrentMode
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	bool ShouldDisableForCurrentMode();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void Update();
}
