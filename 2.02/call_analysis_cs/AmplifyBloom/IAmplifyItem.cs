using Cpp2ILInjected.CallAnalysis;

namespace AmplifyBloom;

internal interface IAmplifyItem
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Destroy();
}
